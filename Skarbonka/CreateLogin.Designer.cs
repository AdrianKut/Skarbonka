namespace Skarbonka
{
    partial class CreateLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.loginIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelImie = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNotFilled = new System.Windows.Forms.Label();
            this.txtWrongLogin = new System.Windows.Forms.Label();
            this.txtWrongPassword = new System.Windows.Forms.Label();
            this.txtPasswordv2 = new System.Windows.Forms.TextBox();
            this.labelPasswordv2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonPowrot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loginIdBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginIdBindingSource
            // 
            this.loginIdBindingSource.DataMember = "loginId";
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelImie.Location = new System.Drawing.Point(13, 34);
            this.labelImie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(43, 20);
            this.labelImie.TabIndex = 1;
            this.labelImie.Text = "Imię:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNotFilled);
            this.panel1.Controls.Add(this.txtWrongLogin);
            this.panel1.Controls.Add(this.txtWrongPassword);
            this.panel1.Controls.Add(this.txtPasswordv2);
            this.panel1.Controls.Add(this.labelPasswordv2);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Controls.Add(this.txtNazwisko);
            this.panel1.Controls.Add(this.txtImie);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.labelLogin);
            this.panel1.Controls.Add(this.labelNazwisko);
            this.panel1.Controls.Add(this.labelImie);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 191);
            this.panel1.TabIndex = 2;
            // 
            // txtNotFilled
            // 
            this.txtNotFilled.AutoSize = true;
            this.txtNotFilled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNotFilled.ForeColor = System.Drawing.Color.Red;
            this.txtNotFilled.Location = new System.Drawing.Point(150, 8);
            this.txtNotFilled.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNotFilled.Name = "txtNotFilled";
            this.txtNotFilled.Size = new System.Drawing.Size(173, 15);
            this.txtNotFilled.TabIndex = 14;
            this.txtNotFilled.Text = "Nieprawidłowe dane, lub brak!";
            this.txtNotFilled.Visible = false;
            // 
            // txtWrongLogin
            // 
            this.txtWrongLogin.AutoSize = true;
            this.txtWrongLogin.ForeColor = System.Drawing.Color.Red;
            this.txtWrongLogin.Location = new System.Drawing.Point(337, 97);
            this.txtWrongLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtWrongLogin.Name = "txtWrongLogin";
            this.txtWrongLogin.Size = new System.Drawing.Size(107, 13);
            this.txtWrongLogin.TabIndex = 12;
            this.txtWrongLogin.Text = "Taki login już istnieje!";
            this.txtWrongLogin.Visible = false;
            // 
            // txtWrongPassword
            // 
            this.txtWrongPassword.AutoSize = true;
            this.txtWrongPassword.ForeColor = System.Drawing.Color.Red;
            this.txtWrongPassword.Location = new System.Drawing.Point(337, 127);
            this.txtWrongPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtWrongPassword.Name = "txtWrongPassword";
            this.txtWrongPassword.Size = new System.Drawing.Size(146, 13);
            this.txtWrongPassword.TabIndex = 11;
            this.txtWrongPassword.Text = "Hasła muszą być takie same!";
            this.txtWrongPassword.Visible = false;
            // 
            // txtPasswordv2
            // 
            this.txtPasswordv2.Location = new System.Drawing.Point(150, 154);
            this.txtPasswordv2.Margin = new System.Windows.Forms.Padding(2);
            this.txtPasswordv2.Name = "txtPasswordv2";
            this.txtPasswordv2.Size = new System.Drawing.Size(183, 20);
            this.txtPasswordv2.TabIndex = 10;
            // 
            // labelPasswordv2
            // 
            this.labelPasswordv2.AutoSize = true;
            this.labelPasswordv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPasswordv2.Location = new System.Drawing.Point(13, 154);
            this.labelPasswordv2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPasswordv2.Name = "labelPasswordv2";
            this.labelPasswordv2.Size = new System.Drawing.Size(113, 20);
            this.labelPasswordv2.TabIndex = 9;
            this.labelPasswordv2.Text = "Powtórz hasło:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(150, 124);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(183, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(150, 94);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(183, 20);
            this.txtLogin.TabIndex = 7;
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(150, 64);
            this.txtNazwisko.Margin = new System.Windows.Forms.Padding(2);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(183, 20);
            this.txtNazwisko.TabIndex = 6;
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(150, 34);
            this.txtImie.Margin = new System.Windows.Forms.Padding(2);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(183, 20);
            this.txtImie.TabIndex = 5;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPassword.Location = new System.Drawing.Point(13, 124);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(55, 20);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Hasło:";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogin.Location = new System.Drawing.Point(13, 94);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(52, 20);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Login:";
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazwisko.Location = new System.Drawing.Point(13, 64);
            this.labelNazwisko.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(80, 20);
            this.labelNazwisko.TabIndex = 2;
            this.labelNazwisko.Text = "Nazwisko:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(247, 197);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Stwórz";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "MyAccount";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            this.saveFileDialog1.InitialDirectory = ".";
            this.saveFileDialog1.Title = "Zapisz do pliku";
            // 
            // buttonPowrot
            // 
            this.buttonPowrot.Location = new System.Drawing.Point(152, 197);
            this.buttonPowrot.Name = "buttonPowrot";
            this.buttonPowrot.Size = new System.Drawing.Size(75, 23);
            this.buttonPowrot.TabIndex = 10;
            this.buttonPowrot.Text = "Powrót";
            this.buttonPowrot.UseVisualStyleBackColor = true;
            this.buttonPowrot.Click += new System.EventHandler(this.buttonPowrot_Click);
            // 
            // CreateLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 232);
            this.Controls.Add(this.buttonPowrot);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "CreateLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nowe Konto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateLogin_FormClosing);
            this.Load += new System.EventHandler(this.CreateLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginIdBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource loginIdBindingSource;

        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox txtPasswordv2;
        private System.Windows.Forms.Label labelPasswordv2;
        private System.Windows.Forms.Label txtWrongPassword;
        private System.Windows.Forms.Label txtWrongLogin;
        private System.Windows.Forms.Label txtNotFilled;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonPowrot;
    }
}