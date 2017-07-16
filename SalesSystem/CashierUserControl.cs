using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SalesSystem
{
    public partial class CashierUserControl : UserControl
    {

        private System.Windows.Forms.Panel mProductPanel;
        private System.Windows.Forms.PictureBox mProductPictureBox;
        private System.Windows.Forms.NumericUpDown mProductNumberPicker;
        private System.Windows.Forms.Label mProductPriceLabel;
        private System.Windows.Forms.Label mProductNameLabel;



        public CashierUserControl()
        {
            InitializeComponent();
        }

        private void CashierUserControl_Load(object sender, EventArgs e)
        {
            string imagePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\assets\material_design_wallpaper-5.jpg";
            int xStartPoint = 2;
            int yStartPoint = 14;
            int xEndPoint = 460;
            int width = 200;
            int height = 157;
            int margin = 30;
            

            for (int i = 0; i < 10; i++){

                this.mProductPanel = new System.Windows.Forms.Panel();
                this.mProductPictureBox = new System.Windows.Forms.PictureBox();
                this.mProductNumberPicker = new System.Windows.Forms.NumericUpDown();
                this.mProductPriceLabel = new System.Windows.Forms.Label();
                this.mProductNameLabel = new System.Windows.Forms.Label();
                
                ((System.ComponentModel.ISupportInitialize)(this.mProductNumberPicker)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.mProductPictureBox)).BeginInit();

                // 
                // mProductPanel
                // 
                this.mProductPanel.Controls.Add(this.mProductNumberPicker);
                this.mProductPanel.Controls.Add(this.mProductPriceLabel);
                this.mProductPanel.Controls.Add(this.mProductNameLabel);
                this.mProductPanel.Controls.Add(this.mProductPictureBox);
                this.mProductPanel.Location = new System.Drawing.Point(xStartPoint, yStartPoint);
                this.mProductPanel.Name = "" + i;
                this.mProductPanel.Size = new System.Drawing.Size(200, 157);
                this.mProductPanel.TabIndex = i + 1;

                // 
                // mProductPictureBox
                // 
                if (File.Exists(imagePath) == true)
                {
                    this.mProductPictureBox.Image = Image.FromFile(imagePath);    
                }
                
                this.mProductPictureBox.Location = new System.Drawing.Point(0, 0);
                this.mProductPictureBox.Name = "mProductPictureBox";
                this.mProductPictureBox.Size = new System.Drawing.Size(200, 100);
                this.mProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                this.mProductPictureBox.TabIndex = i + 1;
                this.mProductPictureBox.TabStop = false;

                // 
                // mProductNameLabel
                // 
                this.mProductNameLabel.AutoSize = true;
                this.mProductNameLabel.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.mProductNameLabel.Location = new System.Drawing.Point(2, 107);
                this.mProductNameLabel.Name = "mProductNameLabel";
                this.mProductNameLabel.Size = new System.Drawing.Size(64, 15);
                this.mProductNameLabel.TabIndex = i;
                this.mProductNameLabel.Text = "Kit Kat Bar" + i;

                // 
                // mProductPriceLabel
                // 
                this.mProductPriceLabel.AutoSize = true;
                this.mProductPriceLabel.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.mProductPriceLabel.Location = new System.Drawing.Point(6, 130);
                this.mProductPriceLabel.Name = "mProductPriceLabel";
                this.mProductPriceLabel.Size = new System.Drawing.Size(49, 19);
                this.mProductPriceLabel.TabIndex = i;
                this.mProductPriceLabel.Text = "RM30";


                // 
                // mProductNumberPicker
                // 
                this.mProductNumberPicker.Location = new System.Drawing.Point(154, 134);
                this.mProductNumberPicker.Name = "mProductNumberPicker";
                this.mProductNumberPicker.Size = new System.Drawing.Size(42, 20);
                this.mProductNumberPicker.TabIndex = i;
                this.mProductNumberPicker.Maximum = 10;
                this.mProductNumberPicker.Minimum = 0;


                panelContainer.Controls.Add(mProductPanel);
                ((System.ComponentModel.ISupportInitialize)(this.mProductNumberPicker)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.mProductPictureBox)).EndInit();


                if (xStartPoint > xEndPoint)
                {
                    xStartPoint = 5; //reset to the initil start point in the x line
                    yStartPoint = 14 + height + margin; // wrape to the next line
                }
                else
                {
                    xStartPoint = xStartPoint + width + margin;
                }




            }
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            //TODO create order
            var products = new List<KeyValuePair<int, int>>();
            for (int i = 0; i < panelContainer.Controls.Count; i++)
            {
                this.mProductPanel = (Panel)panelContainer.Controls[i];
                this.mProductNumberPicker = (NumericUpDown)this.mProductPanel.Controls["mProductNumberPicker"];
                int id = Int32.Parse(this.mProductPanel.Name);
                int value = (int) this.mProductNumberPicker.Value;
                products.Add(new KeyValuePair<int, int>(id, value));
            }

            foreach (KeyValuePair<int, int> entry in products)
            {
                //TODO create order_item and assign order id to order_id
                Console.WriteLine("OUTPUT:::  " + entry);
            }
            
        }

        /* private void _Click(object sender, EventArgs e)
         {
             for (int i = 0; i < panelContainer.Controls.Count; i++ )
             {
                
                
             }
             this.mProductPanel = (Panel)panelContainer.Controls[index];
             this.mProductNameLabel = (Label)this.mProductPanel.Controls["mProductNameLabel"];
             this.mProductPriceLabel = (Label)this.mProductPanel.Controls["mProductNameLabel"];
             this.mProductNumberPicker = (NumericUpDown)this.mProductPanel.Controls["mProductNumberPicker"];


             Console.WriteLine("Clicked " + this.mProductNumberPicker.Value);
             
         }*/

    }
}
