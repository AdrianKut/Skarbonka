using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using MySql.Data.MySqlClient;


namespace Skarbonka
{
   


    public partial class FormLogin : Form
    {
  


        public FormLogin()
        {

            InitializeComponent();

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {



            MySqlConnection mysqlcon = new MySqlConnection(@"Server =remotemysql.com; Database = 8NZnZS6QX7; Uid = 8NZnZS6QX7; Pwd = 5fOJTvlcO9; PORT = 3306;");
            string checkmysql = " SELECT Imię, Nazwisko,loginId FROM loginId WHERE login = '" + txtLogin.Text + "' and password = '" + txtPassword.Text + "'";
            MySqlDataAdapter mysqladapter = new MySqlDataAdapter(checkmysql, mysqlcon);
            mysqlcon.Open();

            DataTable dt = new DataTable();
            mysqladapter.Fill(dt);
            if (dt.Rows.Count == 1)
            {

                List<string> wysylka = new List<string>();
                wysylka.Add(dt.Rows[0][0].ToString());
                wysylka.Add(dt.Rows[0][1].ToString());
                wysylka.Add(dt.Rows[0][2].ToString());
                this.Hide(); // ukrywa aktualny formularz          
                FormMain objFormMain = new FormMain(wysylka.ElementAt(0),wysylka.ElementAt(1),wysylka.ElementAt(2));            
                //    FormMain objFormMain = new FormMain(dt.Rows[0][1].ToString());
                //                FormMain objFormMain = new FormMain(dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString());
                MessageBox.Show("Witaj w programie Skarbonka!", "Skarbonka");
                objFormMain.Show(); // otwiera formularz main



            }
            else
            {
                MessageBox.Show("Nieprawidłowy login lub hasło!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //usuwa login i hasło po wprowadzeniu błędnych danych
                txtLogin.Clear();
                txtPassword.Clear();

            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy na pewno chcesz skończyć program?", "Login",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    foreach (Process proc in Process.GetProcessesByName("osk"))
                    {                   
                        proc.Kill();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                //zamykanie aplikacji.
                try
                {

                    Application.Exit();
                    MessageBox.Show("Koniec programu!", "Skarbonka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception msg)
                {

                    MessageBox.Show("Nie udało się zamknąć programu!" + msg.Message);
                }

            }
            else if (dr == DialogResult.No)
            {
               
            }
            

            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


            if (checkBox1.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
            }

            if (checkBox1.Checked == false)
            {
                txtPassword.PasswordChar = '*';
            }


        }

        private void screenKeyboard_Click(object sender, EventArgs e)
        {

        
            if (screenKeyboard.Enabled == true)
            {
                screenKeyboard.Enabled = false;
                var process = Process.Start(@"C:\Windows\system32\osk.exe");

            }
            else
            {
               
              screenKeyboard.Enabled = true;
                
            }


        }

        private void linkCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            CreateLogin objCreateLogin = new CreateLogin();
            this.Hide();
            objCreateLogin.Show();
        }



        
    }
}
