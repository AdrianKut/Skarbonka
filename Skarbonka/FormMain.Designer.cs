namespace Skarbonka
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem1 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell1 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zawartośćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokumentacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUser = new System.Windows.Forms.Label();
            this.txtImieNazwisko = new System.Windows.Forms.Label();
            this.layout_Imie_Nazwisko = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDodajProdukt = new System.Windows.Forms.Button();
            this.Wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.buttonFinder = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxKategoria = new System.Windows.Forms.ListBox();
            this.textBoxNazwa = new System.Windows.Forms.TextBox();
            this.textBoxNumer = new System.Windows.Forms.NumericUpDown();
            this.textBoxData = new System.Windows.Forms.DateTimePicker();
            this.textBoxCena = new System.Windows.Forms.NumericUpDown();
            this.textBoxIlosc = new System.Windows.Forms.NumericUpDown();
            this.textBoxSuma = new System.Windows.Forms.NumericUpDown();
            this.radioButtonWiekszy = new System.Windows.Forms.RadioButton();
            this.radioButtonWiekszyRowny = new System.Windows.Forms.RadioButton();
            this.radioButtonRowny = new System.Windows.Forms.RadioButton();
            this.radioButtonMniejszyRowny = new System.Windows.Forms.RadioButton();
            this.radioButtonMniejszy = new System.Windows.Forms.RadioButton();
            this.radioButtonRozny = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanelPorownania = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxNumer = new System.Windows.Forms.RadioButton();
            this.checkBoxKategoria = new System.Windows.Forms.RadioButton();
            this.checkBoxNazwa = new System.Windows.Forms.RadioButton();
            this.checkBoxCena = new System.Windows.Forms.RadioButton();
            this.checkBoxIlosc = new System.Windows.Forms.RadioButton();
            this.checkBoxData = new System.Windows.Forms.RadioButton();
            this.checkBoxSuma = new System.Windows.Forms.RadioButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.txtNazwisko = new System.Windows.Forms.Label();
            this.txtLoginId = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.layout_Imie_Nazwisko.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Wykres)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxNumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxIlosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxSuma)).BeginInit();
            this.flowLayoutPanelPorownania.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zawartośćToolStripMenuItem,
            this.dokumentacjaToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "&Pomoc";
            // 
            // zawartośćToolStripMenuItem
            // 
            this.zawartośćToolStripMenuItem.Name = "zawartośćToolStripMenuItem";
            this.zawartośćToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.zawartośćToolStripMenuItem.Text = "&O programie";
            this.zawartośćToolStripMenuItem.Click += new System.EventHandler(this.zawartośćToolStripMenuItem_Click);
            // 
            // dokumentacjaToolStripMenuItem
            // 
            this.dokumentacjaToolStripMenuItem.Name = "dokumentacjaToolStripMenuItem";
            this.dokumentacjaToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.dokumentacjaToolStripMenuItem.Text = "&Dokumentacja";
            this.dokumentacjaToolStripMenuItem.Click += new System.EventHandler(this.dokumentacjaToolStripMenuItem_Click);
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUser.AutoSize = true;
            this.txtUser.Location = new System.Drawing.Point(2, 5);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(95, 13);
            this.txtUser.TabIndex = 4;
            this.txtUser.Text = "Zalogowano jako: ";
            this.txtUser.Visible = false;
            // 
            // txtImieNazwisko
            // 
            this.txtImieNazwisko.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtImieNazwisko.AutoSize = true;
            this.txtImieNazwisko.Location = new System.Drawing.Point(108, 5);
            this.txtImieNazwisko.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtImieNazwisko.Name = "txtImieNazwisko";
            this.txtImieNazwisko.Size = new System.Drawing.Size(78, 13);
            this.txtImieNazwisko.TabIndex = 5;
            this.txtImieNazwisko.Text = "Imię i nazwisko";
            this.txtImieNazwisko.Visible = false;
            // 
            // layout_Imie_Nazwisko
            // 
            this.layout_Imie_Nazwisko.ColumnCount = 2;
            this.layout_Imie_Nazwisko.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.88341F));
            this.layout_Imie_Nazwisko.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.11659F));
            this.layout_Imie_Nazwisko.Controls.Add(this.txtUser, 0, 0);
            this.layout_Imie_Nazwisko.Controls.Add(this.txtImieNazwisko, 1, 0);
            this.layout_Imie_Nazwisko.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.layout_Imie_Nazwisko.Location = new System.Drawing.Point(0, 632);
            this.layout_Imie_Nazwisko.Margin = new System.Windows.Forms.Padding(2);
            this.layout_Imie_Nazwisko.Name = "layout_Imie_Nazwisko";
            this.layout_Imie_Nazwisko.RowCount = 1;
            this.layout_Imie_Nazwisko.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Imie_Nazwisko.Size = new System.Drawing.Size(892, 24);
            this.layout_Imie_Nazwisko.TabIndex = 6;
            // 
            // buttonDodajProdukt
            // 
            this.buttonDodajProdukt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajProdukt.Location = new System.Drawing.Point(33, 34);
            this.buttonDodajProdukt.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDodajProdukt.Name = "buttonDodajProdukt";
            this.buttonDodajProdukt.Size = new System.Drawing.Size(64, 27);
            this.buttonDodajProdukt.TabIndex = 1;
            this.buttonDodajProdukt.Text = "Edycja";
            this.buttonDodajProdukt.UseVisualStyleBackColor = true;
            this.buttonDodajProdukt.Click += new System.EventHandler(this.buttonDodajProdukt_Click);
            // 
            // Wykres
            // 
            this.Wykres.BorderSkin.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea1.Name = "ChartArea1";
            this.Wykres.ChartAreas.Add(chartArea1);
            legendCell1.Name = "Cell1";
            legendItem1.Cells.Add(legendCell1);
            legend1.CustomItems.Add(legendItem1);
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            this.Wykres.Legends.Add(legend1);
            this.Wykres.Location = new System.Drawing.Point(113, 353);
            this.Wykres.Name = "Wykres";
            this.Wykres.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Wydatki";
            series1.YValuesPerPoint = 6;
            this.Wykres.Series.Add(series1);
            this.Wykres.Size = new System.Drawing.Size(760, 263);
            this.Wykres.TabIndex = 8;
            this.Wykres.Text = "Wydatki";
            title1.Name = "Wydatki";
            this.Wykres.Titles.Add(title1);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogout.Location = new System.Drawing.Point(33, 99);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(64, 28);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Wyloguj";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRefresh.Location = new System.Drawing.Point(33, 66);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(64, 28);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.Text = "Odśwież";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 1000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // buttonFinder
            // 
            this.buttonFinder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonFinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFinder.Image = ((System.Drawing.Image)(resources.GetObject("buttonFinder.Image")));
            this.buttonFinder.Location = new System.Drawing.Point(113, 64);
            this.buttonFinder.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFinder.Name = "buttonFinder";
            this.buttonFinder.Size = new System.Drawing.Size(32, 31);
            this.buttonFinder.TabIndex = 12;
            this.buttonFinder.UseVisualStyleBackColor = false;
            this.buttonFinder.Click += new System.EventHandler(this.buttonFinder_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxKategoria, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNazwa, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNumer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxData, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCena, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxIlosc, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSuma, 6, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(151, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(725, 61);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // textBoxKategoria
            // 
            this.textBoxKategoria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxKategoria.FormattingEnabled = true;
            this.textBoxKategoria.Items.AddRange(new object[] {
            "Usługa",
            "Zdrowie",
            "Żywność",
            "Przedmiot"});
            this.textBoxKategoria.Location = new System.Drawing.Point(106, 15);
            this.textBoxKategoria.Name = "textBoxKategoria";
            this.textBoxKategoria.ScrollAlwaysVisible = true;
            this.textBoxKategoria.Size = new System.Drawing.Size(97, 43);
            this.textBoxKategoria.TabIndex = 9;
            // 
            // textBoxNazwa
            // 
            this.textBoxNazwa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxNazwa.Location = new System.Drawing.Point(209, 38);
            this.textBoxNazwa.Name = "textBoxNazwa";
            this.textBoxNazwa.Size = new System.Drawing.Size(97, 20);
            this.textBoxNazwa.TabIndex = 3;
            // 
            // textBoxNumer
            // 
            this.textBoxNumer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxNumer.Location = new System.Drawing.Point(3, 38);
            this.textBoxNumer.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.textBoxNumer.Name = "textBoxNumer";
            this.textBoxNumer.Size = new System.Drawing.Size(97, 20);
            this.textBoxNumer.TabIndex = 8;
            // 
            // textBoxData
            // 
            this.textBoxData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxData.Location = new System.Drawing.Point(518, 38);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(97, 20);
            this.textBoxData.TabIndex = 10;
            // 
            // textBoxCena
            // 
            this.textBoxCena.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxCena.Location = new System.Drawing.Point(312, 38);
            this.textBoxCena.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(97, 20);
            this.textBoxCena.TabIndex = 11;
            // 
            // textBoxIlosc
            // 
            this.textBoxIlosc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxIlosc.Location = new System.Drawing.Point(415, 38);
            this.textBoxIlosc.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.textBoxIlosc.Name = "textBoxIlosc";
            this.textBoxIlosc.Size = new System.Drawing.Size(97, 20);
            this.textBoxIlosc.TabIndex = 12;
            // 
            // textBoxSuma
            // 
            this.textBoxSuma.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxSuma.Location = new System.Drawing.Point(621, 38);
            this.textBoxSuma.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.textBoxSuma.Name = "textBoxSuma";
            this.textBoxSuma.Size = new System.Drawing.Size(101, 20);
            this.textBoxSuma.TabIndex = 13;
            // 
            // radioButtonWiekszy
            // 
            this.radioButtonWiekszy.AutoSize = true;
            this.radioButtonWiekszy.Location = new System.Drawing.Point(3, 3);
            this.radioButtonWiekszy.Name = "radioButtonWiekszy";
            this.radioButtonWiekszy.Size = new System.Drawing.Size(31, 17);
            this.radioButtonWiekszy.TabIndex = 14;
            this.radioButtonWiekszy.TabStop = true;
            this.radioButtonWiekszy.Text = ">";
            this.radioButtonWiekszy.UseVisualStyleBackColor = true;
            // 
            // radioButtonWiekszyRowny
            // 
            this.radioButtonWiekszyRowny.AutoSize = true;
            this.radioButtonWiekszyRowny.Location = new System.Drawing.Point(40, 3);
            this.radioButtonWiekszyRowny.Name = "radioButtonWiekszyRowny";
            this.radioButtonWiekszyRowny.Size = new System.Drawing.Size(37, 17);
            this.radioButtonWiekszyRowny.TabIndex = 15;
            this.radioButtonWiekszyRowny.TabStop = true;
            this.radioButtonWiekszyRowny.Text = ">=";
            this.radioButtonWiekszyRowny.UseVisualStyleBackColor = true;
            // 
            // radioButtonRowny
            // 
            this.radioButtonRowny.AutoSize = true;
            this.radioButtonRowny.Location = new System.Drawing.Point(3, 49);
            this.radioButtonRowny.Name = "radioButtonRowny";
            this.radioButtonRowny.Size = new System.Drawing.Size(37, 17);
            this.radioButtonRowny.TabIndex = 17;
            this.radioButtonRowny.TabStop = true;
            this.radioButtonRowny.Text = "==";
            this.radioButtonRowny.UseVisualStyleBackColor = true;
            // 
            // radioButtonMniejszyRowny
            // 
            this.radioButtonMniejszyRowny.AutoSize = true;
            this.radioButtonMniejszyRowny.Location = new System.Drawing.Point(40, 26);
            this.radioButtonMniejszyRowny.Name = "radioButtonMniejszyRowny";
            this.radioButtonMniejszyRowny.Size = new System.Drawing.Size(37, 17);
            this.radioButtonMniejszyRowny.TabIndex = 19;
            this.radioButtonMniejszyRowny.TabStop = true;
            this.radioButtonMniejszyRowny.Text = "<=";
            this.radioButtonMniejszyRowny.UseVisualStyleBackColor = true;
            // 
            // radioButtonMniejszy
            // 
            this.radioButtonMniejszy.AutoSize = true;
            this.radioButtonMniejszy.Location = new System.Drawing.Point(3, 26);
            this.radioButtonMniejszy.Name = "radioButtonMniejszy";
            this.radioButtonMniejszy.Size = new System.Drawing.Size(31, 17);
            this.radioButtonMniejszy.TabIndex = 18;
            this.radioButtonMniejszy.TabStop = true;
            this.radioButtonMniejszy.Text = "<";
            this.radioButtonMniejszy.UseVisualStyleBackColor = true;
            // 
            // radioButtonRozny
            // 
            this.radioButtonRozny.AutoSize = true;
            this.radioButtonRozny.Location = new System.Drawing.Point(46, 49);
            this.radioButtonRozny.Name = "radioButtonRozny";
            this.radioButtonRozny.Size = new System.Drawing.Size(34, 17);
            this.radioButtonRozny.TabIndex = 20;
            this.radioButtonRozny.TabStop = true;
            this.radioButtonRozny.Text = "!=";
            this.radioButtonRozny.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelPorownania
            // 
            this.flowLayoutPanelPorownania.Controls.Add(this.radioButtonWiekszy);
            this.flowLayoutPanelPorownania.Controls.Add(this.radioButtonWiekszyRowny);
            this.flowLayoutPanelPorownania.Controls.Add(this.radioButtonMniejszy);
            this.flowLayoutPanelPorownania.Controls.Add(this.radioButtonMniejszyRowny);
            this.flowLayoutPanelPorownania.Controls.Add(this.radioButtonRowny);
            this.flowLayoutPanelPorownania.Controls.Add(this.radioButtonRozny);
            this.flowLayoutPanelPorownania.Location = new System.Drawing.Point(20, 297);
            this.flowLayoutPanelPorownania.Name = "flowLayoutPanelPorownania";
            this.flowLayoutPanelPorownania.Size = new System.Drawing.Size(85, 81);
            this.flowLayoutPanelPorownania.TabIndex = 21;
            this.flowLayoutPanelPorownania.Visible = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.checkBoxNumer);
            this.flowLayoutPanel3.Controls.Add(this.checkBoxKategoria);
            this.flowLayoutPanel3.Controls.Add(this.checkBoxNazwa);
            this.flowLayoutPanel3.Controls.Add(this.checkBoxCena);
            this.flowLayoutPanel3.Controls.Add(this.checkBoxIlosc);
            this.flowLayoutPanel3.Controls.Add(this.checkBoxData);
            this.flowLayoutPanel3.Controls.Add(this.checkBoxSuma);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(20, 133);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(89, 161);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // checkBoxNumer
            // 
            this.checkBoxNumer.AutoSize = true;
            this.checkBoxNumer.Location = new System.Drawing.Point(3, 3);
            this.checkBoxNumer.Name = "checkBoxNumer";
            this.checkBoxNumer.Size = new System.Drawing.Size(56, 17);
            this.checkBoxNumer.TabIndex = 0;
            this.checkBoxNumer.TabStop = true;
            this.checkBoxNumer.Text = "Numer";
            this.checkBoxNumer.UseVisualStyleBackColor = true;
            this.checkBoxNumer.CheckedChanged += new System.EventHandler(this.checkBoxNumer_CheckedChanged);
            // 
            // checkBoxKategoria
            // 
            this.checkBoxKategoria.AutoSize = true;
            this.checkBoxKategoria.Location = new System.Drawing.Point(3, 26);
            this.checkBoxKategoria.Name = "checkBoxKategoria";
            this.checkBoxKategoria.Size = new System.Drawing.Size(70, 17);
            this.checkBoxKategoria.TabIndex = 1;
            this.checkBoxKategoria.TabStop = true;
            this.checkBoxKategoria.Text = "Kategoria";
            this.checkBoxKategoria.UseVisualStyleBackColor = true;
            this.checkBoxKategoria.CheckedChanged += new System.EventHandler(this.checkBoxKategoria_CheckedChanged);
            // 
            // checkBoxNazwa
            // 
            this.checkBoxNazwa.AutoSize = true;
            this.checkBoxNazwa.Location = new System.Drawing.Point(3, 49);
            this.checkBoxNazwa.Name = "checkBoxNazwa";
            this.checkBoxNazwa.Size = new System.Drawing.Size(58, 17);
            this.checkBoxNazwa.TabIndex = 2;
            this.checkBoxNazwa.TabStop = true;
            this.checkBoxNazwa.Text = "Nazwa";
            this.checkBoxNazwa.UseVisualStyleBackColor = true;
            this.checkBoxNazwa.CheckedChanged += new System.EventHandler(this.checkBoxNazwa_CheckedChanged);
            // 
            // checkBoxCena
            // 
            this.checkBoxCena.AutoSize = true;
            this.checkBoxCena.Location = new System.Drawing.Point(3, 72);
            this.checkBoxCena.Name = "checkBoxCena";
            this.checkBoxCena.Size = new System.Drawing.Size(50, 17);
            this.checkBoxCena.TabIndex = 3;
            this.checkBoxCena.TabStop = true;
            this.checkBoxCena.Text = "Cena";
            this.checkBoxCena.UseVisualStyleBackColor = true;
            this.checkBoxCena.CheckedChanged += new System.EventHandler(this.checkBoxCena_CheckedChanged);
            // 
            // checkBoxIlosc
            // 
            this.checkBoxIlosc.AutoSize = true;
            this.checkBoxIlosc.Location = new System.Drawing.Point(3, 95);
            this.checkBoxIlosc.Name = "checkBoxIlosc";
            this.checkBoxIlosc.Size = new System.Drawing.Size(47, 17);
            this.checkBoxIlosc.TabIndex = 4;
            this.checkBoxIlosc.TabStop = true;
            this.checkBoxIlosc.Text = "Ilość";
            this.checkBoxIlosc.UseVisualStyleBackColor = true;
            this.checkBoxIlosc.CheckedChanged += new System.EventHandler(this.checkBoxIlosc_CheckedChanged);
            // 
            // checkBoxData
            // 
            this.checkBoxData.AutoSize = true;
            this.checkBoxData.Location = new System.Drawing.Point(3, 118);
            this.checkBoxData.Name = "checkBoxData";
            this.checkBoxData.Size = new System.Drawing.Size(48, 17);
            this.checkBoxData.TabIndex = 5;
            this.checkBoxData.TabStop = true;
            this.checkBoxData.Text = "Data";
            this.checkBoxData.UseVisualStyleBackColor = true;
            this.checkBoxData.CheckedChanged += new System.EventHandler(this.checkBoxData_CheckedChanged);
            // 
            // checkBoxSuma
            // 
            this.checkBoxSuma.AutoSize = true;
            this.checkBoxSuma.Location = new System.Drawing.Point(3, 141);
            this.checkBoxSuma.Name = "checkBoxSuma";
            this.checkBoxSuma.Size = new System.Drawing.Size(52, 17);
            this.checkBoxSuma.TabIndex = 6;
            this.checkBoxSuma.TabStop = true;
            this.checkBoxSuma.Text = "Suma";
            this.checkBoxSuma.UseVisualStyleBackColor = true;
            this.checkBoxSuma.CheckedChanged += new System.EventHandler(this.checkBoxSuma_CheckedChanged);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(113, 100);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(760, 240);
            this.dataGridView1.TabIndex = 9;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrint.Image")));
            this.buttonPrint.Location = new System.Drawing.Point(24, 560);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(57, 56);
            this.buttonPrint.TabIndex = 23;
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.AutoSize = true;
            this.txtNazwisko.Location = new System.Drawing.Point(13, 531);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(87, 13);
            this.txtNazwisko.TabIndex = 6;
            this.txtNazwisko.Text = "Pomoc nazwisko";
            this.txtNazwisko.Visible = false;
            // 
            // txtLoginId
            // 
            this.txtLoginId.AutoSize = true;
            this.txtLoginId.Location = new System.Drawing.Point(21, 544);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(74, 13);
            this.txtLoginId.TabIndex = 24;
            this.txtLoginId.Text = "Pomoc loginId";
            this.txtLoginId.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 656);
            this.Controls.Add(this.txtLoginId);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.flowLayoutPanelPorownania);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonFinder);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Wykres);
            this.Controls.Add(this.buttonDodajProdukt);
            this.Controls.Add(this.layout_Imie_Nazwisko);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skarbonka";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.layout_Imie_Nazwisko.ResumeLayout(false);
            this.layout_Imie_Nazwisko.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Wykres)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxNumer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxIlosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxSuma)).EndInit();
            this.flowLayoutPanelPorownania.ResumeLayout(false);
            this.flowLayoutPanelPorownania.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zawartośćToolStripMenuItem;
        private System.Windows.Forms.Label txtUser;
        private System.Windows.Forms.Label txtImieNazwisko;
        private System.Windows.Forms.TableLayoutPanel layout_Imie_Nazwisko;
        private System.Windows.Forms.ToolStripMenuItem dokumentacjaToolStripMenuItem;
        private System.Windows.Forms.Button buttonDodajProdukt;
        private System.Windows.Forms.DataVisualization.Charting.Chart Wykres;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Button buttonFinder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxNazwa;
        private System.Windows.Forms.NumericUpDown textBoxNumer;
        private System.Windows.Forms.ListBox textBoxKategoria;
        private System.Windows.Forms.DateTimePicker textBoxData;
        private System.Windows.Forms.RadioButton radioButtonWiekszy;
        private System.Windows.Forms.RadioButton radioButtonWiekszyRowny;
        private System.Windows.Forms.RadioButton radioButtonRowny;
        private System.Windows.Forms.RadioButton radioButtonMniejszyRowny;
        private System.Windows.Forms.RadioButton radioButtonMniejszy;
        private System.Windows.Forms.RadioButton radioButtonRozny;
        private System.Windows.Forms.NumericUpDown textBoxCena;
        private System.Windows.Forms.NumericUpDown textBoxIlosc;
        private System.Windows.Forms.NumericUpDown textBoxSuma;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPorownania;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.RadioButton checkBoxNumer;
        private System.Windows.Forms.RadioButton checkBoxKategoria;
        private System.Windows.Forms.RadioButton checkBoxNazwa;
        private System.Windows.Forms.RadioButton checkBoxCena;
        private System.Windows.Forms.RadioButton checkBoxIlosc;
        private System.Windows.Forms.RadioButton checkBoxData;
        private System.Windows.Forms.RadioButton checkBoxSuma;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Label txtNazwisko;
        private System.Windows.Forms.Label txtLoginId;
    }
}