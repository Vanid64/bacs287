﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project7
{
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
            lblName.Text = User.Name;
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show(generateProfileInfo());
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOrder order = new frmOrder();
            order.ShowDialog();
        }

        private string generateProfileInfo()
        {
            FileFunctions funcs = new FileFunctions();
            string message = "Here are the tickets you've purchased:\n";
            message += "Lower: " + funcs.getField(User.Email, 7, "users.csv") + "\n";
            message += "Club: " + funcs.getField(User.Email, 8, "users.csv") + "\n";
            message += "Upper: " + funcs.getField(User.Email, 9, "users.csv") + "\n";
            return message;
        }
    }
}
