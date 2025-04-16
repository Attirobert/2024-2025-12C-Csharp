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
    public partial class OsztalyokForm : Form
    {
        // Osztályváltozók
        private MySqlConnection connection;
        private DataSet dataSet;
        private MySqlDataAdapter dataAdapter;
        private BindingSource bindingSource;
        private MySqlCommandBuilder commandBuilder;

        private string TableName = "osztalyok";


        public OsztalyokForm()
        {
            InitializeComponent();
            InitializeDatabase();
            InitializeDataAdapter();
            InitializeDataGridView();
            InitializeBindingNavigator();
            connection.Close();
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

        private void InitializeDataAdapter()
        {
            // SqlDataAdapter inicializálása
            dataAdapter = new MySqlDataAdapter($"SELECT * FROM {TableName}", connection);

            // MySqlCommandBuilder inicializálása
            commandBuilder = new MySqlCommandBuilder(dataAdapter);

            // DataSet inicializálása
            dataSet = new DataSet();

            // DataTable létrehozása
            DataTable dataTable = new DataTable(TableName);

            // SqlDataAdapter adatokkal feltöltése
            dataAdapter.Fill(dataTable);

            // DataTable hozzáadása a DataSet-hez
            dataSet.Tables.Add(dataTable);
        }

        private void InitializeDataGridView()
        {
            // DataGridView inicializálása és adatforrás beállítása
            dataGridView1.DataSource = dataSet.Tables[TableName];
        }

        private void InitializeBindingNavigator()
        {
            // BindingSource inicializálása és beállítása
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataSet.Tables[TableName];

            // BindingNavigator inicializálása és beállítása
            bindingNavigator1.BindingSource = bindingSource;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Változtatások mentése az adatbázisba
            // A DataAdapter és a mögötte álló MySqlCommandBuilder automatikusan figyelembe veszi a RowState értékét, és a megfelelő parancsokat hívja meg az alapján.
            dataAdapter.Update(dataSet, TableName);
            MessageBox.Show("Változtatások mentve!");
        }

        private void OsztalyokForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Adatbáziskapcsolat bezárása a program leállításakor
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
