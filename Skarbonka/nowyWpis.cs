using MySql.Data.MySqlClient;
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

namespace Skarbonka
{
    public partial class nowyWpis : Form
    {
        MySqlConnection mysqlcon = new MySqlConnection(@"Server =remotemysql.com; Database = 8NZnZS6QX7; Uid = 8NZnZS6QX7; Pwd = 5fOJTvlcO9; PORT = 3306;");
        FormMain formMain;
        public nowyWpis(FormMain getFromFormMain)
        {
            formMain = getFromFormMain;
        } 


        public nowyWpis(string loginId)
        {
            InitializeComponent();
            txtLoginId.Text = loginId;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            mysqlcon.Open();
            MySqlCommand cmdInsert = new MySqlCommand("INSERT INTO Platnosci (Nazwa_produktu,Cena,Ilosc,Data,Kategoria,loginId) VALUES (@nazwa,@cena,@ilosc,@data,@kategoria,@login)", mysqlcon);

            if (textBoxProductName.Text == "" || textBoxValue.Text == "" || listBoxCategory.Text == "" ) 
            {
                txtNotFilled.Visible = true; // wyświetlenie label o braku wporwadzonych danych

            }
            else
            {            
                txtNotFilled.Visible = false;
                cmdInsert.Parameters.AddWithValue("nazwa", textBoxProductName.Text);
                cmdInsert.Parameters.AddWithValue("cena", textBoxValue.Text);
                cmdInsert.Parameters.AddWithValue("ilosc", numericUpDownQuantity.Value);
                cmdInsert.Parameters.AddWithValue("data", dateTimePickerDate.Text);
                cmdInsert.Parameters.AddWithValue("kategoria", listBoxCategory.Text);
                cmdInsert.Parameters.AddWithValue("login", txtLoginId.Text);
                cmdInsert.ExecuteNonQuery();


                DialogResult dr = MessageBox.Show("Czy chcesz dodać kolejny wpis?", "Pomyślnie dodano!", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                switch (dr)     
                {
                    case DialogResult.Yes:
                        textBoxProductName.Text = "";
                        textBoxValue.Text = "";
                        listBoxCategory.Text = "";
                        numericUpDownQuantity.Value = 1;
                        textBoxValue.Value = 1;
                        break;

                    case DialogResult.No:
                        mysqlcon.Close();
                        this.Close();
                        break;

                }


               

            }




        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            mysqlcon.Open();
            if (MessageBox.Show($"Czy na pewno chcesz usunąć wpis o numerze:  \"{numericNumerID.Value}\" ? \n", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                MySqlCommand cm = new MySqlCommand("DELETE FROM Platnosci WHERE Id = @id and loginId = @login", mysqlcon);


                  cm.Parameters.AddWithValue("id", numericNumerID.Value);
                  cm.Parameters.AddWithValue("login", txtLoginId.Text);
                  cm.ExecuteNonQuery();
                  mysqlcon.Close();


                DialogResult dr = MessageBox.Show("Czy chcesz usunąć kolejny wpis?", "Pomyślnie usunięto!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (dr)
                {
                    case DialogResult.Yes:
                        numericNumerID.Value = 1;
                        break;

                    case DialogResult.No:
                        mysqlcon.Close();
                        this.Close();
                        break;

                }


            }
        }

        private void buttonZmien_Click(object sender, EventArgs e)
        {

            mysqlcon.Open();
            MySqlCommand cmdUpdate = new MySqlCommand("UPDATE Platnosci SET Kategoria = @kategoria, Nazwa_produktu = @nazwa, Cena = @cena, Ilosc = @ilosc, Data = @data  WHERE Id = @id and loginId = @login", mysqlcon);

            if (textBoxProductName.Text == "" || textBoxValue.Text == "" || listBoxCategory.Text== "") //dodaj ograniczenie do liczb w cenie produktu!
            {
                txtNotFilled.Visible = true; // wyświetlenie label o braku wporwadzonych danych

            }
            else
            {
                if (MessageBox.Show($"Czy na pewno chcesz zaktualizować wpis o numerze: \"{numericNumerID.Value}\" ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    cmdUpdate.Parameters.AddWithValue("kategoria", listBoxCategory.Text);
                    cmdUpdate.Parameters.AddWithValue("nazwa", textBoxProductName.Text);
                    cmdUpdate.Parameters.AddWithValue("cena", textBoxValue.Text);
                    cmdUpdate.Parameters.AddWithValue("ilosc", numericUpDownQuantity.Value);
                    cmdUpdate.Parameters.AddWithValue("data", dateTimePickerDate.Text);
                    cmdUpdate.Parameters.AddWithValue("id", numericNumerID.Value);
                    cmdUpdate.Parameters.AddWithValue("login", txtLoginId.Text);
                    cmdUpdate.ExecuteNonQuery();

                    DialogResult dr = MessageBox.Show("Czy chcesz zaktualizować kolejny wpis?", "Pomyślnie zaktualizowano dane!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    switch (dr)
                    {
                        case DialogResult.Yes:
                            textBoxProductName.Text = "";
                            textBoxValue.Text = "";
                            listBoxCategory.Text = "";
                            numericNumerID.Value = 1;
                            numericUpDownQuantity.Value = 1;
                            textBoxValue.Value = 1;
                            break;

                        case DialogResult.No:
                            mysqlcon.Close();
                            this.Close();
                            break;

                    }
                }



                
             

            }

        }
    }
}


