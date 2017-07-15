namespace SalesSystem
{
    partial class UserForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_update_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_new_product = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_name,
            this.col_email,
            this.col_role,
            this.col_created_at,
            this.col_update_at});
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(15, 81);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(672, 302);
            this.bunifuCustomDataGrid1.TabIndex = 3;
            // 
            // col_id
            // 
            this.col_id.HeaderText = "ID";
            this.col_id.Name = "col_id";
            this.col_id.Width = 80;
            // 
            // col_name
            // 
            this.col_name.HeaderText = "Name";
            this.col_name.Name = "col_name";
            // 
            // col_email
            // 
            this.col_email.HeaderText = "Email Address";
            this.col_email.Name = "col_email";
            this.col_email.Width = 140;
            // 
            // col_role
            // 
            this.col_role.HeaderText = "Role";
            this.col_role.Name = "col_role";
            this.col_role.Width = 90;
            // 
            // col_created_at
            // 
            this.col_created_at.HeaderText = "Join Date";
            this.col_created_at.Name = "col_created_at";
            // 
            // col_update_at
            // 
            this.col_update_at.HeaderText = "Last Update";
            this.col_update_at.Name = "col_update_at";
            this.col_update_at.Width = 120;
            // 
            // btn_new_product
            // 
            this.btn_new_product.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_new_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_new_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_new_product.BorderRadius = 4;
            this.btn_new_product.ButtonText = "Add New User";
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
            this.btn_new_product.Location = new System.Drawing.Point(465, 20);
            this.btn_new_product.Name = "btn_new_product";
            this.btn_new_product.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_new_product.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.btn_new_product.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_new_product.selected = false;
            this.btn_new_product.Size = new System.Drawing.Size(222, 44);
            this.btn_new_product.TabIndex = 5;
            this.btn_new_product.Text = "Add New User";
            this.btn_new_product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_new_product.Textcolor = System.Drawing.Color.White;
            this.btn_new_product.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_product.Click += new System.EventHandler(this.btn_new_product_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.btn_new_product);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Name = "UserForm";
            this.Size = new System.Drawing.Size(704, 423);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_role;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_update_at;
        private Bunifu.Framework.UI.BunifuFlatButton btn_new_product;
    }
}
