using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using GetDBConnection;

namespace IktatoMySql
{
    public partial class BeosztasokForm : Form
    {
        // Osztályváltozók
        private MySqlConnection connection;
        private DataSet dataSet;
        private MySqlDataAdapter dataAdapter;
        private BindingSource bindingSource;
        private BeosztasokClass beosztasClass;

        private string TableName = "beosztasok";

        public BeosztasokForm()
        {
            InitializeComponent();
            InitializeDatabase();
            InitializeDataGridView();
            InitializeBindingNavigator();
            connection.Close();
            beosztasClass = new BeosztasokClass(DBConnectionsClass.GetConnectionString_2("MyDbConnection"));
        }

        private void InitializeBindingNavigator()
        {
            bindingNavigator1.BindingSource = bindingSource;
        }

        private void InitializeDataGridView()
        {
            // DataSet inicializálása
            dataSet = new DataSet();

            // DataTable létrehozása
            DataTable dataTable = new DataTable(TableName);

            // Adatok lekérése az adatbázisból és feltöltése az adattáblába
            string query = $"SELECT * FROM {TableName}";
            dataAdapter = new MySqlDataAdapter(query, connection);
            dataAdapter.Fill(dataTable);

            // Adatok feltöltése a DataSet-be
            dataSet.Tables.Add(dataTable);

            // BindingSource beállítása
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataSet.Tables[TableName];

            // DataGridView beállítása
            dataGridView1.DataSource = bindingSource;
        }

        private void InitializeDatabase()
        {
            // Adatbázis kapcsolat
            connection = new MySqlConnection(DBConnectionsClass.GetConnectionString_2("MyDbConnection"));

            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Sikertelen kapcsolódás \n {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            int insert = 0,
                delete = 0,
                update = 0;

            // Változtatások mentése
            foreach (DataRow row in dataSet.Tables[TableName].Rows)
            {
                switch (row.RowState)
                {
                    case DataRowState.Added:
                        beosztasClass.dataInsert(row, connection);
                        insert++;
                        break;
                    case DataRowState.Deleted:
                        beosztasClass.dataDelete(row, connection);
                        delete++;
                        break;
                    case DataRowState.Modified:
                        beosztasClass.dataUpdate(row, connection);
                        update++;
                        break;
                }
            }

            if (insert+update+delete>0)
            {
            MessageBox.Show($"Az adatbázis frissítése sikeres\nHozzá adva: {insert}\nTörölve: {delete}\nMódosítva: {update}", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            MessageBox.Show("Nem volt szükség frissítésre", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BeosztasokForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
