namespace Databasteknik_Inlämning1
{
    partial class Book
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.RegisterNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uppdaterataBortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.läggTillTaBortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uppdateraAdressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.AddressTextbox = new System.Windows.Forms.TextBox();
            this.addressBookDataSet = new Databasteknik_Inlämning1.AddressBookDataSet();
            this.addressesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressesTableAdapter = new Databasteknik_Inlämning1.AddressBookDataSetTableAdapters.AddressesTableAdapter();
            this.tableAdapterManager = new Databasteknik_Inlämning1.AddressBookDataSetTableAdapters.TableAdapterManager();
            this.AddressesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(454, 278);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(118, 30);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Sök i databas";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegisterNewToolStripMenuItem,
            this.uppdaterataBortToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // RegisterNewToolStripMenuItem
            // 
            this.RegisterNewToolStripMenuItem.Name = "RegisterNewToolStripMenuItem";
            this.RegisterNewToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.RegisterNewToolStripMenuItem.Text = "Registrera ny";
            this.RegisterNewToolStripMenuItem.Click += new System.EventHandler(this.registreraNyToolStripMenuItem_Click);
            // 
            // uppdaterataBortToolStripMenuItem
            // 
            this.uppdaterataBortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.läggTillTaBortToolStripMenuItem,
            this.uppdateraAdressToolStripMenuItem});
            this.uppdaterataBortToolStripMenuItem.Name = "uppdaterataBortToolStripMenuItem";
            this.uppdaterataBortToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.uppdaterataBortToolStripMenuItem.Text = "Adresshantering";
            this.uppdaterataBortToolStripMenuItem.Click += new System.EventHandler(this.uppdaterataBortToolStripMenuItem_Click);
            // 
            // läggTillTaBortToolStripMenuItem
            // 
            this.läggTillTaBortToolStripMenuItem.Name = "läggTillTaBortToolStripMenuItem";
            this.läggTillTaBortToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.läggTillTaBortToolStripMenuItem.Text = "Lägg till/ ta bort";
            this.läggTillTaBortToolStripMenuItem.Click += new System.EventHandler(this.läggTillTaBortToolStripMenuItem_Click);
            // 
            // uppdateraAdressToolStripMenuItem
            // 
            this.uppdateraAdressToolStripMenuItem.Name = "uppdateraAdressToolStripMenuItem";
            this.uppdateraAdressToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.uppdateraAdressToolStripMenuItem.Text = "Uppdatera adress";
            this.uppdateraAdressToolStripMenuItem.Click += new System.EventHandler(this.uppdateraAdressToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.ExitToolStripMenuItem.Text = "Stäng";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.stängToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adress:";
            // 
            // AddressTextbox
            // 
            this.AddressTextbox.Location = new System.Drawing.Point(88, 288);
            this.AddressTextbox.Name = "AddressTextbox";
            this.AddressTextbox.Size = new System.Drawing.Size(334, 20);
            this.AddressTextbox.TabIndex = 6;
            // 
            // addressBookDataSet
            // 
            this.addressBookDataSet.DataSetName = "AddressBookDataSet";
            this.addressBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressesBindingSource
            // 
            this.addressesBindingSource.DataMember = "Addresses";
            this.addressesBindingSource.DataSource = this.addressBookDataSet;
            // 
            // addressesTableAdapter
            // 
            this.addressesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AddressesTableAdapter = this.addressesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContactInfoTableAdapter = null;
            this.tableAdapterManager.EmailAddressesTableAdapter = null;
            this.tableAdapterManager.OwnerOfAddressTableAdapter = null;
            this.tableAdapterManager.PhoneNumbersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Databasteknik_Inlämning1.AddressBookDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // AddressesDataGridView
            // 
            this.AddressesDataGridView.AutoGenerateColumns = false;
            this.AddressesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddressesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.AddressesDataGridView.DataSource = this.addressesBindingSource;
            this.AddressesDataGridView.Location = new System.Drawing.Point(12, 52);
            this.AddressesDataGridView.Name = "AddressesDataGridView";
            this.AddressesDataGridView.Size = new System.Drawing.Size(560, 220);
            this.AddressesDataGridView.TabIndex = 7;
            this.AddressesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddressesDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Gatunamn";
            this.dataGridViewTextBoxColumn3.HeaderText = "Gatunamn";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Postnummer";
            this.dataGridViewTextBoxColumn4.HeaderText = "Postnummer";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Postort";
            this.dataGridViewTextBoxColumn5.HeaderText = "Postort";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 331);
            this.Controls.Add(this.AddressesDataGridView);
            this.Controls.Add(this.AddressTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Book";
            this.Text = "Adressbok";
            this.Load += new System.EventHandler(this.Book_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem RegisterNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uppdaterataBortToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddressTextbox;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem läggTillTaBortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uppdateraAdressToolStripMenuItem;
        private AddressBookDataSet addressBookDataSet;
        private System.Windows.Forms.BindingSource addressesBindingSource;
        private AddressBookDataSetTableAdapters.AddressesTableAdapter addressesTableAdapter;
        private AddressBookDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView AddressesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

