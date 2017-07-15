using System;
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
    public partial class ProductForm : UserControl
    {
        public ProductForm()
        {
            InitializeComponent();

            addProducts("Jat", "RM200", "Standred Rate", "90", "20_20_2019");
            addProducts("Kat", "RM200", "Standred Rate", "90", "20_20_2019");
            addProducts("KApx", "RM200", "Zero Rate Rate", "90", "20_20_2019");
            addProducts("Kit Kat", "RM200", "Standred Rate", "90", "20_20_2019");

        }

        public void addProducts(string name, string price, string category, string stockLevel, string exDate)
        {
            bunifuCustomDataGrid1.Rows.Add();
            bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[0].Value = name;
            bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[1].Value = price;
            bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[2].Value = category;
            bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[3].Value = stockLevel;
            bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[4].Value = exDate;

            
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
