namespace WindowsFormsApp1
{
    partial class Form5
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
            System.Windows.Forms.Label broj_racunaLabel;
            System.Windows.Forms.Label klijenat_idLabel;
            System.Windows.Forms.Label racunLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.bnkDataSet1 = new WindowsFormsApp1.bnkDataSet1();
            this.racuniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racuniTableAdapter = new WindowsFormsApp1.bnkDataSet1TableAdapters.racuniTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.bnkDataSet1TableAdapters.TableAdapterManager();
            this.racuniBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.racuniBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.broj_racunaTextBox = new System.Windows.Forms.TextBox();
            this.klijenat_idTextBox = new System.Windows.Forms.TextBox();
            this.racunTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.racuniDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            broj_racunaLabel = new System.Windows.Forms.Label();
            klijenat_idLabel = new System.Windows.Forms.Label();
            racunLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bnkDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racuniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racuniBindingNavigator)).BeginInit();
            this.racuniBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racuniDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // broj_racunaLabel
            // 
            broj_racunaLabel.AutoSize = true;
            broj_racunaLabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            broj_racunaLabel.Location = new System.Drawing.Point(44, 90);
            broj_racunaLabel.Name = "broj_racunaLabel";
            broj_racunaLabel.Size = new System.Drawing.Size(95, 23);
            broj_racunaLabel.TabIndex = 1;
            broj_racunaLabel.Text = "broj racuna:";
            // 
            // klijenat_idLabel
            // 
            klijenat_idLabel.AutoSize = true;
            klijenat_idLabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            klijenat_idLabel.Location = new System.Drawing.Point(56, 116);
            klijenat_idLabel.Name = "klijenat_idLabel";
            klijenat_idLabel.Size = new System.Drawing.Size(85, 23);
            klijenat_idLabel.TabIndex = 3;
            klijenat_idLabel.Text = "klijenat id:";
            // 
            // racunLabel
            // 
            racunLabel.AutoSize = true;
            racunLabel.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            racunLabel.Location = new System.Drawing.Point(89, 142);
            racunLabel.Name = "racunLabel";
            racunLabel.Size = new System.Drawing.Size(55, 23);
            racunLabel.TabIndex = 5;
            racunLabel.Text = "racun:";
            // 
            // bnkDataSet1
            // 
            this.bnkDataSet1.DataSetName = "bnkDataSet1";
            this.bnkDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // racuniBindingSource
            // 
            this.racuniBindingSource.DataMember = "racuni";
            this.racuniBindingSource.DataSource = this.bnkDataSet1;
            // 
            // racuniTableAdapter
            // 
            this.racuniTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.karticeTableAdapter = null;
            this.tableAdapterManager.klijenatTableAdapter = null;
            this.tableAdapterManager.kreditiTableAdapter = null;
            this.tableAdapterManager.racuniTableAdapter = this.racuniTableAdapter;
            this.tableAdapterManager.transakcija_povjestiTableAdapter = null;
            this.tableAdapterManager.transakcijeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.bnkDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.zaposleniciTableAdapter = null;
            // 
            // racuniBindingNavigator
            // 
            this.racuniBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.racuniBindingNavigator.BindingSource = this.racuniBindingSource;
            this.racuniBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.racuniBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.racuniBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.racuniBindingNavigatorSaveItem});
            this.racuniBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.racuniBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.racuniBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.racuniBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.racuniBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.racuniBindingNavigator.Name = "racuniBindingNavigator";
            this.racuniBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.racuniBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.racuniBindingNavigator.TabIndex = 0;
            this.racuniBindingNavigator.Text = "bindingNavigator1";
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
            // racuniBindingNavigatorSaveItem
            // 
            this.racuniBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.racuniBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("racuniBindingNavigatorSaveItem.Image")));
            this.racuniBindingNavigatorSaveItem.Name = "racuniBindingNavigatorSaveItem";
            this.racuniBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.racuniBindingNavigatorSaveItem.Text = "Save Data";
            this.racuniBindingNavigatorSaveItem.Click += new System.EventHandler(this.racuniBindingNavigatorSaveItem_Click);
            // 
            // broj_racunaTextBox
            // 
            this.broj_racunaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racuniBindingSource, "broj_racuna", true));
            this.broj_racunaTextBox.Location = new System.Drawing.Point(153, 90);
            this.broj_racunaTextBox.Name = "broj_racunaTextBox";
            this.broj_racunaTextBox.Size = new System.Drawing.Size(100, 20);
            this.broj_racunaTextBox.TabIndex = 2;
            // 
            // klijenat_idTextBox
            // 
            this.klijenat_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racuniBindingSource, "klijenat_id", true));
            this.klijenat_idTextBox.Location = new System.Drawing.Point(153, 118);
            this.klijenat_idTextBox.Name = "klijenat_idTextBox";
            this.klijenat_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.klijenat_idTextBox.TabIndex = 4;
            // 
            // racunTextBox
            // 
            this.racunTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racuniBindingSource, "racun", true));
            this.racunTextBox.Location = new System.Drawing.Point(153, 144);
            this.racunTextBox.Name = "racunTextBox";
            this.racunTextBox.Size = new System.Drawing.Size(100, 20);
            this.racunTextBox.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.racuniDataGridView);
            this.panel1.Location = new System.Drawing.Point(12, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 302);
            this.panel1.TabIndex = 7;
            // 
            // racuniDataGridView
            // 
            this.racuniDataGridView.AutoGenerateColumns = false;
            this.racuniDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.racuniDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.racuniDataGridView.DataSource = this.racuniBindingSource;
            this.racuniDataGridView.Location = new System.Drawing.Point(12, 15);
            this.racuniDataGridView.Name = "racuniDataGridView";
            this.racuniDataGridView.Size = new System.Drawing.Size(345, 220);
            this.racuniDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "broj_racuna";
            this.dataGridViewTextBoxColumn1.HeaderText = "broj_racuna";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "racun";
            this.dataGridViewTextBoxColumn3.HeaderText = "racun";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnZatvori);
            this.panel2.Controls.Add(this.btnSacuvaj);
            this.panel2.Controls.Add(this.btnIzbrisi);
            this.panel2.Controls.Add(this.btnDodaj);
            this.panel2.Location = new System.Drawing.Point(537, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 432);
            this.panel2.TabIndex = 8;
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.Khaki;
            this.btnZatvori.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvori.Location = new System.Drawing.Point(58, 330);
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
            this.btnSacuvaj.Location = new System.Drawing.Point(58, 242);
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
            this.btnIzbrisi.Location = new System.Drawing.Point(58, 148);
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
            this.btnDodaj.Location = new System.Drawing.Point(58, 62);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(85, 32);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "DODAJ";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(broj_racunaLabel);
            this.Controls.Add(this.broj_racunaTextBox);
            this.Controls.Add(klijenat_idLabel);
            this.Controls.Add(this.klijenat_idTextBox);
            this.Controls.Add(racunLabel);
            this.Controls.Add(this.racunTextBox);
            this.Controls.Add(this.racuniBindingNavigator);
            this.Name = "Form5";
            this.Text = "Racuni";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnkDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racuniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racuniBindingNavigator)).EndInit();
            this.racuniBindingNavigator.ResumeLayout(false);
            this.racuniBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.racuniDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bnkDataSet1 bnkDataSet1;
        private System.Windows.Forms.BindingSource racuniBindingSource;
        private bnkDataSet1TableAdapters.racuniTableAdapter racuniTableAdapter;
        private bnkDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator racuniBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton racuniBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox broj_racunaTextBox;
        private System.Windows.Forms.TextBox klijenat_idTextBox;
        private System.Windows.Forms.TextBox racunTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView racuniDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnDodaj;
    }
}