﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesSystem
{
    public partial class UserForm : UserControl
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void btn_new_product_Click(object sender, EventArgs e)
        {
            CreateUserForm user = new CreateUserForm();
            user.ShowDialog();
         
        }
    }
}
