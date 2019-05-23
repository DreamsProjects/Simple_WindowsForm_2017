using Databasteknik_Inlämning1.All_classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Databasteknik_Inlämning1.All_forms
{
    public partial class RegisterNew : Form
    {
        public RegisterNew()
        {
            InitializeComponent();
            AddContactComboboxItems();
        }

        private void AddContactComboboxItems()
        {
            WhatContactCombobox.Items.Add("Personlig kontakt");
            WhatContactCombobox.Items.Add("Företags kontakt");
            WhatContactCombobox.Items.Add("Övrig kontakt");

        }

        private void FirstnameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            RegisterPerson p = new RegisterPerson();
            p.Firstname = FirstnameTextbox.Text;
            p.LastName = LastnameTextbox.Text;
            p.Address = StreetnameTextbox.Text;
            p.MailingAddress = Convert.ToInt32(MailingAddressTextbox.Text);
            p.PhoneNumber = PhonenumberTextbox.Text;
            p.Mail = MailingAddressTextbox.Text;


        }

        private void WhatContactCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
