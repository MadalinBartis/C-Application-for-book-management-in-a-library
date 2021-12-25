namespace Biblioteca
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.adaugare = new System.Windows.Forms.Button();
            this.stergere = new System.Windows.Forms.Button();
            this.editare = new System.Windows.Forms.Button();
            this.text_titlu = new System.Windows.Forms.TextBox();
            this.text_cantitate = new System.Windows.Forms.TextBox();
            this.text_limba = new System.Windows.Forms.TextBox();
            this.text_an = new System.Windows.Forms.TextBox();
            this.text_editura = new System.Windows.Forms.TextBox();
            this.text_autor_nume = new System.Windows.Forms.TextBox();
            this.label_titlu = new System.Windows.Forms.Label();
            this.label_autor = new System.Windows.Forms.Label();
            this.label_editura = new System.Windows.Forms.Label();
            this.label_an = new System.Windows.Forms.Label();
            this.label_limba = new System.Windows.Forms.Label();
            this.label_cantitate = new System.Windows.Forms.Label();
            this.text_cautare = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cautare = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.autorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Biblioteca.Database1DataSet();
            this.aScrisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aScrisTableAdapter = new Biblioteca.Database1DataSetTableAdapters.AScrisTableAdapter();
            this.cartiTableAdapter = new Biblioteca.Database1DataSetTableAdapters.AutorTableAdapter();
            this.clientTableAdapter = new Biblioteca.Database1DataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new Biblioteca.Database1DataSetTableAdapters.TableAdapterManager();
            this.cartiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartiTableAdapter1 = new Biblioteca.Database1DataSetTableAdapters.CartiTableAdapter();
            this.afisare_totala = new System.Windows.Forms.Button();
            this.text_autor_prenume = new System.Windows.Forms.TextBox();
            this.label_prenume = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.label_id_aut = new System.Windows.Forms.Label();
            this.text_id_aut = new System.Windows.Forms.TextBox();
            this.label_categorie = new System.Windows.Forms.Label();
            this.text_categorie = new System.Windows.Forms.TextBox();
            this.ok_impr = new System.Windows.Forms.Button();
            this.text_id_clt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.text_nume_clt = new System.Windows.Forms.TextBox();
            this.text_prenume_clt = new System.Windows.Forms.TextBox();
            this.text_adresa_clt = new System.Windows.Forms.TextBox();
            this.label_dela = new System.Windows.Forms.Label();
            this.label_panala = new System.Windows.Forms.Label();
            this.label_id_clt = new System.Windows.Forms.Label();
            this.label_nume_clt = new System.Windows.Forms.Label();
            this.label_prenume_clt = new System.Windows.Forms.Label();
            this.label_adresa_clt = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.label_nume = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aScrisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adaugare
            // 
            this.adaugare.Image = ((System.Drawing.Image)(resources.GetObject("adaugare.Image")));
            this.adaugare.Location = new System.Drawing.Point(32, 421);
            this.adaugare.Name = "adaugare";
            this.adaugare.Size = new System.Drawing.Size(75, 55);
            this.adaugare.TabIndex = 1;
            this.adaugare.Text = "Adaugare";
            this.adaugare.UseVisualStyleBackColor = true;
            this.adaugare.Click += new System.EventHandler(this.adaugare_Click);
            // 
            // stergere
            // 
            this.stergere.Image = ((System.Drawing.Image)(resources.GetObject("stergere.Image")));
            this.stergere.Location = new System.Drawing.Point(32, 548);
            this.stergere.Name = "stergere";
            this.stergere.Size = new System.Drawing.Size(75, 49);
            this.stergere.TabIndex = 3;
            this.stergere.Text = "Stergere";
            this.stergere.UseVisualStyleBackColor = true;
            this.stergere.Click += new System.EventHandler(this.stergere_Click);
            // 
            // editare
            // 
            this.editare.Image = ((System.Drawing.Image)(resources.GetObject("editare.Image")));
            this.editare.Location = new System.Drawing.Point(32, 489);
            this.editare.Name = "editare";
            this.editare.Size = new System.Drawing.Size(75, 48);
            this.editare.TabIndex = 4;
            this.editare.Text = "Imprumut";
            this.editare.UseVisualStyleBackColor = true;
            this.editare.Click += new System.EventHandler(this.editare_Click);
            // 
            // text_titlu
            // 
            this.text_titlu.Location = new System.Drawing.Point(213, 434);
            this.text_titlu.Name = "text_titlu";
            this.text_titlu.Size = new System.Drawing.Size(100, 20);
            this.text_titlu.TabIndex = 5;
            this.text_titlu.Visible = false;
            this.text_titlu.TextChanged += new System.EventHandler(this.text_titlu_TextChanged);
            // 
            // text_cantitate
            // 
            this.text_cantitate.Location = new System.Drawing.Point(213, 563);
            this.text_cantitate.Name = "text_cantitate";
            this.text_cantitate.Size = new System.Drawing.Size(100, 20);
            this.text_cantitate.TabIndex = 6;
            this.text_cantitate.Visible = false;
            // 
            // text_limba
            // 
            this.text_limba.Location = new System.Drawing.Point(213, 540);
            this.text_limba.Name = "text_limba";
            this.text_limba.Size = new System.Drawing.Size(100, 20);
            this.text_limba.TabIndex = 7;
            this.text_limba.Visible = false;
            // 
            // text_an
            // 
            this.text_an.Location = new System.Drawing.Point(213, 514);
            this.text_an.Name = "text_an";
            this.text_an.Size = new System.Drawing.Size(100, 20);
            this.text_an.TabIndex = 8;
            this.text_an.Visible = false;
            // 
            // text_editura
            // 
            this.text_editura.Location = new System.Drawing.Point(213, 489);
            this.text_editura.Name = "text_editura";
            this.text_editura.Size = new System.Drawing.Size(100, 20);
            this.text_editura.TabIndex = 9;
            this.text_editura.Visible = false;
            // 
            // text_autor_nume
            // 
            this.text_autor_nume.Location = new System.Drawing.Point(213, 460);
            this.text_autor_nume.Name = "text_autor_nume";
            this.text_autor_nume.Size = new System.Drawing.Size(100, 20);
            this.text_autor_nume.TabIndex = 10;
            this.text_autor_nume.Visible = false;
            // 
            // label_titlu
            // 
            this.label_titlu.AutoSize = true;
            this.label_titlu.Location = new System.Drawing.Point(120, 437);
            this.label_titlu.Name = "label_titlu";
            this.label_titlu.Size = new System.Drawing.Size(27, 13);
            this.label_titlu.TabIndex = 11;
            this.label_titlu.Text = "Titlu";
            this.label_titlu.Visible = false;
            // 
            // label_autor
            // 
            this.label_autor.AutoSize = true;
            this.label_autor.Location = new System.Drawing.Point(120, 463);
            this.label_autor.Name = "label_autor";
            this.label_autor.Size = new System.Drawing.Size(35, 13);
            this.label_autor.TabIndex = 12;
            this.label_autor.Text = "Autor:";
            this.label_autor.Visible = false;
            // 
            // label_editura
            // 
            this.label_editura.AutoSize = true;
            this.label_editura.Location = new System.Drawing.Point(120, 489);
            this.label_editura.Name = "label_editura";
            this.label_editura.Size = new System.Drawing.Size(40, 13);
            this.label_editura.TabIndex = 13;
            this.label_editura.Text = "Editura";
            this.label_editura.Visible = false;
            // 
            // label_an
            // 
            this.label_an.AutoSize = true;
            this.label_an.Location = new System.Drawing.Point(120, 514);
            this.label_an.Name = "label_an";
            this.label_an.Size = new System.Drawing.Size(20, 13);
            this.label_an.TabIndex = 14;
            this.label_an.Text = "An";
            this.label_an.Visible = false;
            // 
            // label_limba
            // 
            this.label_limba.AutoSize = true;
            this.label_limba.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_limba.Location = new System.Drawing.Point(120, 540);
            this.label_limba.Name = "label_limba";
            this.label_limba.Size = new System.Drawing.Size(35, 13);
            this.label_limba.TabIndex = 15;
            this.label_limba.Text = "Limba";
            this.label_limba.Visible = false;
            // 
            // label_cantitate
            // 
            this.label_cantitate.AutoSize = true;
            this.label_cantitate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_cantitate.Location = new System.Drawing.Point(120, 566);
            this.label_cantitate.Name = "label_cantitate";
            this.label_cantitate.Size = new System.Drawing.Size(49, 13);
            this.label_cantitate.TabIndex = 16;
            this.label_cantitate.Text = "Cantitate";
            this.label_cantitate.Visible = false;
            // 
            // text_cautare
            // 
            this.text_cautare.Location = new System.Drawing.Point(613, 429);
            this.text_cautare.Name = "text_cautare";
            this.text_cautare.Size = new System.Drawing.Size(369, 20);
            this.text_cautare.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Titlu",
            "Autor"});
            this.comboBox1.Location = new System.Drawing.Point(1014, 428);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // cautare
            // 
            this.cautare.Image = ((System.Drawing.Image)(resources.GetObject("cautare.Image")));
            this.cautare.Location = new System.Drawing.Point(782, 470);
            this.cautare.Name = "cautare";
            this.cautare.Size = new System.Drawing.Size(75, 23);
            this.cautare.TabIndex = 19;
            this.cautare.Text = "Cautare";
            this.cautare.UseVisualStyleBackColor = true;
            this.cautare.Click += new System.EventHandler(this.cautare_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(226, 618);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 24;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Visible = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1270, 393);
            this.dataGridView1.TabIndex = 25;
            // 
            // autorBindingSource
            // 
            this.autorBindingSource.DataMember = "Autor";
            this.autorBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aScrisBindingSource
            // 
            this.aScrisBindingSource.DataMember = "AScris";
            this.aScrisBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // aScrisTableAdapter
            // 
            this.aScrisTableAdapter.ClearBeforeFill = true;
            // 
            // cartiTableAdapter
            // 
            this.cartiTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AScrisTableAdapter = null;
            this.tableAdapterManager.AutorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CartiTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.ImprumutTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Biblioteca.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cartiBindingSource
            // 
            this.cartiBindingSource.DataMember = "Carti";
            this.cartiBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // cartiTableAdapter1
            // 
            this.cartiTableAdapter1.ClearBeforeFill = true;
            // 
            // afisare_totala
            // 
            this.afisare_totala.Image = ((System.Drawing.Image)(resources.GetObject("afisare_totala.Image")));
            this.afisare_totala.Location = new System.Drawing.Point(976, 553);
            this.afisare_totala.Name = "afisare_totala";
            this.afisare_totala.Size = new System.Drawing.Size(159, 44);
            this.afisare_totala.TabIndex = 26;
            this.afisare_totala.Text = "Afisare Totala";
            this.afisare_totala.UseVisualStyleBackColor = true;
            this.afisare_totala.Click += new System.EventHandler(this.afisare_totala_Click);
            // 
            // text_autor_prenume
            // 
            this.text_autor_prenume.Location = new System.Drawing.Point(395, 460);
            this.text_autor_prenume.Name = "text_autor_prenume";
            this.text_autor_prenume.Size = new System.Drawing.Size(100, 20);
            this.text_autor_prenume.TabIndex = 27;
            this.text_autor_prenume.Visible = false;
            // 
            // label_prenume
            // 
            this.label_prenume.AutoSize = true;
            this.label_prenume.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_prenume.Location = new System.Drawing.Point(340, 463);
            this.label_prenume.Name = "label_prenume";
            this.label_prenume.Size = new System.Drawing.Size(49, 13);
            this.label_prenume.TabIndex = 29;
            this.label_prenume.Text = "Prenume";
            this.label_prenume.Visible = false;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_id.Location = new System.Drawing.Point(340, 434);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(49, 13);
            this.label_id.TabIndex = 30;
            this.label_id.Text = " ID Carte";
            this.label_id.Visible = false;
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(395, 434);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(100, 20);
            this.text_id.TabIndex = 31;
            this.text_id.Visible = false;
            this.text_id.TextChanged += new System.EventHandler(this.text_id_TextChanged);
            // 
            // label_id_aut
            // 
            this.label_id_aut.AutoSize = true;
            this.label_id_aut.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_id_aut.Location = new System.Drawing.Point(518, 463);
            this.label_id_aut.Name = "label_id_aut";
            this.label_id_aut.Size = new System.Drawing.Size(46, 13);
            this.label_id_aut.TabIndex = 32;
            this.label_id_aut.Text = "ID Autor";
            this.label_id_aut.Visible = false;
            // 
            // text_id_aut
            // 
            this.text_id_aut.Location = new System.Drawing.Point(570, 460);
            this.text_id_aut.Name = "text_id_aut";
            this.text_id_aut.Size = new System.Drawing.Size(35, 20);
            this.text_id_aut.TabIndex = 33;
            this.text_id_aut.Visible = false;
            // 
            // label_categorie
            // 
            this.label_categorie.AutoSize = true;
            this.label_categorie.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_categorie.Location = new System.Drawing.Point(120, 595);
            this.label_categorie.Name = "label_categorie";
            this.label_categorie.Size = new System.Drawing.Size(52, 13);
            this.label_categorie.TabIndex = 34;
            this.label_categorie.Text = "Categorie";
            this.label_categorie.Visible = false;
            // 
            // text_categorie
            // 
            this.text_categorie.Location = new System.Drawing.Point(213, 592);
            this.text_categorie.Name = "text_categorie";
            this.text_categorie.Size = new System.Drawing.Size(100, 20);
            this.text_categorie.TabIndex = 35;
            this.text_categorie.Visible = false;
            // 
            // ok_impr
            // 
            this.ok_impr.Image = ((System.Drawing.Image)(resources.GetObject("ok_impr.Image")));
            this.ok_impr.Location = new System.Drawing.Point(226, 618);
            this.ok_impr.Name = "ok_impr";
            this.ok_impr.Size = new System.Drawing.Size(75, 23);
            this.ok_impr.TabIndex = 36;
            this.ok_impr.Text = "OK";
            this.ok_impr.UseVisualStyleBackColor = true;
            this.ok_impr.Visible = false;
            this.ok_impr.Click += new System.EventHandler(this.ok_impr_Click);
            // 
            // text_id_clt
            // 
            this.text_id_clt.Location = new System.Drawing.Point(213, 434);
            this.text_id_clt.Name = "text_id_clt";
            this.text_id_clt.Size = new System.Drawing.Size(100, 20);
            this.text_id_clt.TabIndex = 37;
            this.text_id_clt.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(395, 541);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 38;
            this.dateTimePicker1.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(395, 567);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 39;
            this.dateTimePicker2.Visible = false;
            // 
            // text_nume_clt
            // 
            this.text_nume_clt.Location = new System.Drawing.Point(213, 460);
            this.text_nume_clt.Name = "text_nume_clt";
            this.text_nume_clt.Size = new System.Drawing.Size(100, 20);
            this.text_nume_clt.TabIndex = 40;
            this.text_nume_clt.Visible = false;
            // 
            // text_prenume_clt
            // 
            this.text_prenume_clt.Location = new System.Drawing.Point(213, 489);
            this.text_prenume_clt.Name = "text_prenume_clt";
            this.text_prenume_clt.Size = new System.Drawing.Size(100, 20);
            this.text_prenume_clt.TabIndex = 41;
            this.text_prenume_clt.Visible = false;
            // 
            // text_adresa_clt
            // 
            this.text_adresa_clt.Location = new System.Drawing.Point(213, 515);
            this.text_adresa_clt.Name = "text_adresa_clt";
            this.text_adresa_clt.Size = new System.Drawing.Size(282, 20);
            this.text_adresa_clt.TabIndex = 42;
            this.text_adresa_clt.Visible = false;
            // 
            // label_dela
            // 
            this.label_dela.AutoSize = true;
            this.label_dela.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_dela.Location = new System.Drawing.Point(357, 543);
            this.label_dela.Name = "label_dela";
            this.label_dela.Size = new System.Drawing.Size(32, 13);
            this.label_dela.TabIndex = 43;
            this.label_dela.Text = "De la";
            this.label_dela.Visible = false;
            // 
            // label_panala
            // 
            this.label_panala.AutoSize = true;
            this.label_panala.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_panala.Location = new System.Drawing.Point(346, 569);
            this.label_panala.Name = "label_panala";
            this.label_panala.Size = new System.Drawing.Size(43, 13);
            this.label_panala.TabIndex = 44;
            this.label_panala.Text = "Pana la";
            this.label_panala.Visible = false;
            // 
            // label_id_clt
            // 
            this.label_id_clt.AutoSize = true;
            this.label_id_clt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_id_clt.Location = new System.Drawing.Point(120, 437);
            this.label_id_clt.Name = "label_id_clt";
            this.label_id_clt.Size = new System.Drawing.Size(47, 13);
            this.label_id_clt.TabIndex = 45;
            this.label_id_clt.Text = "ID Client";
            this.label_id_clt.Visible = false;
            // 
            // label_nume_clt
            // 
            this.label_nume_clt.AutoSize = true;
            this.label_nume_clt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_nume_clt.Location = new System.Drawing.Point(120, 463);
            this.label_nume_clt.Name = "label_nume_clt";
            this.label_nume_clt.Size = new System.Drawing.Size(35, 13);
            this.label_nume_clt.TabIndex = 46;
            this.label_nume_clt.Text = "Nume";
            this.label_nume_clt.Visible = false;
            // 
            // label_prenume_clt
            // 
            this.label_prenume_clt.AutoSize = true;
            this.label_prenume_clt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_prenume_clt.Location = new System.Drawing.Point(118, 489);
            this.label_prenume_clt.Name = "label_prenume_clt";
            this.label_prenume_clt.Size = new System.Drawing.Size(49, 13);
            this.label_prenume_clt.TabIndex = 47;
            this.label_prenume_clt.Text = "Prenume";
            this.label_prenume_clt.Visible = false;
            // 
            // label_adresa_clt
            // 
            this.label_adresa_clt.AutoSize = true;
            this.label_adresa_clt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_adresa_clt.Location = new System.Drawing.Point(120, 515);
            this.label_adresa_clt.Name = "label_adresa_clt";
            this.label_adresa_clt.Size = new System.Drawing.Size(40, 13);
            this.label_adresa_clt.TabIndex = 48;
            this.label_adresa_clt.Text = "Adresa";
            this.label_adresa_clt.Visible = false;
            // 
            // logout
            // 
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(1154, 553);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(128, 44);
            this.logout.TabIndex = 49;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label_nume
            // 
            this.label_nume.AutoSize = true;
            this.label_nume.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_nume.Location = new System.Drawing.Point(172, 463);
            this.label_nume.Name = "label_nume";
            this.label_nume.Size = new System.Drawing.Size(35, 13);
            this.label_nume.TabIndex = 28;
            this.label_nume.Text = "Nume";
            this.label_nume.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1302, 646);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label_adresa_clt);
            this.Controls.Add(this.label_prenume_clt);
            this.Controls.Add(this.label_nume_clt);
            this.Controls.Add(this.label_id_clt);
            this.Controls.Add(this.label_panala);
            this.Controls.Add(this.label_dela);
            this.Controls.Add(this.text_adresa_clt);
            this.Controls.Add(this.text_prenume_clt);
            this.Controls.Add(this.text_nume_clt);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.text_id_clt);
            this.Controls.Add(this.ok_impr);
            this.Controls.Add(this.text_categorie);
            this.Controls.Add(this.label_categorie);
            this.Controls.Add(this.text_id_aut);
            this.Controls.Add(this.label_id_aut);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_prenume);
            this.Controls.Add(this.label_nume);
            this.Controls.Add(this.text_autor_prenume);
            this.Controls.Add(this.afisare_totala);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.cautare);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.text_cautare);
            this.Controls.Add(this.label_cantitate);
            this.Controls.Add(this.label_limba);
            this.Controls.Add(this.label_an);
            this.Controls.Add(this.label_editura);
            this.Controls.Add(this.label_autor);
            this.Controls.Add(this.label_titlu);
            this.Controls.Add(this.text_autor_nume);
            this.Controls.Add(this.text_editura);
            this.Controls.Add(this.text_an);
            this.Controls.Add(this.text_limba);
            this.Controls.Add(this.text_cantitate);
            this.Controls.Add(this.text_titlu);
            this.Controls.Add(this.editare);
            this.Controls.Add(this.stergere);
            this.Controls.Add(this.adaugare);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "List";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aScrisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button adaugare;
        private System.Windows.Forms.Button stergere;
        private System.Windows.Forms.Button editare;
        private System.Windows.Forms.TextBox text_titlu;
        private System.Windows.Forms.TextBox text_cantitate;
        private System.Windows.Forms.TextBox text_limba;
        private System.Windows.Forms.TextBox text_an;
        private System.Windows.Forms.TextBox text_editura;
        private System.Windows.Forms.TextBox text_autor_nume;
        private System.Windows.Forms.Label label_titlu;
        private System.Windows.Forms.Label label_autor;
        private System.Windows.Forms.Label label_editura;
        private System.Windows.Forms.Label label_an;
        private System.Windows.Forms.Label label_limba;
        private System.Windows.Forms.Label label_cantitate;
        private System.Windows.Forms.TextBox text_cautare;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button cautare;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource aScrisBindingSource;
        private Database1DataSetTableAdapters.AScrisTableAdapter aScrisTableAdapter;
        private System.Windows.Forms.BindingSource autorBindingSource;
        private Database1DataSetTableAdapters.AutorTableAdapter cartiTableAdapter;
        private Database1DataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource cartiBindingSource;
        private Database1DataSetTableAdapters.CartiTableAdapter cartiTableAdapter1;
        private System.Windows.Forms.Button afisare_totala;
        private System.Windows.Forms.TextBox text_autor_prenume;
        private System.Windows.Forms.Label label_prenume;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Label label_id_aut;
        private System.Windows.Forms.TextBox text_id_aut;
        private System.Windows.Forms.Label label_categorie;
        private System.Windows.Forms.TextBox text_categorie;
        private System.Windows.Forms.Button ok_impr;
        private System.Windows.Forms.TextBox text_id_clt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox text_nume_clt;
        private System.Windows.Forms.TextBox text_prenume_clt;
        private System.Windows.Forms.TextBox text_adresa_clt;
        private System.Windows.Forms.Label label_dela;
        private System.Windows.Forms.Label label_panala;
        private System.Windows.Forms.Label label_id_clt;
        private System.Windows.Forms.Label label_nume_clt;
        private System.Windows.Forms.Label label_prenume_clt;
        private System.Windows.Forms.Label label_adresa_clt;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label_nume;
    }
}