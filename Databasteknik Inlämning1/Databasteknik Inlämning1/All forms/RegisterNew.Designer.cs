namespace Databasteknik_Inlämning1.All_forms
{
    partial class RegisterNew
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FirstnameTextbox = new System.Windows.Forms.TextBox();
            this.LastnameTextbox = new System.Windows.Forms.TextBox();
            this.StreetnameTextbox = new System.Windows.Forms.TextBox();
            this.MailingAddressTextbox = new System.Windows.Forms.TextBox();
            this.PhonenumberTextbox = new System.Windows.Forms.TextBox();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.WhatContactCombobox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Förnamn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Efternamn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gatunamn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Postnummer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefonnummer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Epostadress:";
            // 
            // FirstnameTextbox
            // 
            this.FirstnameTextbox.Location = new System.Drawing.Point(123, 17);
            this.FirstnameTextbox.Name = "FirstnameTextbox";
            this.FirstnameTextbox.Size = new System.Drawing.Size(235, 20);
            this.FirstnameTextbox.TabIndex = 6;
            this.FirstnameTextbox.TextChanged += new System.EventHandler(this.FirstnameTextbox_TextChanged);
            // 
            // LastnameTextbox
            // 
            this.LastnameTextbox.Location = new System.Drawing.Point(123, 59);
            this.LastnameTextbox.Name = "LastnameTextbox";
            this.LastnameTextbox.Size = new System.Drawing.Size(235, 20);
            this.LastnameTextbox.TabIndex = 7;
            // 
            // StreetnameTextbox
            // 
            this.StreetnameTextbox.Location = new System.Drawing.Point(123, 103);
            this.StreetnameTextbox.Name = "StreetnameTextbox";
            this.StreetnameTextbox.Size = new System.Drawing.Size(235, 20);
            this.StreetnameTextbox.TabIndex = 8;
            // 
            // MailingAddressTextbox
            // 
            this.MailingAddressTextbox.Location = new System.Drawing.Point(123, 153);
            this.MailingAddressTextbox.Name = "MailingAddressTextbox";
            this.MailingAddressTextbox.Size = new System.Drawing.Size(235, 20);
            this.MailingAddressTextbox.TabIndex = 9;
            // 
            // PhonenumberTextbox
            // 
            this.PhonenumberTextbox.Location = new System.Drawing.Point(123, 204);
            this.PhonenumberTextbox.Name = "PhonenumberTextbox";
            this.PhonenumberTextbox.Size = new System.Drawing.Size(235, 20);
            this.PhonenumberTextbox.TabIndex = 10;
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(123, 250);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(235, 20);
            this.EmailTextbox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Typ av kontakt:";
            // 
            // WhatContactCombobox
            // 
            this.WhatContactCombobox.FormattingEnabled = true;
            this.WhatContactCombobox.Location = new System.Drawing.Point(123, 301);
            this.WhatContactCombobox.Name = "WhatContactCombobox";
            this.WhatContactCombobox.Size = new System.Drawing.Size(235, 21);
            this.WhatContactCombobox.TabIndex = 16;
            this.WhatContactCombobox.SelectedIndexChanged += new System.EventHandler(this.WhatContactCombobox_SelectedIndexChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(196, 352);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Spara";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // RegisterNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 464);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.WhatContactCombobox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.PhonenumberTextbox);
            this.Controls.Add(this.MailingAddressTextbox);
            this.Controls.Add(this.StreetnameTextbox);
            this.Controls.Add(this.LastnameTextbox);
            this.Controls.Add(this.FirstnameTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterNew";
            this.Text = "RegisterNew";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FirstnameTextbox;
        private System.Windows.Forms.TextBox LastnameTextbox;
        private System.Windows.Forms.TextBox StreetnameTextbox;
        private System.Windows.Forms.TextBox MailingAddressTextbox;
        private System.Windows.Forms.TextBox PhonenumberTextbox;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox WhatContactCombobox;
        private System.Windows.Forms.Button SaveButton;
    }
}