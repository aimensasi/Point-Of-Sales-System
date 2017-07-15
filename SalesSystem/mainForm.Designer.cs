namespace SalesSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.navbar_left = new System.Windows.Forms.Panel();
            this.tbs_settings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbs_users = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbs_orders = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbs_products = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbs_cashier = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbs_dashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nav = new System.Windows.Forms.Panel();
            this.btn_minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dashboard1 = new SalesSystem.DashboardForm();
            this.products1 = new SalesSystem.ProductForm();
            this.orderForm1 = new SalesSystem.OrderForm();
            this.userForm1 = new SalesSystem.UserForm();
            this.accountSettingsForm1 = new SalesSystem.AccountSettingsForm();
            this.navbar_left.SuspendLayout();
            this.nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navbar_left
            // 
            this.navbar_left.BackColor = System.Drawing.Color.White;
            this.navbar_left.Controls.Add(this.tbs_settings);
            this.navbar_left.Controls.Add(this.tbs_users);
            this.navbar_left.Controls.Add(this.tbs_orders);
            this.navbar_left.Controls.Add(this.tbs_products);
            this.navbar_left.Controls.Add(this.tbs_cashier);
            this.navbar_left.Controls.Add(this.tbs_dashboard);
            this.navbar_left.Controls.Add(this.label1);
            this.navbar_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.navbar_left.Location = new System.Drawing.Point(0, 0);
            this.navbar_left.Name = "navbar_left";
            this.navbar_left.Size = new System.Drawing.Size(191, 461);
            this.navbar_left.TabIndex = 0;
            // 
            // tbs_settings
            // 
            this.tbs_settings.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tbs_settings.BackColor = System.Drawing.Color.White;
            this.tbs_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbs_settings.BorderRadius = 0;
            this.tbs_settings.ButtonText = "    Account Settings";
            this.tbs_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbs_settings.DisabledColor = System.Drawing.Color.Gray;
            this.tbs_settings.Iconcolor = System.Drawing.Color.Transparent;
            this.tbs_settings.Iconimage = ((System.Drawing.Image)(resources.GetObject("tbs_settings.Iconimage")));
            this.tbs_settings.Iconimage_right = null;
            this.tbs_settings.Iconimage_right_Selected = null;
            this.tbs_settings.Iconimage_Selected = null;
            this.tbs_settings.IconMarginLeft = 0;
            this.tbs_settings.IconMarginRight = 0;
            this.tbs_settings.IconRightVisible = true;
            this.tbs_settings.IconRightZoom = 0D;
            this.tbs_settings.IconVisible = true;
            this.tbs_settings.IconZoom = 40D;
            this.tbs_settings.IsTab = true;
            this.tbs_settings.Location = new System.Drawing.Point(0, 327);
            this.tbs_settings.Name = "tbs_settings";
            this.tbs_settings.Normalcolor = System.Drawing.Color.White;
            this.tbs_settings.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tbs_settings.OnHoverTextColor = System.Drawing.Color.Black;
            this.tbs_settings.selected = false;
            this.tbs_settings.Size = new System.Drawing.Size(191, 48);
            this.tbs_settings.TabIndex = 2;
            this.tbs_settings.Text = "    Account Settings";
            this.tbs_settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbs_settings.Textcolor = System.Drawing.Color.Black;
            this.tbs_settings.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbs_settings.Click += new System.EventHandler(this.tbs_settings_Click);
            // 
            // tbs_users
            // 
            this.tbs_users.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tbs_users.BackColor = System.Drawing.Color.White;
            this.tbs_users.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbs_users.BorderRadius = 0;
            this.tbs_users.ButtonText = "    Users";
            this.tbs_users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbs_users.DisabledColor = System.Drawing.Color.Gray;
            this.tbs_users.Iconcolor = System.Drawing.Color.Transparent;
            this.tbs_users.Iconimage = ((System.Drawing.Image)(resources.GetObject("tbs_users.Iconimage")));
            this.tbs_users.Iconimage_right = null;
            this.tbs_users.Iconimage_right_Selected = null;
            this.tbs_users.Iconimage_Selected = null;
            this.tbs_users.IconMarginLeft = 0;
            this.tbs_users.IconMarginRight = 0;
            this.tbs_users.IconRightVisible = true;
            this.tbs_users.IconRightZoom = 0D;
            this.tbs_users.IconVisible = true;
            this.tbs_users.IconZoom = 50D;
            this.tbs_users.IsTab = true;
            this.tbs_users.Location = new System.Drawing.Point(0, 280);
            this.tbs_users.Name = "tbs_users";
            this.tbs_users.Normalcolor = System.Drawing.Color.White;
            this.tbs_users.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tbs_users.OnHoverTextColor = System.Drawing.Color.Black;
            this.tbs_users.selected = false;
            this.tbs_users.Size = new System.Drawing.Size(191, 48);
            this.tbs_users.TabIndex = 2;
            this.tbs_users.Text = "    Users";
            this.tbs_users.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbs_users.Textcolor = System.Drawing.Color.Black;
            this.tbs_users.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbs_users.Click += new System.EventHandler(this.tbs_users_Click);
            // 
            // tbs_orders
            // 
            this.tbs_orders.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tbs_orders.BackColor = System.Drawing.Color.White;
            this.tbs_orders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbs_orders.BorderRadius = 0;
            this.tbs_orders.ButtonText = "    Orders";
            this.tbs_orders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbs_orders.DisabledColor = System.Drawing.Color.Gray;
            this.tbs_orders.Iconcolor = System.Drawing.Color.Transparent;
            this.tbs_orders.Iconimage = ((System.Drawing.Image)(resources.GetObject("tbs_orders.Iconimage")));
            this.tbs_orders.Iconimage_right = null;
            this.tbs_orders.Iconimage_right_Selected = null;
            this.tbs_orders.Iconimage_Selected = null;
            this.tbs_orders.IconMarginLeft = 0;
            this.tbs_orders.IconMarginRight = 0;
            this.tbs_orders.IconRightVisible = true;
            this.tbs_orders.IconRightZoom = 0D;
            this.tbs_orders.IconVisible = true;
            this.tbs_orders.IconZoom = 50D;
            this.tbs_orders.IsTab = true;
            this.tbs_orders.Location = new System.Drawing.Point(0, 233);
            this.tbs_orders.Name = "tbs_orders";
            this.tbs_orders.Normalcolor = System.Drawing.Color.White;
            this.tbs_orders.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tbs_orders.OnHoverTextColor = System.Drawing.Color.Black;
            this.tbs_orders.selected = false;
            this.tbs_orders.Size = new System.Drawing.Size(191, 48);
            this.tbs_orders.TabIndex = 2;
            this.tbs_orders.Text = "    Orders";
            this.tbs_orders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbs_orders.Textcolor = System.Drawing.Color.Black;
            this.tbs_orders.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbs_orders.Click += new System.EventHandler(this.tbs_orders_Click);
            // 
            // tbs_products
            // 
            this.tbs_products.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tbs_products.BackColor = System.Drawing.Color.White;
            this.tbs_products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbs_products.BorderRadius = 0;
            this.tbs_products.ButtonText = "    Products";
            this.tbs_products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbs_products.DisabledColor = System.Drawing.Color.Gray;
            this.tbs_products.Iconcolor = System.Drawing.Color.Transparent;
            this.tbs_products.Iconimage = ((System.Drawing.Image)(resources.GetObject("tbs_products.Iconimage")));
            this.tbs_products.Iconimage_right = null;
            this.tbs_products.Iconimage_right_Selected = null;
            this.tbs_products.Iconimage_Selected = null;
            this.tbs_products.IconMarginLeft = 0;
            this.tbs_products.IconMarginRight = 0;
            this.tbs_products.IconRightVisible = true;
            this.tbs_products.IconRightZoom = 0D;
            this.tbs_products.IconVisible = true;
            this.tbs_products.IconZoom = 50D;
            this.tbs_products.IsTab = true;
            this.tbs_products.Location = new System.Drawing.Point(0, 186);
            this.tbs_products.Name = "tbs_products";
            this.tbs_products.Normalcolor = System.Drawing.Color.White;
            this.tbs_products.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tbs_products.OnHoverTextColor = System.Drawing.Color.Black;
            this.tbs_products.selected = false;
            this.tbs_products.Size = new System.Drawing.Size(191, 48);
            this.tbs_products.TabIndex = 2;
            this.tbs_products.Text = "    Products";
            this.tbs_products.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbs_products.Textcolor = System.Drawing.Color.Black;
            this.tbs_products.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbs_products.Click += new System.EventHandler(this.tbs_product_click);
            // 
            // tbs_cashier
            // 
            this.tbs_cashier.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tbs_cashier.BackColor = System.Drawing.Color.White;
            this.tbs_cashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbs_cashier.BorderRadius = 0;
            this.tbs_cashier.ButtonText = "    Cashier";
            this.tbs_cashier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbs_cashier.DisabledColor = System.Drawing.Color.Gray;
            this.tbs_cashier.Iconcolor = System.Drawing.Color.Transparent;
            this.tbs_cashier.Iconimage = ((System.Drawing.Image)(resources.GetObject("tbs_cashier.Iconimage")));
            this.tbs_cashier.Iconimage_right = null;
            this.tbs_cashier.Iconimage_right_Selected = null;
            this.tbs_cashier.Iconimage_Selected = null;
            this.tbs_cashier.IconMarginLeft = 0;
            this.tbs_cashier.IconMarginRight = 0;
            this.tbs_cashier.IconRightVisible = true;
            this.tbs_cashier.IconRightZoom = 0D;
            this.tbs_cashier.IconVisible = true;
            this.tbs_cashier.IconZoom = 50D;
            this.tbs_cashier.IsTab = true;
            this.tbs_cashier.Location = new System.Drawing.Point(0, 139);
            this.tbs_cashier.Name = "tbs_cashier";
            this.tbs_cashier.Normalcolor = System.Drawing.Color.White;
            this.tbs_cashier.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tbs_cashier.OnHoverTextColor = System.Drawing.Color.Black;
            this.tbs_cashier.selected = false;
            this.tbs_cashier.Size = new System.Drawing.Size(191, 48);
            this.tbs_cashier.TabIndex = 2;
            this.tbs_cashier.Text = "    Cashier";
            this.tbs_cashier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbs_cashier.Textcolor = System.Drawing.Color.Black;
            this.tbs_cashier.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tbs_dashboard
            // 
            this.tbs_dashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tbs_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tbs_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbs_dashboard.BorderRadius = 0;
            this.tbs_dashboard.ButtonText = "    Dashboard";
            this.tbs_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbs_dashboard.DisabledColor = System.Drawing.Color.Gray;
            this.tbs_dashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.tbs_dashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("tbs_dashboard.Iconimage")));
            this.tbs_dashboard.Iconimage_right = null;
            this.tbs_dashboard.Iconimage_right_Selected = null;
            this.tbs_dashboard.Iconimage_Selected = null;
            this.tbs_dashboard.IconMarginLeft = 0;
            this.tbs_dashboard.IconMarginRight = 0;
            this.tbs_dashboard.IconRightVisible = true;
            this.tbs_dashboard.IconRightZoom = 0D;
            this.tbs_dashboard.IconVisible = true;
            this.tbs_dashboard.IconZoom = 50D;
            this.tbs_dashboard.IsTab = true;
            this.tbs_dashboard.Location = new System.Drawing.Point(0, 92);
            this.tbs_dashboard.Name = "tbs_dashboard";
            this.tbs_dashboard.Normalcolor = System.Drawing.Color.White;
            this.tbs_dashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tbs_dashboard.OnHoverTextColor = System.Drawing.Color.Black;
            this.tbs_dashboard.selected = true;
            this.tbs_dashboard.Size = new System.Drawing.Size(191, 48);
            this.tbs_dashboard.TabIndex = 2;
            this.tbs_dashboard.Text = "    Dashboard";
            this.tbs_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbs_dashboard.Textcolor = System.Drawing.Color.Black;
            this.tbs_dashboard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbs_dashboard.Click += new System.EventHandler(this.tbs_dashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Light", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grocery Home";
            // 
            // nav
            // 
            this.nav.BackColor = System.Drawing.Color.White;
            this.nav.Controls.Add(this.btn_minimize);
            this.nav.Controls.Add(this.btn_close);
            this.nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav.Location = new System.Drawing.Point(191, 0);
            this.nav.Name = "nav";
            this.nav.Size = new System.Drawing.Size(704, 38);
            this.nav.TabIndex = 1;
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.White;
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.ImageActive = null;
            this.btn_minimize.Location = new System.Drawing.Point(632, 9);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(20, 20);
            this.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimize.TabIndex = 0;
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
            this.btn_close.Location = new System.Drawing.Point(666, 8);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(20, 20);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 0;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dashboard1);
            this.panel1.Controls.Add(this.products1);
            this.panel1.Controls.Add(this.orderForm1);
            this.panel1.Controls.Add(this.userForm1);
            this.panel1.Controls.Add(this.accountSettingsForm1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(191, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 423);
            this.panel1.TabIndex = 2;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(704, 423);
            this.dashboard1.TabIndex = 0;
            // 
            // products1
            // 
            this.products1.Location = new System.Drawing.Point(0, 0);
            this.products1.Name = "products1";
            this.products1.Size = new System.Drawing.Size(704, 423);
            this.products1.TabIndex = 1;
            this.products1.Visible = false;
            // 
            // orderForm1
            // 
            this.orderForm1.Location = new System.Drawing.Point(0, 0);
            this.orderForm1.Name = "orderForm1";
            this.orderForm1.Size = new System.Drawing.Size(704, 423);
            this.orderForm1.TabIndex = 2;
            // 
            // userForm1
            // 
            this.userForm1.Location = new System.Drawing.Point(0, 0);
            this.userForm1.Name = "userForm1";
            this.userForm1.Size = new System.Drawing.Size(704, 423);
            this.userForm1.TabIndex = 3;
            this.userForm1.Visible = false;
            // 
            // accountSettingsForm1
            // 
            this.accountSettingsForm1.Location = new System.Drawing.Point(0, 0);
            this.accountSettingsForm1.Name = "accountSettingsForm1";
            this.accountSettingsForm1.Size = new System.Drawing.Size(704, 423);
            this.accountSettingsForm1.TabIndex = 4;
            this.accountSettingsForm1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nav);
            this.Controls.Add(this.navbar_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "s";
            this.navbar_left.ResumeLayout(false);
            this.navbar_left.PerformLayout();
            this.nav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navbar_left;
        private System.Windows.Forms.Panel nav;
        private Bunifu.Framework.UI.BunifuImageButton btn_minimize;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private Bunifu.Framework.UI.BunifuFlatButton tbs_dashboard;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton tbs_settings;
        private Bunifu.Framework.UI.BunifuFlatButton tbs_users;
        private Bunifu.Framework.UI.BunifuFlatButton tbs_orders;
        private Bunifu.Framework.UI.BunifuFlatButton tbs_products;
        private Bunifu.Framework.UI.BunifuFlatButton tbs_cashier;
        private System.Windows.Forms.Panel panel1;
        private DashboardForm dashboard1;
        private ProductForm products1;
        private OrderForm orderForm1;
        private UserForm userForm1;
        private AccountSettingsForm accountSettingsForm1;

    }
}

