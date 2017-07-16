using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace SalesSystem
{
    partial class CashierUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btn_checkout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.AutoScroll = true;
            this.panelContainer.Location = new System.Drawing.Point(12, 8);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.panelContainer.Size = new System.Drawing.Size(678, 336);
            this.panelContainer.TabIndex = 0;
            // 
            // btn_checkout
            // 
            this.btn_checkout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_checkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_checkout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_checkout.BorderRadius = 0;
            this.btn_checkout.ButtonText = "Checkout ";
            this.btn_checkout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_checkout.DisabledColor = System.Drawing.Color.Gray;
            this.btn_checkout.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_checkout.Iconimage = null;
            this.btn_checkout.Iconimage_right = null;
            this.btn_checkout.Iconimage_right_Selected = null;
            this.btn_checkout.Iconimage_Selected = null;
            this.btn_checkout.IconMarginLeft = 0;
            this.btn_checkout.IconMarginRight = 0;
            this.btn_checkout.IconRightVisible = true;
            this.btn_checkout.IconRightZoom = 0D;
            this.btn_checkout.IconVisible = true;
            this.btn_checkout.IconZoom = 90D;
            this.btn_checkout.IsTab = false;
            this.btn_checkout.Location = new System.Drawing.Point(520, 374);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_checkout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_checkout.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_checkout.selected = false;
            this.btn_checkout.Size = new System.Drawing.Size(170, 32);
            this.btn_checkout.TabIndex = 1;
            this.btn_checkout.Text = "Checkout ";
            this.btn_checkout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_checkout.Textcolor = System.Drawing.Color.White;
            this.btn_checkout.TextFont = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // CashierUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.panelContainer);
            this.Name = "CashierUserControl";
            this.Size = new System.Drawing.Size(704, 423);
            this.Load += new System.EventHandler(this.CashierUserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelContainer;
        private Bunifu.Framework.UI.BunifuFlatButton btn_checkout;

        
    }
}
