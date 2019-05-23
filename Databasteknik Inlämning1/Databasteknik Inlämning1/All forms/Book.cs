using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Databasteknik_Inlämning1.All_classes;
using System;

namespace Databasteknik_Inlämning1
{
    public partial class Book : Form
    {
        List<RegisterPerson> newPeople = new List<RegisterPerson>();

        public Book()
        {
            InitializeComponent();
        }

        private void LoadAddressBook()
        {
            Reader read = new Reader();
            var text = "Select Adress from Address ";
            var order = read.Person(text, CommandType.Text, null);
            AddressesDataGridView.DataSource = order; //För att sätta ihop med lista
        }

        private void InfoDataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Reader read = new Reader();    
            var commandtext = "select KundID, Adress, from Addresses ";
            var roxIndex = e.RowIndex;
            var row = AddressesDataGridView.Rows[roxIndex]; //Får fram den utvalda radens information, kopplas sedan med en metod som får fram informationen
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SQLSearch search = new SQLSearch(AddressTextbox.Text);
        }

        private void registreraNyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.OpenSecondForm = true;
            Close();
        }

        private void stängToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uppdaterataBortToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void läggTillTaBortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.UpdateForm = true;
            Close();
        }

        private void uppdateraAdressToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Book_Load(object sender, EventArgs e)
        {
        }

        private void addressesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.addressesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.addressBookDataSet);

        }
        private void AddressesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
