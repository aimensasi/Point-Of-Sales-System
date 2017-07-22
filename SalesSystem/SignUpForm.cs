using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesSystem
{
    public partial class SignUpForm : Form
    {
        private string name;
        private string email;
        private string password;
        private int role = -1;
        private DateTime created_at;
        private DateTime updated_at;

        private User user;


        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {

            try
            {
                name = name_field.Text;
                email = email_field.Text;
                password = password_field.Text;
                if (admin_btn.Checked)
                {
                    role = 1;
                }else if(cashier_btn.Checked){
                    role = 0;
                }

                if (name != "" && email != "" && password != "" && role != -1)
                {
                    user = new User(name, email, password, role);
                }
            }
            catch (IOException ex) {
                Console.WriteLine("IOException source: {0}", ex);  
            }

        }
    }
}
