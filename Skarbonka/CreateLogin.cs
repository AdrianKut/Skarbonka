using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.IO;
using MySql.Data.MySqlClient;

namespace Skarbonka
{
    public partial class CreateLogin : Form

    {

        public static void ZapiszDoPlikuTekstowego(string nazwaPliku, string tekst)
        {
            using (StreamWriter sw = new StreamWriter(nazwaPliku))
            {
                foreach (char wiersz in tekst)
                    sw.Write(wiersz);
            }
        }

        public CreateLogin()
        {
            InitializeComponent();
        }

        private void CreateLogin_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'loginDBDataSet.loginId' . Możesz go przenieść lub usunąć.


        }

        private void CreateLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

            FormLogin objFormLogin = new FormLogin();
            this.Hide();
            objFormLogin.Show();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool haslo = false;
            bool login = false;
            bool imie = false;
            bool nazwisko = false;


            MySqlConnection sqlcon = new MySqlConnection(@"Server =remotemysql.com; Database = 8NZnZS6QX7; Uid = 8NZnZS6QX7; Pwd = 5fOJTvlcO9; PORT = 3306;");
            sqlcon.Open();
            MySqlCommand cmdInsert = new MySqlCommand("INSERT INTO loginId (login,password,Imię,Nazwisko ) VALUES (@login,@password,@Imię,@Nazwisko)", sqlcon);


            string check = "SELECT login FROM loginId WHERE login = '" + txtLogin.Text + "';";
            MySqlDataAdapter sda = new MySqlDataAdapter(check, sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                login = true;
                txtWrongLogin.Visible = false; // hide red label about login

            }
            else
            {
                login = false;
                txtWrongLogin.Visible = true;          // visible red label about login
                txtLogin.Clear();

            }


            if (txtPassword.Text != txtPasswordv2.Text)
            {
                txtWrongPassword.Visible = true;          // visible red label about diffrent password 
                txtPassword.Clear();
                txtPasswordv2.Clear();
                haslo = false;
            }
            else
            {           
                haslo = true;
            }


            if (txtImie.Text == "" || txtLogin.Text == "" || txtNazwisko.Text == "" || txtPassword.Text =="" || txtPasswordv2.Text == "")
            {
                txtNotFilled.Visible = true;
            }


            if (txtImie.Text == "")
            {               
                imie = false;
            }
            else imie = true;


            if (txtNazwisko.Text == "")
            {
                nazwisko = false;
            }
            else nazwisko = true;


            if (txtLogin.Text == "")
            {
                login = false;
            }
            else login = true;


            if (txtPassword.Text == "")
            {
                haslo = false;
            }
            else haslo = true;



            if (haslo == true && login == true && imie == true && nazwisko == true)
            {
                txtWrongPassword.Visible = false;
                txtWrongLogin.Visible = false;
                txtNotFilled.Visible = false;


                DialogResult rs = MessageBox.Show("Czy chcesz utworzyć plik z danymi? \n\n" + "Imię:    " + txtImie.Text + "\nNazwisko: " + txtNazwisko.Text + "\nLogin:    " + txtLogin.Text + "\nHasło:   " + txtPassword.Text, "Pomyślnie utworzono konto!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (rs)
                {
                    case DialogResult.Yes:
                        string nazwaPliku = openFileDialog1.FileName;
                        if (nazwaPliku.Length > 0) saveFileDialog1.FileName = nazwaPliku;
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            nazwaPliku = saveFileDialog1.FileName;
                            ZapiszDoPlikuTekstowego(nazwaPliku, "Imię:    " + txtImie.Text + "\nNazwisko: " + txtNazwisko.Text + "\nLogin:    " + txtLogin.Text + "\nHasło:   " + txtPassword.Text);
                            int ostatniSlash = nazwaPliku.LastIndexOf('\\');
                        }

                        break;
                    case DialogResult.No:
                        break;
                }


                FormLogin objFormLogin = new FormLogin();
                
                cmdInsert.Parameters.AddWithValue("login", txtLogin.Text);
                cmdInsert.Parameters.AddWithValue("password", txtPassword.Text);
                cmdInsert.Parameters.AddWithValue("Imię", txtImie.Text);
                cmdInsert.Parameters.AddWithValue("Nazwisko", txtNazwisko.Text);
                cmdInsert.ExecuteNonQuery();
                sqlcon.Close();
                this.Hide();
                objFormLogin.Show();

           

            }



        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            FormLogin objFormLogin = new FormLogin();
            this.Hide();
            objFormLogin.Show();
        }
    }
}
