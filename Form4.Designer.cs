namespace WindowsFormsApp1
{
    partial class Form4
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
            System.Windows.Forms.Label krediti_idLabel;
            System.Windows.Forms.Label klijenat_idLabel;
            System.Windows.Forms.Label kolicina_kreditaLabel;
            System.Windows.Forms.Label kamatna_stopaLabel;
            System.Windows.Forms.Label kamatni_usloviLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.bnkDataSet1 = new WindowsFormsApp1.bnkDataSet1();
            this.kreditiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kreditiTableAdapter = new WindowsFormsApp1.bnkDataSet1TableAdapters.kreditiTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.bnkDataSet1TableAdapters.TableAdapterManager();
            this.kreditiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.kreditiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.krediti_idTextBox = new System.Windows.Forms.TextBox();
            this.klijenat_idTextBox = new System.Windows.Forms.TextBox();
            this.kolicina_kreditaTextBox = new System.Windows.Forms.TextBox();
            this.kamatna_stopaTextBox = new System.Windows.Forms.TextBox();
            this.kamatni_usloviTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kreditiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            krediti_idLabel = new System.Windows.Forms.Label();
            klijenat_idLabel = new System.Windows.Forms.Label();
            kolicina_kreditaLabel = new System.Windows.Forms.Label();
            kamatna_stopaLabel = new System.Windows.Forms.Label();
            kamatni_usloviLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bnkDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kreditiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kreditiBindingNavigator)).BeginInit();
            this.kreditiBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kreditiDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // krediti_idLabel
            // 
            krediti_idLabel.AutoSize = true;
            krediti_idLabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            krediti_idLabel.Location = new System.Drawing.Point(50, 33);
            krediti_idLabel.Name = "krediti_idLabel";
            krediti_idLabel.Size = new System.Drawing.Size(79, 23);
            krediti_idLabel.TabIndex = 1;
            krediti_idLabel.Text = "krediti id:";
            // 
            // klijenat_idLabel
            // 
            klijenat_idLabel.AutoSize = true;
            klijenat_idLabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            klijenat_idLabel.Location = new System.Drawing.Point(44, 66);
            klijenat_idLabel.Name = "klijenat_idLabel";
            klijenat_idLabel.Size = new System.Drawing.Size(85, 23);
            klijenat_idLabel.TabIndex = 3;
            klijenat_idLabel.Text = "klijenat id:";
            klijenat_idLabel.Click += new System.EventHandler(this.klijenat_idLabel_Click);
            // 
            // kolicina_kreditaLabel
            // 
            kolicina_kreditaLabel.AutoSize = true;
            kolicina_kreditaLabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kolicina_kreditaLabel.Location = new System.Drawing.Point(6, 99);
            kolicina_kreditaLabel.Name = "kolicina_kreditaLabel";
            kolicina_kreditaLabel.Size = new System.Drawing.Size(123, 23);
            kolicina_kreditaLabel.TabIndex = 5;
            kolicina_kreditaLabel.Text = "kolicina kredita:";
            // 
            // kamatna_stopaLabel
            // 
            kamatna_stopaLabel.AutoSize = true;
            kamatna_stopaLabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kamatna_stopaLabel.Location = new System.Drawing.Point(14, 136);
            kamatna_stopaLabel.Name = "kamatna_stopaLabel";
            kamatna_stopaLabel.Size = new System.Drawing.Size(115, 23);
            kamatna_stopaLabel.TabIndex = 7;
            kamatna_stopaLabel.Text = "kamatna stopa:";
            // 
            // kamatni_usloviLabel
            // 
            kamatni_usloviLabel.AutoSize = true;
            kamatni_usloviLabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kamatni_usloviLabel.Location = new System.Drawing.Point(12, 176);
            kamatni_usloviLabel.Name = "kamatni_usloviLabel";
            kamatni_usloviLabel.Size = new System.Drawing.Size(117, 23);
            kamatni_usloviLabel.TabIndex = 9;
            kamatni_usloviLabel.Text = "kamatni uslovi:";
            // 
            // bnkDataSet1
            // 
            this.bnkDataSet1.DataSetName = "bnkDataSet1";
            this.bnkDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kreditiBindingSource
            // 
            this.kreditiBindingSource.DataMember = "krediti";
            this.kreditiBindingSource.DataSource = this.bnkDataSet1;
            // 
            // kreditiTableAdapter
            // 
            this.kreditiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.karticeTableAdapter = null;
            this.tableAdapterManager.klijenatTableAdapter = null;
            this.tableAdapterManager.kreditiTableAdapter = this.kreditiTableAdapter;
            this.tableAdapterManager.racuniTableAdapter = null;
            this.tableAdapterManager.transakcija_povjestiTableAdapter = null;
            this.tableAdapterManager.transakcijeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.bnkDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.zaposleniciTableAdapter = null;
            // 
            // kreditiBindingNavigator
            // 
            this.kreditiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kreditiBindingNavigator.BindingSource = this.kreditiBindingSource;
            this.kreditiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kreditiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kreditiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.kreditiBindingNavigatorSaveItem});
            this.kreditiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kreditiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kreditiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kreditiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kreditiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kreditiBindingNavigator.Name = "kreditiBindingNavigator";
            this.kreditiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kreditiBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.kreditiBindingNavigator.TabIndex = 0;
            this.kreditiBindingNavigator.Text = "bindingNavigator1";
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
            // kreditiBindingNavigatorSaveItem
            // 
            this.kreditiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kreditiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kreditiBindingNavigatorSaveItem.Image")));
            this.kreditiBindingNavigatorSaveItem.Name = "kreditiBindingNavigatorSaveItem";
            this.kreditiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.kreditiBindingNavigatorSaveItem.Text = "Save Data";
            this.kreditiBindingNavigatorSaveItem.Click += new System.EventHandler(this.kreditiBindingNavigatorSaveItem_Click);
            // 
            // krediti_idTextBox
            // 
            this.krediti_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kreditiBindingSource, "krediti_id", true));
            this.krediti_idTextBox.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krediti_idTextBox.Location = new System.Drawing.Point(144, 26);
            this.krediti_idTextBox.Name = "krediti_idTextBox";
            this.krediti_idTextBox.Size = new System.Drawing.Size(100, 28);
            this.krediti_idTextBox.TabIndex = 2;
            this.krediti_idTextBox.TextChanged += new System.EventHandler(this.krediti_idTextBox_TextChanged);
            // 
            // klijenat_idTextBox
            // 
            this.klijenat_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kreditiBindingSource, "klijenat_id", true));
            this.klijenat_idTextBox.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klijenat_idTextBox.Location = new System.Drawing.Point(144, 60);
            this.klijenat_idTextBox.Name = "klijenat_idTextBox";
            this.klijenat_idTextBox.Size = new System.Drawing.Size(100, 28);
            this.klijenat_idTextBox.TabIndex = 4;
            this.klijenat_idTextBox.TextChanged += new System.EventHandler(this.klijenat_idTextBox_TextChanged);
            // 
            // kolicina_kreditaTextBox
            // 
            this.kolicina_kreditaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kreditiBindingSource, "kolicina_kredita", true));
            this.kolicina_kreditaTextBox.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kolicina_kreditaTextBox.Location = new System.Drawing.Point(144, 94);
            this.kolicina_kreditaTextBox.Name = "kolicina_kreditaTextBox";
            this.kolicina_kreditaTextBox.Size = new System.Drawing.Size(100, 28);
            this.kolicina_kreditaTextBox.TabIndex = 6;
            this.kolicina_kreditaTextBox.TextChanged += new System.EventHandler(this.kolicina_kreditaTextBox_TextChanged);
            // 
            // kamatna_stopaTextBox
            // 
            this.kamatna_stopaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kreditiBindingSource, "kamatna_stopa", true));
            this.kamatna_stopaTextBox.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kamatna_stopaTextBox.Location = new System.Drawing.Point(144, 133);
            this.kamatna_stopaTextBox.Name = "kamatna_stopaTextBox";
            this.kamatna_stopaTextBox.Size = new System.Drawing.Size(100, 28);
            this.kamatna_stopaTextBox.TabIndex = 8;
            // 
            // kamatni_usloviTextBox
            // 
            this.kamatni_usloviTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kreditiBindingSource, "kamatni_uslovi", true));
            this.kamatni_usloviTextBox.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kamatni_usloviTextBox.Location = new System.Drawing.Point(144, 173);
            this.kamatni_usloviTextBox.Name = "kamatni_usloviTextBox";
            this.kamatni_usloviTextBox.Size = new System.Drawing.Size(100, 28);
            this.kamatni_usloviTextBox.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.kreditiDataGridView);
            this.panel1.Location = new System.Drawing.Point(10, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 309);
            this.panel1.TabIndex = 11;
            // 
            // kreditiDataGridView
            // 
            this.kreditiDataGridView.AutoGenerateColumns = false;
            this.kreditiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kreditiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.kreditiDataGridView.DataSource = this.kreditiBindingSource;
            this.kreditiDataGridView.Location = new System.Drawing.Point(3, 3);
            this.kreditiDataGridView.Name = "kreditiDataGridView";
            this.kreditiDataGridView.Size = new System.Drawing.Size(543, 220);
            this.kreditiDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "krediti_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "krediti_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "klijenat_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "klijenat_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "kolicina_kredita";
            this.dataGridViewTextBoxColumn3.HeaderText = "kolicina_kredita";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "kamatna_stopa";
            this.dataGridViewTextBoxColumn4.HeaderText = "kamatna_stopa";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "kamatni_uslovi";
            this.dataGridViewTextBoxColumn5.HeaderText = "kamatni_uslovi";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnZatvori);
            this.panel2.Controls.Add(this.btnSacuvaj);
            this.panel2.Controls.Add(this.btnIzbrisi);
            this.panel2.Controls.Add(this.btnDodaj);
            this.panel2.Location = new System.Drawing.Point(588, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 434);
            this.panel2.TabIndex = 12;
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.Khaki;
            this.btnZatvori.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvori.Location = new System.Drawing.Point(56, 329);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(85, 33);
            this.btnZatvori.TabIndex = 7;
            this.btnZatvori.Text = "ZATVORI";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSacuvaj.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(56, 241);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(85, 31);
            this.btnSacuvaj.TabIndex = 6;
            this.btnSacuvaj.Text = "SACUVAJ";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackColor = System.Drawing.Color.Khaki;
            this.btnIzbrisi.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisi.Location = new System.Drawing.Point(56, 147);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(85, 35);
            this.btnIzbrisi.TabIndex = 5;
            this.btnIzbrisi.Text = "IZBRISI";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDodaj.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(56, 68);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(85, 32);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "DODAJ";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(krediti_idLabel);
            this.Controls.Add(this.krediti_idTextBox);
            this.Controls.Add(klijenat_idLabel);
            this.Controls.Add(this.klijenat_idTextBox);
            this.Controls.Add(kolicina_kreditaLabel);
            this.Controls.Add(this.kolicina_kreditaTextBox);
            this.Controls.Add(kamatna_stopaLabel);
            this.Controls.Add(this.kamatna_stopaTextBox);
            this.Controls.Add(kamatni_usloviLabel);
            this.Controls.Add(this.kamatni_usloviTextBox);
            this.Controls.Add(this.kreditiBindingNavigator);
            this.Name = "Form4";
            this.Text = "Krediti";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnkDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kreditiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kreditiBindingNavigator)).EndInit();
            this.kreditiBindingNavigator.ResumeLayout(false);
            this.kreditiBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kreditiDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bnkDataSet1 bnkDataSet1;
        private System.Windows.Forms.BindingSource kreditiBindingSource;
        private bnkDataSet1TableAdapters.kreditiTableAdapter kreditiTableAdapter;
        private bnkDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kreditiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton kreditiBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox krediti_idTextBox;
        private System.Windows.Forms.TextBox klijenat_idTextBox;
        private System.Windows.Forms.TextBox kolicina_kreditaTextBox;
        private System.Windows.Forms.TextBox kamatna_stopaTextBox;
        private System.Windows.Forms.TextBox kamatni_usloviTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView kreditiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnDodaj;
    }
}