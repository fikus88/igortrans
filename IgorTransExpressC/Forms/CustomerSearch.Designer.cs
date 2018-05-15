namespace IgorTransExpressC
{
    partial class CustomerSearch
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
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField18 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(10, 20);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(55, 19);
            this.materialLabel14.TabIndex = 2;
            this.materialLabel14.Text = "Search";
            // 
            // materialSingleLineTextField18
            // 
            this.materialSingleLineTextField18.Depth = 0;
            this.materialSingleLineTextField18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialSingleLineTextField18.Hint = "";
            this.materialSingleLineTextField18.Location = new System.Drawing.Point(85, 20);
            this.materialSingleLineTextField18.MaxLength = 32767;
            this.materialSingleLineTextField18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField18.Name = "materialSingleLineTextField18";
            this.materialSingleLineTextField18.PasswordChar = '\0';
            this.materialSingleLineTextField18.ReadOnly = false;
            this.materialSingleLineTextField18.SelectedText = "";
            this.materialSingleLineTextField18.SelectionLength = 0;
            this.materialSingleLineTextField18.SelectionStart = 0;
            this.materialSingleLineTextField18.Size = new System.Drawing.Size(390, 23);
            this.materialSingleLineTextField18.TabIndex = 3;
            this.materialSingleLineTextField18.TabStop = false;
            this.materialSingleLineTextField18.UseSystemPasswordChar = false;
            this.materialSingleLineTextField18.TextChanged += new System.EventHandler(materialSingleLineTextField18_TextChanged);
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.Gainsboro;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.FullRowSelect = true;
            this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(10, 55);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(465, 340);
            this.listView2.TabIndex = 48;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.DoubleClick += ListView2_DoubleClick;
            this.listView2.KeyDown += ClickEnter;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Account";
            this.columnHeader1.Width = 113;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.listView2);
            this.panel1.Controls.Add(this.materialLabel14);
            this.panel1.Controls.Add(this.materialSingleLineTextField18);
            this.panel1.Location = new System.Drawing.Point(5, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 400);
            this.panel1.TabIndex = 35;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 333;
            // 
            // CustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 417);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerSearch";
            this.ShowIcon = false;
            this.Text = "CustomerSearch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);




        }

      

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField18;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel1;
    }
}