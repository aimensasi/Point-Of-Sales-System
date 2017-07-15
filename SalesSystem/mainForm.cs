using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tb_dashboard_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            dashboard1.BringToFront();
        }

        private void tbs_product_click(object sender, EventArgs e)
        {
            products1.Visible = true;
            products1.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            orderForm1.Visible = true;
            orderForm1.BringToFront();
        }

    }
}
