namespace SalesSystem
{
    partial class LogInForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.btn_minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.nav = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.email_field = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.password_field = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_login = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.White;
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.ImageActive = null;
            this.btn_minimize.Location = new System.Drawing.Point(525, 12);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(20, 20);
            this.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimize.TabIndex = 1;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.Zoom = 10;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageActive = null;
            this.btn_close.Location = new System.Drawing.Point(552, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(20, 20);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 2;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            // 
            // nav
            // 
            this.nav.BackColor = System.Drawing.Color.White;
            this.nav.Controls.Add(this.btn_minimize);
            this.nav.Controls.Add(this.btn_close);
            this.nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav.Location = new System.Drawing.Point(0, 0);
            this.nav.Name = "nav";
            this.nav.Size = new System.Drawing.Size(584, 38);
            this.nav.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grocery Home";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Log In";
            // 
            // email_field
            // 
            this.email_field.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_field.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.email_field.ForeColor = System.Drawing.Color.Gray;
            this.email_field.HintForeColor = System.Drawing.Color.Empty;
            this.email_field.HintText = "";
            this.email_field.isPassword = false;
            this.email_field.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.email_field.LineIdleColor = System.Drawing.Color.Gray;
            this.email_field.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.email_field.LineThickness = 1;
            this.email_field.Location = new System.Drawing.Point(95, 189);
            this.email_field.Margin = new System.Windows.Forms.Padding(4);
            this.email_field.Name = "email_field";
            this.email_field.Size = new System.Drawing.Size(379, 33);
            this.email_field.TabIndex = 3;
            this.email_field.Text = "Email Address";
            this.email_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // password_field
            // 
            this.password_field.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_field.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password_field.ForeColor = System.Drawing.Color.Gray;
            this.password_field.HintForeColor = System.Drawing.Color.Empty;
            this.password_field.HintText = "";
            this.password_field.isPassword = true;
            this.password_field.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.password_field.LineIdleColor = System.Drawing.Color.Gray;
            this.password_field.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.password_field.LineThickness = 1;
            this.password_field.Location = new System.Drawing.Point(95, 259);
            this.password_field.Margin = new System.Windows.Forms.Padding(4);
            this.password_field.Name = "password_field";
            this.password_field.Size = new System.Drawing.Size(379, 33);
            this.password_field.TabIndex = 3;
            this.password_field.Text = "Password";
            this.password_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_login
            // 
            this.btn_login.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.BorderRadius = 0;
            this.btn_login.ButtonText = "Log In";
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.DisabledColor = System.Drawing.Color.Gray;
            this.btn_login.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_login.Iconimage = null;
            this.btn_login.Iconimage_right = null;
            this.btn_login.Iconimage_right_Selected = null;
            this.btn_login.Iconimage_Selected = null;
            this.btn_login.IconMarginLeft = 0;
            this.btn_login.IconMarginRight = 0;
            this.btn_login.IconRightVisible = true;
            this.btn_login.IconRightZoom = 0D;
            this.btn_login.IconVisible = true;
            this.btn_login.IconZoom = 90D;
            this.btn_login.IsTab = false;
            this.btn_login.Location = new System.Drawing.Point(95, 341);
            this.btn_login.Name = "btn_login";
            this.btn_login.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_login.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_login.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_login.selected = false;
            this.btn_login.Size = new System.Drawing.Size(379, 41);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Log In";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login.Textcolor = System.Drawing.Color.White;
            this.btn_login.TextFont = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.password_field);
            this.Controls.Add(this.email_field);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInForm";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.nav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btn_minimize;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private System.Windows.Forms.Panel nav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email_field;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password_field;
        private Bunifu.Framework.UI.BunifuFlatButton btn_login;
    }
}