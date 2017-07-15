namespace SalesSystem
{
    partial class CreateProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProductForm));
            this.navbar = new System.Windows.Forms.Panel();
            this.btn_minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_file = new Bunifu.Framework.UI.BunifuFlatButton();
            this.name_field = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.price_field = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.category_field = new Bunifu.Framework.UI.BunifuDropdown();
            this.stock_level_field = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.date_field = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_create = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_cancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.navbar.TabIndex = 1;
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_file
            // 
            this.btn_file.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_file.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_file.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_file.BorderRadius = 5;
            this.btn_file.ButtonText = "   Upload Image";
            this.btn_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_file.DisabledColor = System.Drawing.Color.Gray;
            this.btn_file.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_file.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_file.Iconimage")));
            this.btn_file.Iconimage_right = null;
            this.btn_file.Iconimage_right_Selected = null;
            this.btn_file.Iconimage_Selected = null;
            this.btn_file.IconMarginLeft = 0;
            this.btn_file.IconMarginRight = 0;
            this.btn_file.IconRightVisible = true;
            this.btn_file.IconRightZoom = 0D;
            this.btn_file.IconVisible = true;
            this.btn_file.IconZoom = 60D;
            this.btn_file.IsTab = false;
            this.btn_file.Location = new System.Drawing.Point(30, 176);
            this.btn_file.Name = "btn_file";
            this.btn_file.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_file.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_file.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_file.selected = false;
            this.btn_file.Size = new System.Drawing.Size(172, 38);
            this.btn_file.TabIndex = 3;
            this.btn_file.Text = "   Upload Image";
            this.btn_file.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_file.Textcolor = System.Drawing.Color.White;
            this.btn_file.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // name_field
            // 
            this.name_field.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_field.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.name_field.ForeColor = System.Drawing.Color.Black;
            this.name_field.HintForeColor = System.Drawing.Color.Empty;
            this.name_field.HintText = "";
            this.name_field.isPassword = false;
            this.name_field.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(71)))), ((int)(((byte)(75)))));
            this.name_field.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.name_field.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(71)))), ((int)(((byte)(75)))));
            this.name_field.LineThickness = 3;
            this.name_field.Location = new System.Drawing.Point(233, 125);
            this.name_field.Margin = new System.Windows.Forms.Padding(4);
            this.name_field.Name = "name_field";
            this.name_field.Size = new System.Drawing.Size(430, 33);
            this.name_field.TabIndex = 5;
            this.name_field.Text = "Product Name";
            this.name_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // price_field
            // 
            this.price_field.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.price_field.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.price_field.ForeColor = System.Drawing.Color.Black;
            this.price_field.HintForeColor = System.Drawing.Color.Empty;
            this.price_field.HintText = "";
            this.price_field.isPassword = false;
            this.price_field.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(71)))), ((int)(((byte)(75)))));
            this.price_field.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.price_field.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(71)))), ((int)(((byte)(75)))));
            this.price_field.LineThickness = 3;
            this.price_field.Location = new System.Drawing.Point(30, 272);
            this.price_field.Margin = new System.Windows.Forms.Padding(4);
            this.price_field.Name = "price_field";
            this.price_field.Size = new System.Drawing.Size(145, 33);
            this.price_field.TabIndex = 5;
            this.price_field.Text = "Price";
            this.price_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // category_field
            // 
            this.category_field.BackColor = System.Drawing.Color.Transparent;
            this.category_field.BorderRadius = 3;
            this.category_field.DisabledColor = System.Drawing.Color.Gray;
            this.category_field.ForeColor = System.Drawing.Color.White;
            this.category_field.Items = new string[] {
        "Category",
        "Standard Rate (6%)",
        "Zero Rate (0%) "};
            this.category_field.Location = new System.Drawing.Point(195, 272);
            this.category_field.Name = "category_field";
            this.category_field.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.category_field.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.category_field.selectedIndex = 0;
            this.category_field.Size = new System.Drawing.Size(167, 33);
            this.category_field.TabIndex = 7;
            // 
            // stock_level_field
            // 
            this.stock_level_field.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stock_level_field.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.stock_level_field.ForeColor = System.Drawing.Color.Black;
            this.stock_level_field.HintForeColor = System.Drawing.Color.Empty;
            this.stock_level_field.HintText = "";
            this.stock_level_field.isPassword = false;
            this.stock_level_field.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(71)))), ((int)(((byte)(75)))));
            this.stock_level_field.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.stock_level_field.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(71)))), ((int)(((byte)(75)))));
            this.stock_level_field.LineThickness = 3;
            this.stock_level_field.Location = new System.Drawing.Point(382, 272);
            this.stock_level_field.Margin = new System.Windows.Forms.Padding(4);
            this.stock_level_field.Name = "stock_level_field";
            this.stock_level_field.Size = new System.Drawing.Size(112, 33);
            this.stock_level_field.TabIndex = 5;
            this.stock_level_field.Text = "Stock Level";
            this.stock_level_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // date_field
            // 
            this.date_field.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.date_field.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.date_field.ForeColor = System.Drawing.Color.Black;
            this.date_field.HintForeColor = System.Drawing.Color.Empty;
            this.date_field.HintText = "";
            this.date_field.isPassword = false;
            this.date_field.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(71)))), ((int)(((byte)(75)))));
            this.date_field.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.date_field.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(71)))), ((int)(((byte)(75)))));
            this.date_field.LineThickness = 3;
            this.date_field.Location = new System.Drawing.Point(518, 272);
            this.date_field.Margin = new System.Windows.Forms.Padding(4);
            this.date_field.Name = "date_field";
            this.date_field.Size = new System.Drawing.Size(145, 33);
            this.date_field.TabIndex = 5;
            this.date_field.Text = "Experation Date";
            this.date_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_create
            // 
            this.btn_create.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_create.BorderRadius = 0;
            this.btn_create.ButtonText = "Create";
            this.btn_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create.DisabledColor = System.Drawing.Color.Gray;
            this.btn_create.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_create.Iconimage = null;
            this.btn_create.Iconimage_right = null;
            this.btn_create.Iconimage_right_Selected = null;
            this.btn_create.Iconimage_Selected = null;
            this.btn_create.IconMarginLeft = 0;
            this.btn_create.IconMarginRight = 0;
            this.btn_create.IconRightVisible = true;
            this.btn_create.IconRightZoom = 0D;
            this.btn_create.IconVisible = true;
            this.btn_create.IconZoom = 90D;
            this.btn_create.IsTab = false;
            this.btn_create.Location = new System.Drawing.Point(488, 364);
            this.btn_create.Name = "btn_create";
            this.btn_create.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_create.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_create.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_create.selected = false;
            this.btn_create.Size = new System.Drawing.Size(175, 35);
            this.btn_create.TabIndex = 8;
            this.btn_create.Text = "Create";
            this.btn_create.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_create.Textcolor = System.Drawing.Color.White;
            this.btn_create.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Activecolor = System.Drawing.Color.Transparent;
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.BorderRadius = 0;
            this.btn_cancel.ButtonText = "Cancel";
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.DisabledColor = System.Drawing.Color.Gray;
            this.btn_cancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cancel.Iconimage = null;
            this.btn_cancel.Iconimage_right = null;
            this.btn_cancel.Iconimage_right_Selected = null;
            this.btn_cancel.Iconimage_Selected = null;
            this.btn_cancel.IconMarginLeft = 0;
            this.btn_cancel.IconMarginRight = 0;
            this.btn_cancel.IconRightVisible = true;
            this.btn_cancel.IconRightZoom = 0D;
            this.btn_cancel.IconVisible = true;
            this.btn_cancel.IconZoom = 90D;
            this.btn_cancel.IsTab = false;
            this.btn_cancel.Location = new System.Drawing.Point(314, 364);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_cancel.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_cancel.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(95)))));
            this.btn_cancel.selected = false;
            this.btn_cancel.Size = new System.Drawing.Size(175, 35);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(95)))));
            this.btn_cancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CreateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(704, 423);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.category_field);
            this.Controls.Add(this.date_field);
            this.Controls.Add(this.stock_level_field);
            this.Controls.Add(this.price_field);
            this.Controls.Add(this.name_field);
            this.Controls.Add(this.btn_file);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.navbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateProductForm";
            this.Text = "CreateProductForm";
            this.navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navbar;
        private Bunifu.Framework.UI.BunifuImageButton btn_minimize;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_file;
        private Bunifu.Framework.UI.BunifuMaterialTextbox name_field;
        private Bunifu.Framework.UI.BunifuMaterialTextbox price_field;
        private Bunifu.Framework.UI.BunifuDropdown category_field;
        private Bunifu.Framework.UI.BunifuMaterialTextbox stock_level_field;
        private Bunifu.Framework.UI.BunifuMaterialTextbox date_field;
        private Bunifu.Framework.UI.BunifuFlatButton btn_create;
        private Bunifu.Framework.UI.BunifuFlatButton btn_cancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}