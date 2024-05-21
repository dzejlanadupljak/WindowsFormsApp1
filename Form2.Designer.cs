namespace WindowsFormsApp1
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
            System.Windows.Forms.Label kartice_idLabel;
            System.Windows.Forms.Label racuni_idLabel;
            System.Windows.Forms.Label vrsta_karticeLabel;
            System.Windows.Forms.Label datu_istekaLabel;
            System.Windows.Forms.Label stanjeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bnkDataSet1 = new WindowsFormsApp1.bnkDataSet1();
            this.karticeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.karticeTableAdapter = new WindowsFormsApp1.bnkDataSet1TableAdapters.karticeTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.bnkDataSet1TableAdapters.TableAdapterManager();
            this.karticeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.karticeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kartice_idTextBox = new System.Windows.Forms.TextBox();
            this.racuni_idTextBox = new System.Windows.Forms.TextBox();
            this.vrsta_karticeTextBox = new System.Windows.Forms.TextBox();
            this.datu_istekaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.stanjeTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.karticeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            kartice_idLabel = new System.Windows.Forms.Label();
            racuni_idLabel = new System.Windows.Forms.Label();
            vrsta_karticeLabel = new System.Windows.Forms.Label();
            datu_istekaLabel = new System.Windows.Forms.Label();
            stanjeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bnkDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karticeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karticeBindingNavigator)).BeginInit();
            this.karticeBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.karticeDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kartice_idLabel
            // 
            kartice_idLabel.AutoSize = true;
            kartice_idLabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kartice_idLabel.Location = new System.Drawing.Point(58, 58);
            kartice_idLabel.Name = "kartice_idLabel";
            kartice_idLabel.Size = new System.Drawing.Size(80, 23);
            kartice_idLabel.TabIndex = 1;
            kartice_idLabel.Text = "kartice id:";
            kartice_idLabel.Click += new System.EventHandler(this.kartice_idLabel_Click);
            // 
            // racuni_idLabel
            // 
            racuni_idLabel.AutoSize = true;
            racuni_idLabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            racuni_idLabel.Location = new System.Drawing.Point(60, 87);
            racuni_idLabel.Name = "racuni_idLabel";
            racuni_idLabel.Size = new System.Drawing.Size(78, 23);
            racuni_idLabel.TabIndex = 3;
            racuni_idLabel.Text = "racuni id:";
            // 
            // vrsta_karticeLabel
            // 
            vrsta_karticeLabel.AutoSize = true;
            vrsta_karticeLabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vrsta_karticeLabel.Location = new System.Drawing.Point(37, 120);
            vrsta_karticeLabel.Name = "vrsta_karticeLabel";
            vrsta_karticeLabel.Size = new System.Drawing.Size(101, 23);
            vrsta_karticeLabel.TabIndex = 5;
            vrsta_karticeLabel.Text = "vrsta kartice:";
            // 
            // datu_istekaLabel
            // 
            datu_istekaLabel.AutoSize = true;
            datu_istekaLabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            datu_istekaLabel.Location = new System.Drawing.Point(48, 157);
            datu_istekaLabel.Name = "datu_istekaLabel";
            datu_istekaLabel.Size = new System.Drawing.Size(90, 23);
            datu_istekaLabel.TabIndex = 7;
            datu_istekaLabel.Text = "datu isteka:";
            // 
            // stanjeLabel
            // 
            stanjeLabel.AutoSize = true;
            stanjeLabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stanjeLabel.Location = new System.Drawing.Point(82, 184);
            stanjeLabel.Name = "stanjeLabel";
            stanjeLabel.Size = new System.Drawing.Size(56, 23);
            stanjeLabel.TabIndex = 9;
            stanjeLabel.Text = "stanje:";
            // 
            // bnkDataSet1
            // 
            this.bnkDataSet1.DataSetName = "bnkDataSet1";
            this.bnkDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // karticeBindingSource
            // 
            this.karticeBindingSource.DataMember = "kartice";
            this.karticeBindingSource.DataSource = this.bnkDataSet1;
            // 
            // karticeTableAdapter
            // 
            this.karticeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.karticeTableAdapter = this.karticeTableAdapter;
            this.tableAdapterManager.klijenatTableAdapter = null;
            this.tableAdapterManager.kreditiTableAdapter = null;
            this.tableAdapterManager.racuniTableAdapter = null;
            this.tableAdapterManager.transakcija_povjestiTableAdapter = null;
            this.tableAdapterManager.transakcijeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.bnkDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.zaposleniciTableAdapter = null;
            // 
            // karticeBindingNavigator
            // 
            this.karticeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.karticeBindingNavigator.BindingSource = this.karticeBindingSource;
            this.karticeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.karticeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.karticeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.karticeBindingNavigatorSaveItem});
            this.karticeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.karticeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.karticeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.karticeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.karticeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.karticeBindingNavigator.Name = "karticeBindingNavigator";
            this.karticeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.karticeBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.karticeBindingNavigator.TabIndex = 0;
            this.karticeBindingNavigator.Text = "bindingNavigator1";
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
            // karticeBindingNavigatorSaveItem
            // 
            this.karticeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.karticeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("karticeBindingNavigatorSaveItem.Image")));
            this.karticeBindingNavigatorSaveItem.Name = "karticeBindingNavigatorSaveItem";
            this.karticeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.karticeBindingNavigatorSaveItem.Text = "Save Data";
            this.karticeBindingNavigatorSaveItem.Click += new System.EventHandler(this.karticeBindingNavigatorSaveItem_Click);
            // 
            // kartice_idTextBox
            // 
            this.kartice_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karticeBindingSource, "kartice_id", true));
            this.kartice_idTextBox.Location = new System.Drawing.Point(144, 58);
            this.kartice_idTextBox.Name = "kartice_idTextBox";
            this.kartice_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.kartice_idTextBox.TabIndex = 2;
            // 
            // racuni_idTextBox
            // 
            this.racuni_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karticeBindingSource, "racuni_id", true));
            this.racuni_idTextBox.Location = new System.Drawing.Point(144, 91);
            this.racuni_idTextBox.Name = "racuni_idTextBox";
            this.racuni_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.racuni_idTextBox.TabIndex = 4;
            // 
            // vrsta_karticeTextBox
            // 
            this.vrsta_karticeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karticeBindingSource, "vrsta_kartice", true));
            this.vrsta_karticeTextBox.Location = new System.Drawing.Point(144, 117);
            this.vrsta_karticeTextBox.Name = "vrsta_karticeTextBox";
            this.vrsta_karticeTextBox.Size = new System.Drawing.Size(200, 20);
            this.vrsta_karticeTextBox.TabIndex = 6;
            // 
            // datu_istekaDateTimePicker
            // 
            this.datu_istekaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.karticeBindingSource, "datu_isteka", true));
            this.datu_istekaDateTimePicker.Location = new System.Drawing.Point(144, 157);
            this.datu_istekaDateTimePicker.Name = "datu_istekaDateTimePicker";
            this.datu_istekaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datu_istekaDateTimePicker.TabIndex = 8;
            // 
            // stanjeTextBox
            // 
            this.stanjeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karticeBindingSource, "stanje", true));
            this.stanjeTextBox.Location = new System.Drawing.Point(144, 188);
            this.stanjeTextBox.Name = "stanjeTextBox";
            this.stanjeTextBox.Size = new System.Drawing.Size(200, 20);
            this.stanjeTextBox.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.karticeDataGridView);
            this.panel1.Location = new System.Drawing.Point(12, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 300);
            this.panel1.TabIndex = 11;
            // 
            // karticeDataGridView
            // 
            this.karticeDataGridView.AutoGenerateColumns = false;
            this.karticeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.karticeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.karticeDataGridView.DataSource = this.karticeBindingSource;
            this.karticeDataGridView.Location = new System.Drawing.Point(3, 3);
            this.karticeDataGridView.Name = "karticeDataGridView";
            this.karticeDataGridView.Size = new System.Drawing.Size(538, 231);
            this.karticeDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "kartice_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "kartice_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "racuni_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "racuni_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "vrsta_kartice";
            this.dataGridViewTextBoxColumn3.HeaderText = "vrsta_kartice";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "datu_isteka";
            this.dataGridViewTextBoxColumn4.HeaderText = "datu_isteka";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "stanje";
            this.dataGridViewTextBoxColumn5.HeaderText = "stanje";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnIzadji);
            this.panel2.Controls.Add(this.btnSacuvaj);
            this.panel2.Controls.Add(this.btnIzbrisi);
            this.panel2.Controls.Add(this.btnDodaj);
            this.panel2.Location = new System.Drawing.Point(579, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 435);
            this.panel2.TabIndex = 12;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDodaj.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(64, 64);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(85, 32);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "DODAJ";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackColor = System.Drawing.Color.Khaki;
            this.btnIzbrisi.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisi.Location = new System.Drawing.Point(64, 143);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(85, 35);
            this.btnIzbrisi.TabIndex = 1;
            this.btnIzbrisi.Text = "IZBRISI";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSacuvaj.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(64, 237);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(85, 31);
            this.btnSacuvaj.TabIndex = 2;
            this.btnSacuvaj.Text = "SACUVAJ";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.BackColor = System.Drawing.Color.Khaki;
            this.btnIzadji.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzadji.Location = new System.Drawing.Point(64, 325);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(85, 33);
            this.btnIzadji.TabIndex = 3;
            this.btnIzadji.Text = "ZATVORI";
            this.btnIzadji.UseVisualStyleBackColor = false;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(kartice_idLabel);
            this.Controls.Add(this.kartice_idTextBox);
            this.Controls.Add(racuni_idLabel);
            this.Controls.Add(this.racuni_idTextBox);
            this.Controls.Add(vrsta_karticeLabel);
            this.Controls.Add(this.vrsta_karticeTextBox);
            this.Controls.Add(datu_istekaLabel);
            this.Controls.Add(this.datu_istekaDateTimePicker);
            this.Controls.Add(stanjeLabel);
            this.Controls.Add(this.stanjeTextBox);
            this.Controls.Add(this.karticeBindingNavigator);
            this.Name = "Form2";
            this.Text = "Kartice";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnkDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karticeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karticeBindingNavigator)).EndInit();
            this.karticeBindingNavigator.ResumeLayout(false);
            this.karticeBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.karticeDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bnkDataSet1 bnkDataSet1;
        private System.Windows.Forms.BindingSource karticeBindingSource;
        private bnkDataSet1TableAdapters.karticeTableAdapter karticeTableAdapter;
        private bnkDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator karticeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton karticeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox kartice_idTextBox;
        private System.Windows.Forms.TextBox racuni_idTextBox;
        private System.Windows.Forms.TextBox vrsta_karticeTextBox;
        private System.Windows.Forms.DateTimePicker datu_istekaDateTimePicker;
        private System.Windows.Forms.TextBox stanjeTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView karticeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnDodaj;
    }
}