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
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Panel mProductPanel;
        private System.Windows.Forms.PictureBox mProductPictureBox;
        private System.Windows.Forms.NumericUpDown mProductNumberPicker;
        private Bunifu.Framework.UI.BunifuFlatButton mProductAddButton;
        private System.Windows.Forms.Label mProductPriceLabel;
        private System.Windows.Forms.Label mProductNameLabel;



        public CashierUserControl()
        {
            InitializeComponent(loadComponents());
        }

        private System.Windows.Forms.Panel loadComponents()
        {
            this.containerPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();

            // 
            // containerPanel
            // 
            this.containerPanel.AutoScroll = true;
            this.containerPanel.Controls.Add(this.mProductPanel); //Line
            this.containerPanel.Location = new System.Drawing.Point(11, 15);
            this.containerPanel.Name = "panel1";
            this.containerPanel.Size = new System.Drawing.Size(678, 336);
            this.containerPanel.TabIndex = 0;


            int xStartPoint = 5;
            int yStartPoint = 14;
            int xEndPoint = 460;
            int width = 200;
            int height = 157;
            int margin = 30;

            string imagePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\assets\20031116_915119268629464_637473402_n.png";

            for (int i = 0; i < 10; i++)
            {
                this.mProductPanel = new System.Windows.Forms.Panel();
                this.mProductNumberPicker = new System.Windows.Forms.NumericUpDown();
                this.mProductAddButton = new Bunifu.Framework.UI.BunifuFlatButton();
                this.mProductPriceLabel = new System.Windows.Forms.Label();
                this.mProductNameLabel = new System.Windows.Forms.Label();
                this.mProductPictureBox = new System.Windows.Forms.PictureBox();
                this.containerPanel.SuspendLayout();
                this.mProductPanel.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.mProductNumberPicker)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.mProductPictureBox)).BeginInit();

                // 
                // mProductPanel
                // 
                this.mProductPanel.Controls.Add(this.mProductNumberPicker);
                this.mProductPanel.Controls.Add(this.mProductAddButton);
                this.mProductPanel.Controls.Add(this.mProductPriceLabel);
                this.mProductPanel.Controls.Add(this.mProductNameLabel);
                this.mProductPanel.Controls.Add(this.mProductPictureBox);
                this.mProductPanel.Location = new System.Drawing.Point(xStartPoint, yStartPoint);
                this.mProductPanel.Name = "mProductPanel" + i;
                this.mProductPanel.Size = new System.Drawing.Size(200, 157);
                this.mProductPanel.TabIndex = i + 1;

                // 
                // mProductPictureBox
                // 
                this.mProductPictureBox.Image = Image.FromFile(imagePath);
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
                this.mProductPriceLabel.Location = new System.Drawing.Point(148, 105);
                this.mProductPriceLabel.Name = "mProductPriceLabel";
                this.mProductPriceLabel.Size = new System.Drawing.Size(49, 19);
                this.mProductPriceLabel.TabIndex = i;
                this.mProductPriceLabel.Text = "RM30";

                // 
                // mProductAddButton
                // 
                this.mProductAddButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
                this.mProductAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
                this.mProductAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.mProductAddButton.BorderRadius = 0;
                this.mProductAddButton.ButtonText = "Add To Cart";
                this.mProductAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
                this.mProductAddButton.DisabledColor = System.Drawing.Color.Gray;
                this.mProductAddButton.Iconcolor = System.Drawing.Color.Transparent;
                this.mProductAddButton.Iconimage = null;
                this.mProductAddButton.Iconimage_right = null;
                this.mProductAddButton.Iconimage_right_Selected = null;
                this.mProductAddButton.Iconimage_Selected = null;
                this.mProductAddButton.IconMarginLeft = 0;
                this.mProductAddButton.IconMarginRight = 0;
                this.mProductAddButton.IconRightVisible = true;
                this.mProductAddButton.IconRightZoom = 0D;
                this.mProductAddButton.IconVisible = true;
                this.mProductAddButton.IconZoom = 90D;
                this.mProductAddButton.IsTab = false;
                this.mProductAddButton.Location = new System.Drawing.Point(7, 134);
                this.mProductAddButton.Name = "mProductAddButton";
                this.mProductAddButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
                this.mProductAddButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
                this.mProductAddButton.OnHoverTextColor = System.Drawing.Color.White;
                this.mProductAddButton.selected = false;
                this.mProductAddButton.Size = new System.Drawing.Size(110, 20);
                this.mProductAddButton.TabIndex = 2;
                this.mProductAddButton.Text = "Add To Cart";
                this.mProductAddButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                this.mProductAddButton.Textcolor = System.Drawing.Color.White;
                this.mProductAddButton.TextFont = new System.Drawing.Font("Lato Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                // 
                // mProductNumberPicker
                // 
                this.mProductNumberPicker.Location = new System.Drawing.Point(154, 134);
                this.mProductNumberPicker.Name = "mProductNumberPicker";
                this.mProductNumberPicker.Size = new System.Drawing.Size(42, 20);
                this.mProductNumberPicker.TabIndex = i;


                this.mProductPanel.ResumeLayout(false);
                this.mProductPanel.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.mProductNumberPicker)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.mProductPictureBox)).EndInit();
                this.ResumeLayout(false);


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


            return this.containerPanel;
        }

    }
}
