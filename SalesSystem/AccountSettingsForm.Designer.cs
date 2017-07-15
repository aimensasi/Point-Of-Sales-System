namespace SalesSystem
{
    partial class AccountSettingsForm
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
            this.name = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_new_product = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(49, 65);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(60, 23);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(49, 161);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(55, 23);
            this.email.TabIndex = 0;
            this.email.Text = "Email";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(49, 252);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(90, 23);
            this.password.TabIndex = 0;
            this.password.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(544, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(66, 202);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(544, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(66, 291);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(544, 20);
            this.textBox3.TabIndex = 1;
            // 
            // btn_new_product
            // 
            this.btn_new_product.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_new_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_new_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_new_product.BorderRadius = 4;
            this.btn_new_product.ButtonText = "Save";
            this.btn_new_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new_product.DisabledColor = System.Drawing.Color.Gray;
            this.btn_new_product.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_new_product.Iconimage = null;
            this.btn_new_product.Iconimage_right = null;
            this.btn_new_product.Iconimage_right_Selected = null;
            this.btn_new_product.Iconimage_Selected = null;
            this.btn_new_product.IconMarginLeft = 0;
            this.btn_new_product.IconMarginRight = 0;
            this.btn_new_product.IconRightVisible = true;
            this.btn_new_product.IconRightZoom = 0D;
            this.btn_new_product.IconVisible = true;
            this.btn_new_product.IconZoom = 90D;
            this.btn_new_product.IsTab = false;
            this.btn_new_product.Location = new System.Drawing.Point(443, 369);
            this.btn_new_product.Name = "btn_new_product";
            this.btn_new_product.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_new_product.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_new_product.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_new_product.selected = false;
            this.btn_new_product.Size = new System.Drawing.Size(208, 33);
            this.btn_new_product.TabIndex = 6;
            this.btn_new_product.Text = "Save";
            this.btn_new_product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_new_product.Textcolor = System.Drawing.Color.White;
            this.btn_new_product.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // AccountSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.btn_new_product);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.name);
            this.Name = "AccountSettingsForm";
            this.Size = new System.Drawing.Size(704, 423);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private Bunifu.Framework.UI.BunifuFlatButton btn_new_product;
    }
}
