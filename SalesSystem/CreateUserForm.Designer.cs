namespace SalesSystem
{
    partial class CreateUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUserForm));
            this.navbar = new System.Windows.Forms.Panel();
            this.btn_minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_create_user = new Bunifu.Framework.UI.BunifuFlatButton();
            this.name_field = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.email_field = new System.Windows.Forms.TextBox();
            this.password_field = new System.Windows.Forms.TextBox();
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.White;
            this.navbar.Controls.Add(this.btn_minimize);
            this.navbar.Controls.Add(this.btn_close);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(704, 36);
            this.navbar.TabIndex = 0;
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.White;
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.ImageActive = null;
            this.btn_minimize.Location = new System.Drawing.Point(620, 10);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(20, 20);
            this.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimize.TabIndex = 1;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.Zoom = 10;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageActive = null;
            this.btn_close.Location = new System.Drawing.Point(656, 10);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(20, 20);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 2;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create New User";
            // 
            // btn_create_user
            // 
            this.btn_create_user.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_create_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_create_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_create_user.BorderRadius = 4;
            this.btn_create_user.ButtonText = "Create";
            this.btn_create_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create_user.DisabledColor = System.Drawing.Color.Gray;
            this.btn_create_user.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_create_user.Iconimage = null;
            this.btn_create_user.Iconimage_right = null;
            this.btn_create_user.Iconimage_right_Selected = null;
            this.btn_create_user.Iconimage_Selected = null;
            this.btn_create_user.IconMarginLeft = 0;
            this.btn_create_user.IconMarginRight = 0;
            this.btn_create_user.IconRightVisible = true;
            this.btn_create_user.IconRightZoom = 0D;
            this.btn_create_user.IconVisible = true;
            this.btn_create_user.IconZoom = 90D;
            this.btn_create_user.IsTab = false;
            this.btn_create_user.Location = new System.Drawing.Point(177, 312);
            this.btn_create_user.Name = "btn_create_user";
            this.btn_create_user.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_create_user.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_create_user.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_create_user.selected = false;
            this.btn_create_user.Size = new System.Drawing.Size(348, 27);
            this.btn_create_user.TabIndex = 13;
            this.btn_create_user.Text = "Create";
            this.btn_create_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_create_user.Textcolor = System.Drawing.Color.White;
            this.btn_create_user.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_user.Click += new System.EventHandler(this.btn_create_user_Click);
            // 
            // name_field
            // 
            this.name_field.Location = new System.Drawing.Point(177, 129);
            this.name_field.Name = "name_field";
            this.name_field.Size = new System.Drawing.Size(348, 20);
            this.name_field.TabIndex = 12;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(174, 227);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(63, 16);
            this.password.TabIndex = 7;
            this.password.Text = "Password";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(174, 167);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(39, 16);
            this.email.TabIndex = 8;
            this.email.Text = "Email";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(174, 103);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(42, 16);
            this.name.TabIndex = 9;
            this.name.Text = "Name";
            // 
            // email_field
            // 
            this.email_field.Location = new System.Drawing.Point(177, 191);
            this.email_field.Name = "email_field";
            this.email_field.Size = new System.Drawing.Size(348, 20);
            this.email_field.TabIndex = 12;
            // 
            // password_field
            // 
            this.password_field.Location = new System.Drawing.Point(177, 250);
            this.password_field.Name = "password_field";
            this.password_field.PasswordChar = 'a';
            this.password_field.Size = new System.Drawing.Size(348, 20);
            this.password_field.TabIndex = 12;
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(704, 423);
            this.Controls.Add(this.btn_create_user);
            this.Controls.Add(this.password_field);
            this.Controls.Add(this.email_field);
            this.Controls.Add(this.name_field);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateUserForm";
            this.Text = "CreateUser";
            this.navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel navbar;
        private Bunifu.Framework.UI.BunifuImageButton btn_minimize;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_create_user;
        private System.Windows.Forms.TextBox name_field;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox email_field;
        private System.Windows.Forms.TextBox password_field;
    }
}