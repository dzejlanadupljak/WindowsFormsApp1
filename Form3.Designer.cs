namespace WindowsFormsApp1
{
    partial class Form3
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
            System.Windows.Forms.Label klijenat_idLabel;
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label prezimeLabel;
            System.Windows.Forms.Label datum_rodjenjaLabel;
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label broj_telefonaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.bnkDataSet1 = new WindowsFormsApp1.bnkDataSet1();
            this.klijenatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klijenatTableAdapter = new WindowsFormsApp1.bnkDataSet1TableAdapters.klijenatTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.bnkDataSet1TableAdapters.TableAdapterManager();
            this.klijenatBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.klijenatBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.klijenat_idTextBox = new System.Windows.Forms.TextBox();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.datum_rodjenjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.broj_telefonaTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.klijenatDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            klijenat_idLabel = new System.Windows.Forms.Label();
            imeLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            datum_rodjenjaLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            broj_telefonaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bnkDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijenatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijenatBindingNavigator)).BeginInit();
            this.klijenatBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klijenatDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // klijenat_idLabel
            // 
            klijenat_idLabel.AutoSize = true;
            klijenat_idLabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            klijenat_idLabel.Location = new System.Drawing.Point(54, 38);
            klijenat_idLabel.Name = "klijenat_idLabel";
            klijenat_idLabel.Size = new System.Drawing.Size(85, 23);
            klijenat_idLabel.TabIndex = 1;
            klijenat_idLabel.Text = "klijenat id:";
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imeLabel.Location = new System.Drawing.Point(99, 61);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(40, 23);
            imeLabel.TabIndex = 3;
            imeLabel.Text = "ime:";
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prezimeLabel.Location = new System.Drawing.Point(69, 90);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(70, 23);
            prezimeLabel.TabIndex = 5;
            prezimeLabel.Text = "prezime:";
            // 
            // datum_rodjenjaLabel
            // 
            datum_rodjenjaLabel.AutoSize = true;
            datum_rodjenjaLabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            datum_rodjenjaLabel.Location = new System.Drawing.Point(18, 123);
            datum_rodjenjaLabel.Name = "datum_rodjenjaLabel";
            datum_rodjenjaLabel.Size = new System.Drawing.Size(121, 23);
            datum_rodjenjaLabel.TabIndex = 7;
            datum_rodjenjaLabel.Text = "datum rodjenja:";
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adresaLabel.Location = new System.Drawing.Point(78, 155);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(61, 23);
            adresaLabel.TabIndex = 9;
            adresaLabel.Text = "adresa:";
            // 
            // broj_telefonaLabel
            // 
            broj_telefonaLabel.AutoSize = true;
            broj_telefonaLabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            broj_telefonaLabel.Location = new System.Drawing.Point(38, 189);
            broj_telefonaLabel.Name = "broj_telefonaLabel";
            broj_telefonaLabel.Size = new System.Drawing.Size(101, 23);
            broj_telefonaLabel.TabIndex = 11;
            broj_telefonaLabel.Text = "broj telefona:";
            // 
            // bnkDataSet1
            // 
            this.bnkDataSet1.DataSetName = "bnkDataSet1";
            this.bnkDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klijenatBindingSource
            // 
            this.klijenatBindingSource.DataMember = "klijenat";
            this.klijenatBindingSource.DataSource = this.bnkDataSet1;
            // 
            // klijenatTableAdapter
            // 
            this.klijenatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.karticeTableAdapter = null;
            this.tableAdapterManager.klijenatTableAdapter = this.klijenatTableAdapter;
            this.tableAdapterManager.kreditiTableAdapter = null;
            this.tableAdapterManager.racuniTableAdapter = null;
            this.tableAdapterManager.transakcija_povjestiTableAdapter = null;
            this.tableAdapterManager.transakcijeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.bnkDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.zaposleniciTableAdapter = null;
            // 
            // klijenatBindingNavigator
            // 
            this.klijenatBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.klijenatBindingNavigator.BindingSource = this.klijenatBindingSource;
            this.klijenatBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.klijenatBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.klijenatBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.klijenatBindingNavigatorSaveItem});
            this.klijenatBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.klijenatBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.klijenatBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.klijenatBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.klijenatBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.klijenatBindingNavigator.Name = "klijenatBindingNavigator";
            this.klijenatBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.klijenatBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.klijenatBindingNavigator.TabIndex = 0;
            this.klijenatBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // klijenatBindingNavigatorSaveItem
            // 
            this.klijenatBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.klijenatBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("klijenatBindingNavigatorSaveItem.Image")));
            this.klijenatBindingNavigatorSaveItem.Name = "klijenatBindingNavigatorSaveItem";
            this.klijenatBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.klijenatBindingNavigatorSaveItem.Text = "Save Data";
            this.klijenatBindingNavigatorSaveItem.Click += new System.EventHandler(this.klijenatBindingNavigatorSaveItem_Click);
            // 
            // klijenat_idTextBox
            // 
            this.klijenat_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klijenatBindingSource, "klijenat_id", true));
            this.klijenat_idTextBox.Location = new System.Drawing.Point(158, 42);
            this.klijenat_idTextBox.Name = "klijenat_idTextBox";
            this.klijenat_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.klijenat_idTextBox.TabIndex = 2;
            // 
            // imeTextBox
            // 
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klijenatBindingSource, "ime", true));
            this.imeTextBox.Location = new System.Drawing.Point(158, 68);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(200, 20);
            this.imeTextBox.TabIndex = 4;
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klijenatBindingSource, "prezime", true));
            this.prezimeTextBox.Location = new System.Drawing.Point(158, 97);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(200, 20);
            this.prezimeTextBox.TabIndex = 6;
            // 
            // datum_rodjenjaDateTimePicker
            // 
            this.datum_rodjenjaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.klijenatBindingSource, "datum_rodjenja", true));
            this.datum_rodjenjaDateTimePicker.Location = new System.Drawing.Point(158, 126);
            this.datum_rodjenjaDateTimePicker.Name = "datum_rodjenjaDateTimePicker";
            this.datum_rodjenjaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datum_rodjenjaDateTimePicker.TabIndex = 8;
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klijenatBindingSource, "adresa", true));
            this.adresaTextBox.Location = new System.Drawing.Point(158, 159);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(200, 20);
            this.adresaTextBox.TabIndex = 10;
            // 
            // broj_telefonaTextBox
            // 
            this.broj_telefonaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klijenatBindingSource, "broj_telefona", true));
            this.broj_telefonaTextBox.Location = new System.Drawing.Point(158, 193);
            this.broj_telefonaTextBox.Name = "broj_telefonaTextBox";
            this.broj_telefonaTextBox.Size = new System.Drawing.Size(200, 20);
            this.broj_telefonaTextBox.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.klijenatDataGridView);
            this.panel1.Location = new System.Drawing.Point(12, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 355);
            this.panel1.TabIndex = 13;
            // 
            // klijenatDataGridView
            // 
            this.klijenatDataGridView.AutoGenerateColumns = false;
            this.klijenatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.klijenatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.klijenatDataGridView.DataSource = this.klijenatBindingSource;
            this.klijenatDataGridView.Location = new System.Drawing.Point(8, 13);
            this.klijenatDataGridView.Name = "klijenatDataGridView";
            this.klijenatDataGridView.Size = new System.Drawing.Size(632, 215);
            this.klijenatDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "klijenat_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "klijenat_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ime";
            this.dataGridViewTextBoxColumn2.HeaderText = "ime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prezime";
            this.dataGridViewTextBoxColumn3.HeaderText = "prezime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "datum_rodjenja";
            this.dataGridViewTextBoxColumn4.HeaderText = "datum_rodjenja";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "adresa";
            this.dataGridViewTextBoxColumn5.HeaderText = "adresa";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "broj_telefona";
            this.dataGridViewTextBoxColumn6.HeaderText = "broj_telefona";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnADD);
            this.panel2.Controls.Add(this.btnIzadji);
            this.panel2.Controls.Add(this.btnIzbrisi);
            this.panel2.Controls.Add(this.btnSacuvaj);
            this.panel2.Controls.Add(this.btnDodaj);
            this.panel2.Location = new System.Drawing.Point(660, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 462);
            this.panel2.TabIndex = 14;
            // 
            // btnIzadji
            // 
            this.btnIzadji.BackColor = System.Drawing.Color.Khaki;
            this.btnIzadji.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzadji.Location = new System.Drawing.Point(291, 289);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(85, 33);
            this.btnIzadji.TabIndex = 7;
            this.btnIzadji.Text = "IZALAZ";
            this.btnIzadji.UseVisualStyleBackColor = false;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSacuvaj.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(291, 201);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(85, 31);
            this.btnSacuvaj.TabIndex = 6;
            this.btnSacuvaj.Text = "SACUVAJ";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackColor = System.Drawing.Color.Khaki;
            this.btnIzbrisi.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisi.Location = new System.Drawing.Point(291, 107);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(85, 35);
            this.btnIzbrisi.TabIndex = 5;
            this.btnIzbrisi.Text = "IZBRISI";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDodaj.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(291, 28);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(85, 32);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "DODAJ";
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "ZATVORI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(22, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 31);
            this.button2.TabIndex = 10;
            this.button2.Text = "SACUVAJ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Khaki;
            this.button3.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(22, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "IZBRISI";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnADD.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.Location = new System.Drawing.Point(22, 84);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(85, 32);
            this.btnADD.TabIndex = 8;
            this.btnADD.Text = "DODAJ";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(klijenat_idLabel);
            this.Controls.Add(this.klijenat_idTextBox);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(prezimeLabel);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(datum_rodjenjaLabel);
            this.Controls.Add(this.datum_rodjenjaDateTimePicker);
            this.Controls.Add(adresaLabel);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(broj_telefonaLabel);
            this.Controls.Add(this.broj_telefonaTextBox);
            this.Controls.Add(this.klijenatBindingNavigator);
            this.Name = "Form3";
            this.Text = "Klijenti";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnkDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijenatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijenatBindingNavigator)).EndInit();
            this.klijenatBindingNavigator.ResumeLayout(false);
            this.klijenatBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.klijenatDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bnkDataSet1 bnkDataSet1;
        private System.Windows.Forms.BindingSource klijenatBindingSource;
        private bnkDataSet1TableAdapters.klijenatTableAdapter klijenatTableAdapter;
        private bnkDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator klijenatBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton klijenatBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox klijenat_idTextBox;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.DateTimePicker datum_rodjenjaDateTimePicker;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox broj_telefonaTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView klijenatDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnDodaj;
    }
}