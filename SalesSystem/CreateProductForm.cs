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
    public partial class CreateProductForm : Form
    {
        public CreateProductForm()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {

        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "images| *.JPG; *.PNG; *.JPEG"; // you can add any other image type
            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\assets\"; 

            if (Directory.Exists(appPath) == false)                                              
            {
                Console.WriteLine(appPath + " :: PATH");                                                              
                Directory.CreateDirectory(appPath);                                              
            }

            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string iName = openFileDialog1.SafeFileName;
                string fileName = openFileDialog1.FileName;
                File.Copy(fileName, appPath + iName);
                pictureBox1.Image = Image.FromFile(fileName);
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {

        }

  
   
    }
}
