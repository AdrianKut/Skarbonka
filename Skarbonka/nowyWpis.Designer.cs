namespace Skarbonka
{
    partial class nowyWpis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nowyWpis));
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxValue = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.txtNotFilled = new System.Windows.Forms.Label();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.buttonZmien = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericNumerID = new System.Windows.Forms.NumericUpDown();
            this.labelDodatek = new System.Windows.Forms.Label();
            this.txtLoginId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumerID)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.Items.AddRange(new object[] {
            "Usluga",
            "Zdrowie",
            "Zywnosc",
            "Przedmiot"});
            this.listBoxCategory.Location = new System.Drawing.Point(12, 161);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.ScrollAlwaysVisible = true;
            this.listBoxCategory.Size = new System.Drawing.Size(87, 56);
            this.listBoxCategory.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.Location = new System.Drawing.Point(98, 267);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAdd.Size = new System.Drawing.Size(73, 31);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ilość:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cena:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxProductName.Location = new System.Drawing.Point(93, 3);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(145, 20);
            this.textBoxProductName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa Produktu: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownQuantity.Location = new System.Drawing.Point(93, 71);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDownQuantity.Size = new System.Drawing.Size(145, 20);
            this.numericUpDownQuantity.TabIndex = 3;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.45705F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.54295F));
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownQuantity, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxProductName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxValue, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.63158F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.52632F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.78947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(241, 108);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // textBoxValue
            // 
            this.textBoxValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxValue.Location = new System.Drawing.Point(93, 38);
            this.textBoxValue.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxValue.Size = new System.Drawing.Size(145, 20);
            this.textBoxValue.TabIndex = 4;
            this.textBoxValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(105, 161);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(148, 20);
            this.dateTimePickerDate.TabIndex = 5;
            // 
            // txtNotFilled
            // 
            this.txtNotFilled.AutoSize = true;
            this.txtNotFilled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNotFilled.ForeColor = System.Drawing.Color.Red;
            this.txtNotFilled.Location = new System.Drawing.Point(88, 240);
            this.txtNotFilled.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNotFilled.Name = "txtNotFilled";
            this.txtNotFilled.Size = new System.Drawing.Size(117, 15);
            this.txtNotFilled.TabIndex = 13;
            this.txtNotFilled.Text = "Uzupełnij formularz!";
            this.txtNotFilled.Visible = false;
            // 
            // buttonUsun
            // 
            this.buttonUsun.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUsun.Location = new System.Drawing.Point(19, 267);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonUsun.Size = new System.Drawing.Size(73, 31);
            this.buttonUsun.TabIndex = 15;
            this.buttonUsun.Text = "Usuń";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // buttonZmien
            // 
            this.buttonZmien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonZmien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZmien.Location = new System.Drawing.Point(177, 267);
            this.buttonZmien.Name = "buttonZmien";
            this.buttonZmien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonZmien.Size = new System.Drawing.Size(73, 31);
            this.buttonZmien.TabIndex = 16;
            this.buttonZmien.Text = "Zmień";
            this.buttonZmien.UseVisualStyleBackColor = true;
            this.buttonZmien.Click += new System.EventHandler(this.buttonZmien_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(10, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "*Numer: ";
            // 
            // numericNumerID
            // 
            this.numericNumerID.Location = new System.Drawing.Point(105, 21);
            this.numericNumerID.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericNumerID.Name = "numericNumerID";
            this.numericNumerID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericNumerID.Size = new System.Drawing.Size(66, 20);
            this.numericNumerID.TabIndex = 18;
            this.numericNumerID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelDodatek
            // 
            this.labelDodatek.AutoSize = true;
            this.labelDodatek.Location = new System.Drawing.Point(22, 306);
            this.labelDodatek.Name = "labelDodatek";
            this.labelDodatek.Size = new System.Drawing.Size(211, 26);
            this.labelDodatek.TabIndex = 19;
            this.labelDodatek.Text = "* Numer potrzebny wyłącznie w przypadku \r\n   akutalizacji, bądź usuwaniu danych!\r" +
    "\n";
            // 
            // txtLoginId
            // 
            this.txtLoginId.AutoSize = true;
            this.txtLoginId.Location = new System.Drawing.Point(177, 25);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(73, 13);
            this.txtLoginId.TabIndex = 20;
            this.txtLoginId.Text = "pomoc loginId";
            this.txtLoginId.Visible = false;
            // 
            // nowyWpis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 344);
            this.Controls.Add(this.txtLoginId);
            this.Controls.Add(this.labelDodatek);
            this.Controls.Add(this.numericNumerID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonZmien);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.txtNotFilled);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "nowyWpis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edycja wpisów";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumerID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label txtNotFilled;
        private System.Windows.Forms.NumericUpDown textBoxValue;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.Button buttonZmien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericNumerID;
        private System.Windows.Forms.Label labelDodatek;
        private System.Windows.Forms.Label txtLoginId;
    }
}