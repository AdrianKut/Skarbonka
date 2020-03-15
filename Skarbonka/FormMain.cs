using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Skarbonka
{


    public partial class FormMain : Form
    {


        //zwykły wydrukt
        // Bitmap bmp;

       
        public FormMain(string imie,string nazwisko, string loginid)
        {
            InitializeComponent();

            //pobrane parametry z formularza FormLogin
            txtImieNazwisko.Text = imie + " " + nazwisko;
            txtNazwisko.Text = nazwisko;
            txtLoginId.Text = loginid;

        }

        public FormMain()
        {
        }

       

        private void zawartośćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //uruchomienie formularza OpisProgramu
            OpisProgramu opisprog = new OpisProgramu();
            opisprog.Owner = this; // Formularz OpisProgramu przechodzi na pierwszy plan, dopóki jest otwarty nie można nic robić w FormMain;
            opisprog.ShowDialog(); 

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            //przycisk do wylogowania się
            DialogResult rs = MessageBox.Show("Czy na pewno chcesz się wylogować?", "Skarbonka",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

            switch (rs)
            {
                case DialogResult.OK:
                    FormLogin objFormLogin = new FormLogin();
                    this.Hide();
                    objFormLogin.Show();
                    break;
                case DialogResult.Cancel:
                    break;
            }
       
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Zamykanie procesu klawiatury
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

        private void FormMain_Load(object sender, EventArgs e)
        {
            
            //domyślne ustawienia textboxow
            textBoxNumer.Enabled = false;
            textBoxKategoria.Enabled = false;
            textBoxNazwa.Enabled = false;
            textBoxCena.Enabled = false;
            textBoxIlosc.Enabled = false;
            textBoxData.Enabled = false;
            textBoxSuma.Enabled = false;
            
            //Wyświetlanie danych osobowych użytkownika
            txtUser.Visible = true;
            txtImieNazwisko.Visible = true;


            //połączenie się z bazą danych w celu wyświetlenia danych w formie tabeli
            string connection = @"Server=remotemysql.com; Database = 8NZnZS6QX7; Uid = 8NZnZS6QX7; Pwd = 5fOJTvlcO9; PORT = 3306;";
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                mysqlcon.Open();
                MySqlDataAdapter sqlData = new MySqlDataAdapter("SELECT  Id as Numer, Kategoria, Nazwa_produktu, Cena, Ilosc, Data, (Ilosc*Cena) AS Suma FROM Platnosci JOIN loginId ON Platnosci.loginId=loginId.loginId WHERE nazwisko = '" + txtNazwisko.Text + "';",connection);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                dataGridView1.DataSource = dtbl;

                //załadowanie danych do wykresu
                Wykres.DataSource = dtbl;
                Wykres.Series["Wydatki"].XValueMember = "Data";
                Wykres.Series["Wydatki"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                Wykres.Series["Wydatki"].YValueMembers = "Cena";
                Wykres.Series["Wydatki"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            }
        }

        private void dokumentacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //uruchomienie  dokumentacji technicznej w pliku
            try
            {
                foreach (Process proc in Process.GetProcessesByName("Dokumentacja.docx"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            Process.Start(System.AppDomain.CurrentDomain.BaseDirectory + @"Dokumentacja.docx");
            

        }

    
        private void buttonDodajProdukt_Click(object sender, EventArgs e)
        {
          
            //uruchomienie formularza do modyfikacji wpisów
            nowyWpis objwpis = new nowyWpis(txtLoginId.Text); 
            objwpis.Owner = this;// Formularz nowyWpis przechodzi na pierwszy plan, dopóki jest otwarty nie można nic robić w FormMain;
            objwpis.ShowDialog();

        }

       
     

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            //domyślne ustawienia porownania
            flowLayoutPanelPorownania.Visible = false;



            //domyślne wartości checkboxow
            checkBoxNumer.Checked = false;
            checkBoxNazwa.Checked = false;
            checkBoxKategoria.Checked = false;
            checkBoxIlosc.Checked = false;
            checkBoxData.Checked = false;
            checkBoxCena.Checked = false;
            checkBoxSuma.Checked = false;


            //domyślne wartości radiobutonow
            radioButtonWiekszy.Checked = false;
            radioButtonWiekszyRowny.Checked = false;
            radioButtonMniejszy.Checked = false;
            radioButtonMniejszyRowny.Checked = false;
            radioButtonRowny.Checked = false;
            radioButtonRozny.Checked = false;

            //domyślne ustawienia textboxow
            textBoxNumer.Enabled = false;
            textBoxNumer.Value = 0;

            textBoxKategoria.Enabled = false;
            textBoxKategoria.ClearSelected();

            textBoxNazwa.Enabled = false;
            textBoxNazwa.Text = "";

            textBoxCena.Enabled = false;
            textBoxCena.Value = 0;

            textBoxIlosc.Enabled = false;
            textBoxIlosc.Value = 0;

            textBoxData.Enabled = false;
            textBoxData.Text = "";

            textBoxSuma.Enabled = false;
            textBoxSuma.Value = 0;


            //przywracanie domyślnego wyglądu Tabeli Platnosci 
            string connection = @"Server =remotemysql.com; Database = 8NZnZS6QX7; Uid = 8NZnZS6QX7; Pwd = 5fOJTvlcO9; PORT = 3306;";
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                mysqlcon.Open();

                MySqlDataAdapter sqlData = new MySqlDataAdapter("Select Id as Numer, Kategoria, Nazwa_Produktu, Cena, ilosc as Ilość, Data, (ilosc*cena) as Suma From Platnosci JOIN loginId ON Platnosci.loginId=loginId.loginId WHERE nazwisko = '" + txtNazwisko.Text + "';", connection);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dataGridView1.DataSource = dtbl;

                //załadowanie danych do wykresu
                Wykres.DataSource = dtbl;
                Wykres.Series["Wydatki"].XValueMember = "Data";
                Wykres.Series["Wydatki"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                Wykres.Series["Wydatki"].YValueMembers = "Cena";
                Wykres.Series["Wydatki"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;



            }
        }

        private void buttonFinder_Click(object sender, EventArgs e)
        {

            //szukanie poszczególnych elementów w zależności od wyboru  
            MySqlConnection mysqlcon = new MySqlConnection(@"Server =remotemysql.com; Database = 8NZnZS6QX7; Uid = 8NZnZS6QX7; Pwd = 5fOJTvlcO9; PORT = 3306;");
            mysqlcon.Open();

           
            // szukanie po numer_id                
            if (checkBoxNumer.Checked == true)
            {
                

                string select = "SELECT Id as Numer, Kategoria, Nazwa_Produktu, Cena, ilosc as Ilość, Data, (ilosc*cena) as Suma  FROM Platnosci JOIN loginId ON Platnosci.loginId=loginId.loginId WHERE Id = '" + textBoxNumer.Text + "'and nazwisko = '" + txtNazwisko.Text + "';";
                MySqlDataAdapter sqlData = new MySqlDataAdapter(select, mysqlcon);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                dataGridView1.DataSource = dtbl;

                //załadowanie danych do wykresu
                Wykres.DataSource = dtbl;
                Wykres.Series["Wydatki"].XValueMember = "Data";
                Wykres.Series["Wydatki"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                Wykres.Series["Wydatki"].YValueMembers = "Cena";
                Wykres.Series["Wydatki"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;


            }// koniec szukanie po numer_id


            // szukanie po kategoria                
            if (checkBoxKategoria.Checked == true)
            {

                string select = "SELECT Id as Numer, Kategoria, Nazwa_Produktu, Cena, ilosc as Ilość, Data, (ilosc*cena) as Suma  FROM Platnosci  JOIN loginId ON Platnosci.loginId=loginId.loginId WHERE Kategoria = '" + textBoxKategoria.Text + "'and nazwisko = '" + txtNazwisko.Text + "';";
                MySqlDataAdapter sqlData = new MySqlDataAdapter(select, mysqlcon);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                dataGridView1.DataSource = dtbl;

                //załadowanie danych do wykresu
                Wykres.DataSource = dtbl;
                Wykres.Series["Wydatki"].XValueMember = "Data";
                Wykres.Series["Wydatki"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                Wykres.Series["Wydatki"].YValueMembers = "Cena";
                Wykres.Series["Wydatki"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;


            }// koniec szukanie po kategoria


            // szukanie po nazwa
            if (checkBoxNazwa.Checked == true)
            {

                string select = "SELECT Id as Numer, Kategoria, Nazwa_Produktu, Cena, ilosc as Ilość, Data, (ilosc*cena) as Suma  FROM Platnosci JOIN loginId ON Platnosci.loginId=loginId.loginId WHERE Nazwa_Produktu like '" + textBoxNazwa.Text + "'and nazwisko = '" + txtNazwisko.Text + "';";
                MySqlDataAdapter sqlData = new MySqlDataAdapter(select, mysqlcon);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                dataGridView1.DataSource = dtbl;

                //załadowanie danych do wykresu
                Wykres.DataSource = dtbl;
                Wykres.Series["Wydatki"].XValueMember = "Data";
                Wykres.Series["Wydatki"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                Wykres.Series["Wydatki"].YValueMembers = "Cena";
                Wykres.Series["Wydatki"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;


            }//koniec szukanie po nazwa



            //szukanie po cena
            if (checkBoxCena.Checked == true)
                {

                if (radioButtonWiekszy.Checked == true)
                {
                    string select = "SELECT Id as Numer, Kategoria, Nazwa_Produktu, Cena, ilosc as Ilość, Data, (ilosc*cena) as Suma  FROM Platnosci JOIN loginId ON Platnosci.loginId=loginId.loginId WHERE Cena > '" + textBoxCena.Text + "'and nazwisko = '" + txtNazwisko.Text + "';";

                    MySqlDataAdapter sqlData = new MySqlDataAdapter(select, mysqlcon);
                    DataTable dtbl = new DataTable();
                    sqlData.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;

                    //załadowanie danych do wykresu
                    Wykres.DataSource = dtbl;
                    Wykres.Series["Wydatki"].XValueMember = "Data";
                    Wykres.Series["Wydatki"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    Wykres.Series["Wydatki"].YValueMembers = "Cena";
                    Wykres.Series["Wydatki"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

                }
                else if (radioButtonWiekszyRowny.Checked == true)
                {
                    string select = "SELECT Id as Numer, Kategoria, Nazwa_Produktu, Cena, ilosc as Ilość, Data, (ilosc*cena) as Suma  FROM Platnosci JOIN loginId ON Platnosci.loginId=loginId.loginId WHERE Cena >= '" + textBoxCena.Text + "'and nazwisko = '" + txtNazwisko.Text + "';";

                    MySqlDataAdapter sqlData = new MySqlDataAdapter(select, mysqlcon);
                    DataTable dtbl = new DataTable();
                    sqlData.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;

                    //załadowanie danych do wykresu
                    Wykres.DataSource = dtbl;
                    Wykres.Series["Wydatki"].XValueMember = "Data";
                    Wykres.Series["Wydatki"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    Wykres.Series["Wydatki"].YValueMembers = "Cena";
                    Wykres.Series["Wydatki"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

                }
                else if (radioButtonMniejszy.Checked == true)
                {
                    string select = "SELECT Id as Numer, Kategoria, Nazwa_Produktu, Cena, ilosc as Ilość, Data, (ilosc*cena) as Suma  FROM Platnosci JOIN loginId ON Platnosci.loginId=loginId.loginId WHERE Cena < '" + textBoxCena.Text + "'and nazwisko = '" + txtNazwisko.Text + "';";

                    MySqlDataAdapter sqlData = new MySqlDataAdapter(select, mysqlcon);
                    DataTable dtbl = new DataTable();
                    sqlData.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;

                    //załadowanie danych do wykresu
                    Wykres.DataSource = dtbl;
                    Wykres.Series["Wydatki"].XValueMember = "Data";
                    Wykres.Series["Wydatki"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    Wykres.Series["Wydatki"].YValueMembers = "Cena";
                    Wykres.Series["Wydatki"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

                }
                else if (radioButtonMniejszyRowny.Checked == true)
                {
                    string select = "SELECT Id as Numer, Kategoria, Nazwa_Produktu, Cena, ilosc as Ilość, Data, (ilosc*cena) as Suma  FROM Platnosci JOIN loginId ON Platnosci.loginId=loginId.loginId WHERE Cena <= '" + textBoxCena.Text + "'and nazwisko = '" + txtNazwisko.Text + "';";

                    MySqlDataAdapter sqlData = new MySqlDataAdapter(select, mysqlcon);
                    DataTable dtbl = new DataTable();
                    sqlData.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;

                    //załadowanie danych do wykresu
                    Wykres.DataSource = dtbl;
                    Wykres.Series["Wydatki"].XValueMember = "Data";
                    Wykres.Series["Wydatki"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    Wykres.Series["Wydatki"].YValueMembers = "Cena";
                    Wykres.Series["Wydatki"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

                }
                else if (radioButtonRowny.Checked == true)
                {
                    string select = "SELECT Id as Numer, Kategoria, Nazwa_Produktu, Cena, ilosc as Ilość, Data, (ilosc*cena) as Suma  FROM Platnosci JOIN loginId ON Platnosci.loginId=loginId.loginId WHERE Cena like '" + textBoxCena.Text + "'and nazwisko = '" + txtNazwisko.Text + "';";

                    MySqlDataAdapter sqlData = new MySqlDataAdapter(select, mysqlcon);
                    DataTable dtbl = new DataTable();
                    sqlData.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;

                    //załadowanie danych do wykresu
                    Wykres.DataSource = dtbl;
                    Wykres.Series["Wydatki"].XValueMember = "Data";
                    Wykres.Series["Wydatki"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    Wykres.Series["Wydatki"].YValueMembers = "Cena";
                    Wykres.Series["Wydatki"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

                }
                else if (radioButtonRozny.Checked == true)
                {
                    string select = "SELECT Id as Numer, Kategoria, Nazwa_Produktu, Cena, ilosc as Ilość, Data, (ilosc*cena) as Suma  FROM Platnosci JOIN loginId ON Platnosci.loginId=loginId.loginId WHERE Cena not like '" + textBoxCena.Text + "'and nazwisko = '" + txtNazwisko.Text + "';";

                    MySqlDataAdapter sqlData = new MySqlDataAdapter(select, mysqlcon);
                    DataTable dtbl = new DataTable();
                    sqlData.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;

                    //załadowanie danych do wykresu
                    Wykres.DataSource = dtbl;
                    Wykres.Series["Wydatki"].XValueMember = "Data";
                    Wykres.Series["Wydatki"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    Wykres.Series["Wydatki"].YValueMembers = "Cena";
                    Wykres.Series["Wydatki"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

                }

            }//koniec - szukanie po cena


            //szukanie po ilosc
            if (checkBoxIlosc.Checked == true)
            {


                if (radioButtonWiekszy.Checked == true)
                {
                    string select = "SELECT Id as Numer, Kategoria, Nazwa_Produktu, Cena, ilosc as Ilość, Data, (ilosc*cena) as Suma  FROM Platnosci JOIN loginId ON Platnosci.loginId=loginId.loginId WHERE ilosc > '" + textBoxIlosc.Text + "'and nazwisko = '" + txtNazwisko.Text + "';";

                    MySqlDataAdapter sqlData = new MySqlDataAdapter(select, mysqlcon);
                    DataTable dtbl = new DataTable();
                    sqlData.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;

                    //załadowanie danych do wykresu
                    Wykres.DataSource = dtbl;
                    Wykres.Series["Wydatki"].XValueMember = "Data";
                    Wykres.Series["Wydatki"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    Wykres.Series["Wydatki"].YValueMembers = "Cena";
                    Wykres.Series["Wydatki"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

                }
                else if (radioButtonWiekszyRowny.Checked == true)
                {
                    string select = "SELECT Id as Numer, Kategoria, Nazwa_Produktu, Cena, ilosc as Ilość, Data, (ilosc*cena) as Suma  FROM Platnosci JOIN loginId ON Platnosci.loginId=loginId.loginId WHERE ilosc >= '" + textBoxIlosc.Text + "'and nazwisko = '" + txtNazwisko.Text + "';";

                    MySqlDataAdapter sqlData = new MySqlDataAdapter(select, mysqlcon);
                    DataTable dtbl = new DataTable();
                    sqlData.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;

                    //załadowanie danych do wykresu
                    Wykres.DataSource = dtbl;
                    Wykres.Series["Wydatki"].XValueMember = "Data";
                    Wykres.Series["Wydatki"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    Wykres.Series["Wydatki"].YValueMembers = "Cena";
                    Wykres.Series["Wydatki"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

                }
                else if (radioButtonMniejszy.Checked == true)
                {
                    string select = "SELECT Id as Numer, Kategoria, Nazwa_Produktu, Cena, ilosc as Ilość, Data, (ilosc*cena) as Suma  FROM Platnosci JOIN loginId ON Platnosci.loginId=loginId.loginId WHERE ilosc < '" + textBoxIlosc.Text + "'and nazwisko = '" + txtNazwisko.Text + "';";

                    MySqlDataAdapter sqlData = new MySqlDataAdapter(select, mysqlcon);
                    DataTable dtbl = new DataTable();
                    sqlData.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;

                    //załadowanie danych do wykresu
                    Wykres.DataSource = dtbl;
                    Wykres.Series["Wydatki"].XValueMember = "Data";
                    Wykres.Series["Wydatki"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    Wykres.Series["Wydatki"].YValueMembers = "Cena";
                    Wykres.Series["Wydatki"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

                }
                else if (radioButtonMniejszyRowny.Checked == true)
                {
                    string select = "SELECT Id as Numer, Kategoria, Nazwa_Produktu, Cena, ilosc as Ilość, Data, (ilosc*cena) as Suma  FROM Platnosci JOIN loginId ON Platnosci.loginId=loginId.loginId WHERE ilosc <= '" + textBoxIlosc.Text + "'and nazwisko = '" + txtNazwisko.Text + "';";

                    MySqlDataAdapter sqlData = new MySqlDataAdapter(select, mysqlcon);
                    DataTable dtbl = new DataTable();
                    sqlData.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;

                    //załadowanie danych do wykresu
                    Wykres.DataSource = dtbl;
                    Wykres.Series["Wydatki"].XValueMember = "Data";
                    Wykres.Series["Wydatki"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    Wykres.Series["Wydatki"].YValueMembers = "Cena";
                    Wykres.Series["Wydatki"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

                }
                else if (radioButtonRowny.Checked == true)
                {
                    string select = "SELECT Id as Numer, Kategoria, Nazwa_Produktu, Cena, ilosc as Ilość, Data, (ilosc*cena) as Suma  FROM Platnosci JOIN loginId ON Platnosci.loginId=loginId.loginId WHERE ilosc like '" + textBoxIlosc.Text + "'and nazwisko = '" + txtNazwisko.Text + "';";

                    MySqlDataAdapter sqlData = new MySqlDataAdapter(select, mysqlcon);
                    DataTable dtbl = new DataTable();
                    sqlData.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;

                    //załadowanie danych do wykresu
                    Wykres.DataSource = dtbl;
                    Wykres.Series["Wydatki"].XValueMember = "Data";
                    Wykres.Series["Wydatki"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    Wykres.Series["Wydatki"].YValueMembers = "Cena";
                    Wykres.Series["Wydatki"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

                }
                else if (radioButtonRozny.Checked == true)
                {
                    string select = "SELECT Id as Numer, Kategoria, Nazwa_Produktu, Cena, ilosc as Ilość, Data, (ilosc*cena) as Suma  FROM Platnosci JOIN loginId ON Platnosci.loginId=loginId.loginId WHERE ilosc not like'" + textBoxIlosc.Text + "'and nazwisko = '" + txtNazwisko.Text + "';";

                    MySqlDataAdapter sqlData = new MySqlDataAdapter(select, mysqlcon);
                    DataTable dtbl = new DataTable();
                    sqlData.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;

                    //załadowanie danych do wykresu
                    Wykres.DataSource = dtbl;
                    Wykres.Series["Wydatki"].XValueMember = "Data";
                    Wykres.Series["Wydatki"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    Wykres.Series["Wydatki"].YValueMembers = "Cena";
                    Wykres.Series["Wydatki"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

                }


            }//koniec - szukanie po ilosc

            //szukanie po  data
            if (checkBoxData.Checked == true)
                {
                   
                string select = "SELECT Id as Numer, Kategoria, Nazwa_Produktu, Cena, ilosc as Ilość, Data, (ilosc*cena) as Suma  FROM Platnosci JOIN loginId ON Platnosci.loginId=loginId.loginId WHERE Data = '" + textBoxData.Text + "'and nazwisko = '" + txtNazwisko.Text + "';";
                MySqlDataAdapter sqlData = new MySqlDataAdapter(select, mysqlcon);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                dataGridView1.DataSource = dtbl;


                //załadowanie danych do wykresu
                Wykres.DataSource = dtbl;
                Wykres.Series["Wydatki"].XValueMember = "Data";
                Wykres.Series["Wydatki"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                Wykres.Series["Wydatki"].YValueMembers = "Cena";
                Wykres.Series["Wydatki"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;


            }

            //szukanie po suma
            if (checkBoxSuma.Checked == true)
                {

                if (radioButtonWiekszy.Checked == true)
                {
                    string select = "SELECT Id as Numer, Kategoria, Nazwa_Produktu, Cena, ilosc as Ilość, Data, (ilosc*cena) as Suma  FROM Platnosci JOIN loginId ON Platnosci.loginId=loginId.loginId WHERE (ilosc*cena) > '" + textBoxSuma.Text + "'and nazwisko = '" + txtNazwisko.Text + "';";

                    MySqlDataAdapter sqlData = new MySqlDataAdapter(select, mysqlcon);
                    DataTable dtbl = new DataTable();
                    sqlData.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;

                    //załadowanie danych do wykresu
                    Wykres.DataSource = dtbl;
                    Wykres.Series["Wydatki"].XValueMember = "Data";
                    Wykres.Series["Wydatki"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    Wykres.Series["Wydatki"].YValueMembers = "Cena";
                    Wykres.Series["Wydatki"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

                }
                else if (radioButtonWiekszyRowny.Checked == true)
                {
                    string select = "SELECT Id as Numer, Kategoria, Nazwa_Produktu, Cena, ilosc as Ilość, Data, (ilosc*cena) as Suma  FROM Platnosci JOIN loginId ON Platnosci.loginId=loginId.loginId WHERE (ilosc*cena) >= '" + textBoxSuma.Text + "'and nazwisko = '" + txtNazwisko.Text + "';";

                    MySqlDataAdapter sqlData = new MySqlDataAdapter(select, mysqlcon);
                    DataTable dtbl = new DataTable();
                    sqlData.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;

                    //załadowanie danych do wykresu
                    Wykres.DataSource = dtbl;
                    Wykres.Series["Wydatki"].XValueMember = "Data";
                    Wykres.Series["Wydatki"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    Wykres.Series["Wydatki"].YValueMembers = "Cena";
                    Wykres.Series["Wydatki"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

                }
                else if (radioButtonMniejszy.Checked == true)
                {
                    string select = "SELECT Id as Numer, Kategoria, Nazwa_Produktu, Cena, ilosc as Ilość, Data, (ilosc*cena) as Suma  FROM Platnosci JOIN loginId ON Platnosci.loginId=loginId.loginId WHERE (ilosc*cena) < '" + textBoxSuma.Text + "'and nazwisko = '" + txtNazwisko.Text + "';";

                    MySqlDataAdapter sqlData = new MySqlDataAdapter(select, mysqlcon);
                    DataTable dtbl = new DataTable();
                    sqlData.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;

                    //załadowanie danych do wykresu
                    Wykres.DataSource = dtbl;
                    Wykres.Series["Wydatki"].XValueMember = "Data";
                    Wykres.Series["Wydatki"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    Wykres.Series["Wydatki"].YValueMembers = "Cena";
                    Wykres.Series["Wydatki"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

                }
                else if (radioButtonMniejszyRowny.Checked == true)
                {
                    string select = "SELECT Id as Numer, Kategoria, Nazwa_Produktu, Cena, ilosc as Ilość, Data, (ilosc*cena) as Suma  FROM Platnosci JOIN loginId ON Platnosci.loginId=loginId.loginId WHERE (ilosc*cena) <= '" + textBoxSuma.Text + "'and nazwisko = '" + txtNazwisko.Text + "';";

                    MySqlDataAdapter sqlData = new MySqlDataAdapter(select, mysqlcon);
                    DataTable dtbl = new DataTable();
                    sqlData.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;

                    //załadowanie danych do wykresu
                    Wykres.DataSource = dtbl;
                    Wykres.Series["Wydatki"].XValueMember = "Data";
                    Wykres.Series["Wydatki"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    Wykres.Series["Wydatki"].YValueMembers = "Cena";
                    Wykres.Series["Wydatki"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

                }
                else if (radioButtonRowny.Checked == true)
                {
                    string select = "SELECT Id as Numer, Kategoria, Nazwa_Produktu, Cena, ilosc as Ilość, Data, (ilosc*cena) as Suma  FROM Platnosci JOIN loginId ON Platnosci.loginId=loginId.loginId WHERE (ilosc*cena) like '" + textBoxSuma.Text + "'and nazwisko = '" + txtNazwisko.Text + "';";

                    MySqlDataAdapter sqlData = new MySqlDataAdapter(select, mysqlcon);
                    DataTable dtbl = new DataTable();
                    sqlData.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;

                    //załadowanie danych do wykresu
                    Wykres.DataSource = dtbl;
                    Wykres.Series["Wydatki"].XValueMember = "Data";
                    Wykres.Series["Wydatki"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    Wykres.Series["Wydatki"].YValueMembers = "Cena";
                    Wykres.Series["Wydatki"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

                }
                else if (radioButtonRozny.Checked == true)
                {
                    string select = "SELECT Id as Numer, Kategoria, Nazwa_Produktu, Cena, ilosc as Ilość, Data, (ilosc*cena) as Suma  FROM Platnosci JOIN loginId ON Platnosci.loginId=loginId.loginId WHERE (ilosc*cena) not like '" + textBoxSuma.Text + "'and nazwisko = '" + txtNazwisko.Text + "';";

                    MySqlDataAdapter sqlData = new MySqlDataAdapter(select, mysqlcon);
                    DataTable dtbl = new DataTable();
                    sqlData.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;

                    //załadowanie danych do wykresu
                    Wykres.DataSource = dtbl;
                    Wykres.Series["Wydatki"].XValueMember = "Data";
                    Wykres.Series["Wydatki"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    Wykres.Series["Wydatki"].YValueMembers = "Cena";
                    Wykres.Series["Wydatki"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

                }
            }
            mysqlcon.Close();

            }

       
        private void checkBoxNumer_CheckedChanged(object sender, EventArgs e)
        {
            //ustawienia checkboxu Numer 
            if (checkBoxNumer.Checked == true)
            {
                textBoxNumer.Enabled = true;
            }
            else
            {
                textBoxNumer.Enabled = false;
            }
            

        }

        private void checkBoxKategoria_CheckedChanged(object sender, EventArgs e)
        {
            //ustawienia checkboxu Kategoria
            if (checkBoxKategoria.Checked == true)
            {
                textBoxKategoria.Enabled = true;
                flowLayoutPanelPorownania.Visible = false;

            }
            else
            {
                textBoxKategoria.Enabled = false;
            }
        }

        private void checkBoxNazwa_CheckedChanged(object sender, EventArgs e)
        {
            //ustawienia checkboxu Nazwa
            if (checkBoxNazwa.Checked == true)
            {
                textBoxNazwa.Enabled = true;
                flowLayoutPanelPorownania.Visible = false;
            }
            else
            {
                textBoxNazwa.Enabled = false;
            }
        }

        private void checkBoxCena_CheckedChanged(object sender, EventArgs e)
        {
            //ustawienia checkboxu Cena
            if (checkBoxCena.Checked == true)
            {
                textBoxCena.Enabled = true;
                flowLayoutPanelPorownania.Visible = true;


            }
            else
            {
                textBoxCena.Enabled = false;
            }
        }

        private void checkBoxIlosc_CheckedChanged(object sender, EventArgs e)
        {
            //ustawienia checkboxu Ilosc
            if (checkBoxIlosc.Checked == true)
            {
                textBoxIlosc.Enabled = true;
                flowLayoutPanelPorownania.Visible = true;

            }
            else
            {
                textBoxIlosc.Enabled = false;
            }

        }

        private void checkBoxData_CheckedChanged(object sender, EventArgs e)
        {
            //ustawienia checkboxu Data
            if (checkBoxData.Checked == true)
            {
                textBoxData.Enabled = true;
                flowLayoutPanelPorownania.Visible = false;

            }
            else
            {
                textBoxData.Enabled = false;
            }
        }

        private void checkBoxSuma_CheckedChanged(object sender, EventArgs e)
        {
            //ustawienia checkboxu Suma
            if (checkBoxSuma.Checked == true)
            {
                textBoxSuma.Enabled = true;
                flowLayoutPanelPorownania.Visible = true;

            }
            else
            {
                textBoxSuma.Enabled = false;
            }
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            
        }

       
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            //czas utworzenia pdf'a
            DateTime thisDay = DateTime.Now;
            string dzisiaj = Convert.ToString(thisDay);

            //ustawienie czcionki
            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED);

            //wstepne tworzenie ustawiend do pdf
            PdfPTable pdftable = new PdfPTable(dataGridView1.Columns.Count);

            pdftable.DefaultCell.Padding = 5;
            pdftable.SpacingBefore = 10;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_MIDDLE;

            //ustawienia dla czcionki nagłówka
            iTextSharp.text.Font header = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.BOLD);

            //ustawienia dla pozostałych elementów
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);


            //nagłówek
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, header));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter="PDF file|*.pdf",ValidateNames = true})
            {
                

                //dodawanie poszczegolnych kolumn/wierszy
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {                 
                    foreach (DataGridViewCell cell in row.Cells)
                    {                   
                        pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                    }
                }

                //wydruk do pdf
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new iTextSharp.text.Paragraph(dzisiaj));
                        doc.Add(pdftable);
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }
    }


}



//DRUKOWANIE ZWYKLE
//private void buttonPrint_Click(object sender, EventArgs e)
//{
//    //komunikat o drukowaniu
//    MessageBox.Show("Drukowanie rozpoczęte!", "Skarbonka", MessageBoxButtons.OK, MessageBoxIcon.Information);

//    // tworzenie obrazu do wydruku
//    int height = dataGridView1.Height;
//    dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
//    bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
//    dataGridView1.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
//    dataGridView1.Height = height;
//    printPreviewDialog1.ShowDialog();


//}


////drukowanie
//private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
//{
//    e.Graphics.DrawImage(bmp, 0, 0);

//}
