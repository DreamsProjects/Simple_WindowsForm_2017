using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Databasteknik_Inlämning1
{
    public partial class UpdateDelete : Form
    {
        public UpdateDelete()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //Registrera ny adress på ID
            //Om adressen finns så ska den uppdateras

        }

        private void DeleteAddressButton_Click(object sender, EventArgs e)
        {
            //Denna ska ta bort adressen i databasen om ID och adressen stämmer överens
        }
    }
}
