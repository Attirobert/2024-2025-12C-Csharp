﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MySqlUsersElo2
{
    public partial class Form1 : Form
    {
        // Változók definiálása
        #region Kapcsolat properties
        private MySqlConnection msqlConn;
        private MySqlDataReader msqlDr;
        #endregion Kapcsolat properties

        #region Tárolt eljárások
        private string userTeljesLista = "usersTeljesLista";
        private string userInsert = "UserInsert";
        private string userUpdate = "UserUpdate";
        private string userDelete = "UserDelete";
        //private string userSearch = "UserSearch";
        #endregion Tárolt eljárások

        #region A Form és az adatbázis állapotai
        private enum FormState
        {
            Closed, // Zárva, nincs csatlakozva
            Opened,     // Adatbázishoz csatlakozva, de olvasásra nincs megnyitva
            Reading,    // Olvasás közben
            EditInsert,  // Beszúrás adatainak beírása közben
            EditUpdate  // Rekord szerkesztése közben
            //EditSearch  // Keresendő adat megadása állapotban vagyok
        }
        private FormState formState = FormState.Closed;
        #endregion A Form és az adatbázis állapotai

        #region Gomb feliratok
        private string insBasic = "Beszúrás";
        private string insEdit = "Szerkesztés vége";
        private string updBasic = "Módosítás";
        private string updEdit = "Módosítás vége";
        #endregion Gomb feliratok

        #region Üzenet szövegek
        private string openSikeres = "A kapcsolódás az adatbázishoz sikeres!",
            openNemSikeres = "A kapcsolódás az adatbázishoz sikertelen!",
            canToRead = "Az olvasás megkezdődhet!",
            closedDB = "Az adatbázis bezárva";
        #endregion Üzenet szövegek

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            mysqlConnect();
        }

        #region Kapcsolódás az adatbázishoz
        private void mysqlConnect()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "iktat";

            try
            {
                msqlConn = new MySqlConnection(sb.ToString());
                msqlConn.Open();
                MessageBox.Show(openSikeres);

                formState = FormState.Opened;
                buttonSwitch(formState);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{openNemSikeres} \n {ex.Message}");
            }
        }
        #endregion Kapcsolódás az adatbázishoz

        #region Gombok elérhetőségének beállítása
        private void buttonSwitch(FormState fs)
        {
            switch (fs)
            {
                case FormState.Closed:
                    btnConn.Enabled = true;
                    btnOpen.Enabled = false;
                    btnRead.Enabled = false;
                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnClose.Enabled = false;
                    break;
                case FormState.Opened:
                    btnConn.Enabled = false;
                    btnOpen.Enabled = true;
                    btnRead.Enabled = false;
                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnClose.Enabled = true;

                    tbxID.Enabled = false;
                    tbxNev.Enabled = false;
                    tbxJelszo.Enabled = false;
                    cbxAdmin.Enabled = false;

                    // Gomb feliratok
                    btnInsert.Text = insBasic;
                    btnUpdate.Text = updBasic;
                    break;
                case FormState.Reading:
                    btnConn.Enabled = false;
                    btnOpen.Enabled = false;
                    btnRead.Enabled = true;
                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnClose.Enabled = true;
                    break;
                case FormState.EditInsert:
                    btnConn.Enabled = false;
                    btnOpen.Enabled = false;
                    btnRead.Enabled = false;
                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnClose.Enabled = true;

                    // Beviteli mezők elérhetősége
                    tbxNev.Enabled = true;
                    tbxJelszo.Enabled = true;
                    cbxAdmin.Enabled = true;

                    // Beviteli mezők ürítése
                    tbxNev.Text = String.Empty;
                    tbxJelszo.Text = String.Empty;
                    cbxAdmin.Checked = false;

                    // Gomb feliratok
                    btnInsert.Text = insEdit;
                    break;
                case FormState.EditUpdate:
                    btnConn.Enabled = false;
                    btnOpen.Enabled = false;
                    btnRead.Enabled = false;
                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = false;
                    btnClose.Enabled = true;

                    tbxNev.Enabled = true;
                    tbxJelszo.Enabled = true;
                    cbxAdmin.Enabled = true;

                    // Gomb feliratok
                    btnUpdate.Text = updEdit;
                    break;

                /*
                case FormState.EditSearch:
                    foreach (var item in lstButtons)
                        item.Enabled = false;
                    btnKeres.Enabled = true;

                    tbxNev.Enabled = true;
                    tbxJelszo.Enabled = false;
                    cbxAdmin.Enabled = false;

                    // Gomb feliratok
                    //btnKeres.Text = updEdit;
                    break;
                */
            }
        }
        #endregion Gombok elérhetőségének beállítása

        #region Adatbázis megnyitása
        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (MySqlCommand sqlComm = new MySqlCommand(userTeljesLista, msqlConn))
            {
                sqlComm.CommandType = CommandType.StoredProcedure;

                try
                {
                    // Olvasás a táblából
                    msqlDr = sqlComm.ExecuteReader();

                    MessageBox.Show(canToRead);

                    formState = FormState.Reading;
                    buttonSwitch(formState);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion Adatbázis megnyitása

        private void btnRead_Click(object sender, EventArgs e)
        {
            NextUser();
        }

        #region A következő rekord olvasása
        private void NextUser()
        {
            // A következő rekord olvasása
            msqlDr.Read();
            tbxID.Text = msqlDr[0].ToString().Trim();
            tbxNev.Text = msqlDr[1].ToString().Trim();
            tbxJelszo.Text = msqlDr[2].ToString().Trim();
            cbxAdmin.Checked = (bool)msqlDr[3];
        }
        #endregion A következő rekord olvasása

        private void btnInsert_Click(object sender, EventArgs e)
        {
            switch (formState)
            {
                case FormState.Opened:
                    formState = FormState.EditInsert;
                    buttonSwitch(formState);
                    break;
                case FormState.Reading:
                    msqlDr.Close();
                    formState = FormState.EditInsert;
                    buttonSwitch(formState);
                    break;
                case FormState.EditInsert:
                    InsertUser(tbxNev.Text, tbxJelszo.Text, (cbxAdmin.Checked) ? 1 : 0);
                    formState = FormState.Opened;
                    buttonSwitch(formState);
                    break;
            }
        }

        #region Rekord beszúrása
        private void InsertUser(string pNev, string pJelszo, int pAdmin)
        {
            using (MySqlCommand sqlComm = new MySqlCommand(userInsert, msqlConn))
            {
                sqlComm.CommandType = CommandType.StoredProcedure;

                // Paraméterek beállítása
                MySqlParameter p = new MySqlParameter();
                p.ParameterName = "pNev";
                p.Value = pNev;
                p.MySqlDbType = MySqlDbType.String;
                sqlComm.Parameters.Add(p);

                sqlComm.Parameters.AddWithValue("pJelszo", pJelszo);
                sqlComm.Parameters.AddWithValue("pAdmin", pAdmin);

                try
                {
                    // Olvasás a táblából
                    sqlComm.ExecuteNonQuery();
                    MessageBox.Show("Az rekord felvétele sikeres.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion Rekord beszúrása

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            switch (formState)
            {
                case FormState.Opened:
                    formState = FormState.EditUpdate;
                    buttonSwitch(formState);
                    break;
                case FormState.Reading:
                    msqlDr.Close();
                    formState = FormState.EditUpdate;
                    buttonSwitch(formState);
                    break;
                case FormState.EditUpdate:
                    UpdateUser(Convert.ToInt32(tbxID.Text), tbxNev.Text, tbxJelszo.Text, (cbxAdmin.Checked) ? 1 : 0);
                    formState = FormState.Opened;
                    buttonSwitch(formState);
                    break;
            }
        }

        #region Rekord módosítása
        private void UpdateUser(int pID, string pNev, string pJelszo, int pAdmin)
        {
            using (MySqlCommand sqlComm = new MySqlCommand(userUpdate, msqlConn))
            {
                sqlComm.CommandType = CommandType.StoredProcedure;

                // Paraméterek beállítása
                sqlComm.Parameters.AddWithValue("pID", pID);

                MySqlParameter p = new MySqlParameter();
                p.ParameterName = "pNev";
                p.Value = pNev;
                p.MySqlDbType = MySqlDbType.String;
                sqlComm.Parameters.Add(p);

                sqlComm.Parameters.AddWithValue("pJelszo", pJelszo);
                sqlComm.Parameters.AddWithValue("pAdmin", pAdmin);

                try
                {
                    // Olvasás a táblából
                    sqlComm.ExecuteNonQuery();
                    MessageBox.Show("Az rekord módosítása sikeres.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion Rekord módosítása

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // A form állapotának beállítása
            switch (formState)
            {
                case FormState.Reading:
                    break;
            }
            if (formState == FormState.Reading)
            {
                msqlDr.Close(); // Bezárom a DataReader típusú objektumot, mert az új művelethez előlről kell olvasni az adatbázist

                formState = FormState.Opened;
                buttonSwitch(formState);
            }
            DeleteUser(Convert.ToInt32(tbxID.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Rekord törlése
        private void DeleteUser(int pID)
        {
            using (MySqlCommand sqlComm = new MySqlCommand(userDelete, msqlConn))
            {
                sqlComm.CommandType = CommandType.StoredProcedure;

                // Paraméterek beállítása
                sqlComm.Parameters.AddWithValue("pID", pID);

                try
                {
                    // Törlés a táblából
                    sqlComm.ExecuteNonQuery();
                    MessageBox.Show("A rekord törlése sikeres.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion Rekord törlése

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Ha még nincs bezárva az adatbázis, akkor bezárom
            if (msqlConn != null)
            {
                msqlConn.Close();
                MessageBox.Show(closedDB);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            msqlConn.Close();
            MessageBox.Show(closedDB);

            formState = FormState.Closed;
            buttonSwitch(formState);
        }

        #region Keresés
        /*
        private void btnKeres_Click(object sender, EventArgs e)
        {
            if (formState == FormState.EditSearch)
            {
                // Lezárom az adatbázist
                msqlDr.Close();
                formState = FormState.Opened;
                buttonSwitch(formState);

                // Elvégzem a keresést
                SearchUser(tbxNev.Text);

                // Megjelenítem a találatot
                NextUser();

                // Visszaállítom az adatbázist, a gombokat és a mezőket Reading állapotba
            }
            else
            {
                formState = FormState.EditSearch;
                buttonSwitch(formState);
            }
        }

        private void SearchUser(string pNev)
        {
            using (MySqlCommand sqlComm = new MySqlCommand(userSearch, msqlConn))
            {
                sqlComm.CommandType = CommandType.StoredProcedure;

                // Paraméterek beállítása
                sqlComm.Parameters.AddWithValue("pNev", pNev);
                try
                {
                    // Olvasás a táblából
                    msqlDr = sqlComm.ExecuteReader();

                    formState = FormState.Reading;
                    buttonSwitch(formState);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        */
        #endregion Keresés
    }
}
