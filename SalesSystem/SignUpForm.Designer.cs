namespace SalesSystem
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.btn_minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_signup = new Bunifu.Framework.UI.BunifuFlatButton();
            this.password_field = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.email_field = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nav = new System.Windows.Forms.Panel();
            this.name_field = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.admin_btn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cashier_btn = new System.Windows.Forms.RadioButton();
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
            // btn_signup
            // 
            this.btn_signup.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_signup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_signup.BorderRadius = 0;
            this.btn_signup.ButtonText = "Sign Up";
            this.btn_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_signup.DisabledColor = System.Drawing.Color.Gray;
            this.btn_signup.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_signup.Iconimage = null;
            this.btn_signup.Iconimage_right = null;
            this.btn_signup.Iconimage_right_Selected = null;
            this.btn_signup.Iconimage_Selected = null;
            this.btn_signup.IconMarginLeft = 0;
            this.btn_signup.IconMarginRight = 0;
            this.btn_signup.IconRightVisible = true;
            this.btn_signup.IconRightZoom = 0D;
            this.btn_signup.IconVisible = true;
            this.btn_signup.IconZoom = 90D;
            this.btn_signup.IsTab = false;
            this.btn_signup.Location = new System.Drawing.Point(95, 425);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_signup.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_signup.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_signup.selected = false;
            this.btn_signup.Size = new System.Drawing.Size(379, 41);
            this.btn_signup.TabIndex = 10;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_signup.Textcolor = System.Drawing.Color.White;
            this.btn_signup.TextFont = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
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
            this.password_field.Location = new System.Drawing.Point(95, 298);
            this.password_field.Margin = new System.Windows.Forms.Padding(4);
            this.password_field.Name = "password_field";
            this.password_field.Size = new System.Drawing.Size(379, 33);
            this.password_field.TabIndex = 8;
            this.password_field.Text = "Password";
            this.password_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.email_field.Location = new System.Drawing.Point(95, 228);
            this.email_field.Margin = new System.Windows.Forms.Padding(4);
            this.email_field.Name = "email_field";
            this.email_field.Size = new System.Drawing.Size(379, 33);
            this.email_field.TabIndex = 9;
            this.email_field.Text = "Email Address";
            this.email_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Log In";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Grocery Home";
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
            this.nav.TabIndex = 5;
            // 
            // name_field
            // 
            this.name_field.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_field.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.name_field.ForeColor = System.Drawing.Color.Gray;
            this.name_field.HintForeColor = System.Drawing.Color.Empty;
            this.name_field.HintText = "";
            this.name_field.isPassword = false;
            this.name_field.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.name_field.LineIdleColor = System.Drawing.Color.Gray;
            this.name_field.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.name_field.LineThickness = 1;
            this.name_field.Location = new System.Drawing.Point(95, 171);
            this.name_field.Margin = new System.Windows.Forms.Padding(4);
            this.name_field.Name = "name_field";
            this.name_field.Size = new System.Drawing.Size(379, 33);
            this.name_field.TabIndex = 9;
            this.name_field.Text = "Full Name";
            this.name_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // admin_btn
            // 
            this.admin_btn.AutoSize = true;
            this.admin_btn.Location = new System.Drawing.Point(95, 389);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(75, 17);
            this.admin_btn.TabIndex = 11;
            this.admin_btn.TabStop = true;
            this.admin_btn.Text = "Supervisor";
            this.admin_btn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Role";
            // 
            // cashier_btn
            // 
            this.cashier_btn.AutoSize = true;
            this.cashier_btn.Location = new System.Drawing.Point(223, 389);
            this.cashier_btn.Name = "cashier_btn";
            this.cashier_btn.Size = new System.Drawing.Size(60, 17);
            this.cashier_btn.TabIndex = 11;
            this.cashier_btn.TabStop = true;
            this.cashier_btn.Text = "Cashier";
            this.cashier_btn.UseVisualStyleBackColor = true;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 488);
            this.Controls.Add(this.cashier_btn);
            this.Controls.Add(this.admin_btn);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.password_field);
            this.Controls.Add(this.name_field);
            this.Controls.Add(this.email_field);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.nav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btn_minimize;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private Bunifu.Framework.UI.BunifuFlatButton btn_signup;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password_field;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email_field;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel nav;
        private Bunifu.Framework.UI.BunifuMaterialTextbox name_field;
        private System.Windows.Forms.RadioButton admin_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton cashier_btn;
    }
}