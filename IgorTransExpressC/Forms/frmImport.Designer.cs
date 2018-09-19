namespace IgorTransExpressC.Forms
{
    partial class frmImport
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
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste spreadsheetCopyPaste1 = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste();
            Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController formulaRangeSelectionController1 = new Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController();
            this.btnOpen = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnExtract = new Syncfusion.Windows.Forms.ButtonAdv();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtCountry = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAdd1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAdd3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAdd2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPostcode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCounty = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel22 = new MaterialSkin.Controls.MaterialLabel();
            this.spreadsheet1 = new Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnOpen.BeforeTouchSize = new System.Drawing.Size(100, 35);
            this.btnOpen.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None;
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.IsBackStageButton = false;
            this.btnOpen.Location = new System.Drawing.Point(1365, 10);
            this.btnOpen.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 35);
            this.btnOpen.TabIndex = 43;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyle = true;
            this.btnOpen.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // btnExtract
            // 
            this.btnExtract.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnExtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnExtract.BeforeTouchSize = new System.Drawing.Size(100, 35);
            this.btnExtract.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None;
            this.btnExtract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtract.ForeColor = System.Drawing.Color.White;
            this.btnExtract.IsBackStageButton = false;
            this.btnExtract.Location = new System.Drawing.Point(1465, 10);
            this.btnExtract.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(100, 35);
            this.btnExtract.TabIndex = 44;
            this.btnExtract.Text = "EXTRACT";
            this.btnExtract.UseVisualStyle = true;
            this.btnExtract.Click += new System.EventHandler(this.buttonAdv2_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(1360, 690);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(430, 190);
            this.listView1.TabIndex = 45;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // txtCountry
            // 
            this.txtCountry.Depth = 0;
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.Hint = "";
            this.txtCountry.Location = new System.Drawing.Point(1480, 240);
            this.txtCountry.MaxLength = 32767;
            this.txtCountry.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.PasswordChar = '\0';
            this.txtCountry.ReadOnly = false;
            this.txtCountry.SelectedText = "";
            this.txtCountry.SelectionLength = 0;
            this.txtCountry.SelectionStart = 0;
            this.txtCountry.Size = new System.Drawing.Size(265, 23);
            this.txtCountry.TabIndex = 61;
            this.txtCountry.TabStop = false;
            this.txtCountry.UseSystemPasswordChar = false;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(1365, 240);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(61, 19);
            this.materialLabel13.TabIndex = 60;
            this.materialLabel13.Text = "Country";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(1365, 90);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(76, 19);
            this.materialLabel14.TabIndex = 48;
            this.materialLabel14.Text = "Address 1";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(1365, 65);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(49, 19);
            this.materialLabel15.TabIndex = 46;
            this.materialLabel15.Text = "Name";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(1365, 115);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(76, 19);
            this.materialLabel16.TabIndex = 51;
            this.materialLabel16.Text = "Address 2";
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel19.Location = new System.Drawing.Point(1365, 140);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(76, 19);
            this.materialLabel19.TabIndex = 53;
            this.materialLabel19.Text = "Address 3";
            // 
            // materialLabel20
            // 
            this.materialLabel20.AutoSize = true;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel20.Location = new System.Drawing.Point(1365, 165);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(56, 19);
            this.materialLabel20.TabIndex = 54;
            this.materialLabel20.Text = "County";
            // 
            // txtName
            // 
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Hint = "";
            this.txtName.Location = new System.Drawing.Point(1480, 65);
            this.txtName.MaxLength = 32767;
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ReadOnly = false;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(315, 23);
            this.txtName.TabIndex = 47;
            this.txtName.TabStop = false;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // txtCity
            // 
            this.txtCity.Depth = 0;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Hint = "";
            this.txtCity.Location = new System.Drawing.Point(1480, 190);
            this.txtCity.MaxLength = 32767;
            this.txtCity.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCity.Name = "txtCity";
            this.txtCity.PasswordChar = '\0';
            this.txtCity.ReadOnly = false;
            this.txtCity.SelectedText = "";
            this.txtCity.SelectionLength = 0;
            this.txtCity.SelectionStart = 0;
            this.txtCity.Size = new System.Drawing.Size(265, 23);
            this.txtCity.TabIndex = 56;
            this.txtCity.TabStop = false;
            this.txtCity.UseSystemPasswordChar = false;
            // 
            // txtAdd1
            // 
            this.txtAdd1.Depth = 0;
            this.txtAdd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd1.Hint = "";
            this.txtAdd1.Location = new System.Drawing.Point(1480, 90);
            this.txtAdd1.MaxLength = 32767;
            this.txtAdd1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.PasswordChar = '\0';
            this.txtAdd1.ReadOnly = false;
            this.txtAdd1.SelectedText = "";
            this.txtAdd1.SelectionLength = 0;
            this.txtAdd1.SelectionStart = 0;
            this.txtAdd1.Size = new System.Drawing.Size(315, 23);
            this.txtAdd1.TabIndex = 49;
            this.txtAdd1.TabStop = false;
            this.txtAdd1.UseSystemPasswordChar = false;
            // 
            // txtAdd3
            // 
            this.txtAdd3.Depth = 0;
            this.txtAdd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd3.Hint = "";
            this.txtAdd3.Location = new System.Drawing.Point(1480, 140);
            this.txtAdd3.MaxLength = 32767;
            this.txtAdd3.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAdd3.Name = "txtAdd3";
            this.txtAdd3.PasswordChar = '\0';
            this.txtAdd3.ReadOnly = false;
            this.txtAdd3.SelectedText = "";
            this.txtAdd3.SelectionLength = 0;
            this.txtAdd3.SelectionStart = 0;
            this.txtAdd3.Size = new System.Drawing.Size(315, 23);
            this.txtAdd3.TabIndex = 52;
            this.txtAdd3.TabStop = false;
            this.txtAdd3.UseSystemPasswordChar = false;
            // 
            // txtAdd2
            // 
            this.txtAdd2.Depth = 0;
            this.txtAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd2.Hint = "";
            this.txtAdd2.Location = new System.Drawing.Point(1480, 115);
            this.txtAdd2.MaxLength = 32767;
            this.txtAdd2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.PasswordChar = '\0';
            this.txtAdd2.ReadOnly = false;
            this.txtAdd2.SelectedText = "";
            this.txtAdd2.SelectionLength = 0;
            this.txtAdd2.SelectionStart = 0;
            this.txtAdd2.Size = new System.Drawing.Size(315, 23);
            this.txtAdd2.TabIndex = 50;
            this.txtAdd2.TabStop = false;
            this.txtAdd2.UseSystemPasswordChar = false;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Depth = 0;
            this.txtPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostcode.Hint = "";
            this.txtPostcode.Location = new System.Drawing.Point(1480, 215);
            this.txtPostcode.MaxLength = 32767;
            this.txtPostcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.PasswordChar = '\0';
            this.txtPostcode.ReadOnly = false;
            this.txtPostcode.SelectedText = "";
            this.txtPostcode.SelectionLength = 0;
            this.txtPostcode.SelectionStart = 0;
            this.txtPostcode.Size = new System.Drawing.Size(265, 23);
            this.txtPostcode.TabIndex = 57;
            this.txtPostcode.TabStop = false;
            this.txtPostcode.UseSystemPasswordChar = false;
            // 
            // materialLabel21
            // 
            this.materialLabel21.AutoSize = true;
            this.materialLabel21.Depth = 0;
            this.materialLabel21.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel21.Location = new System.Drawing.Point(1365, 215);
            this.materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel21.Name = "materialLabel21";
            this.materialLabel21.Size = new System.Drawing.Size(73, 19);
            this.materialLabel21.TabIndex = 59;
            this.materialLabel21.Text = "Postcode";
            // 
            // txtCounty
            // 
            this.txtCounty.Depth = 0;
            this.txtCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounty.Hint = "";
            this.txtCounty.Location = new System.Drawing.Point(1480, 165);
            this.txtCounty.MaxLength = 32767;
            this.txtCounty.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.PasswordChar = '\0';
            this.txtCounty.ReadOnly = false;
            this.txtCounty.SelectedText = "";
            this.txtCounty.SelectionLength = 0;
            this.txtCounty.SelectionStart = 0;
            this.txtCounty.Size = new System.Drawing.Size(315, 23);
            this.txtCounty.TabIndex = 55;
            this.txtCounty.TabStop = false;
            this.txtCounty.UseSystemPasswordChar = false;
            // 
            // materialLabel22
            // 
            this.materialLabel22.AutoSize = true;
            this.materialLabel22.Depth = 0;
            this.materialLabel22.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel22.Location = new System.Drawing.Point(1365, 190);
            this.materialLabel22.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel22.Name = "materialLabel22";
            this.materialLabel22.Size = new System.Drawing.Size(35, 19);
            this.materialLabel22.TabIndex = 58;
            this.materialLabel22.Text = "City";
            // 
            // spreadsheet1
            // 
            this.spreadsheet1.AllowCellContextMenu = true;
            this.spreadsheet1.AllowExtendRowColumnCount = true;
            this.spreadsheet1.AllowFormulaRangeSelection = true;
            this.spreadsheet1.AllowTabItemContextMenu = true;
            this.spreadsheet1.AllowZooming = true;
            spreadsheetCopyPaste1.AllowPasteOptionPopup = true;
            spreadsheetCopyPaste1.DefaultPasteOption = Syncfusion.Windows.Forms.Spreadsheet.PasteOptions.Paste;
            this.spreadsheet1.CopyPaste = spreadsheetCopyPaste1;
            this.spreadsheet1.DefaultColumnCount = 101;
            this.spreadsheet1.DefaultRowCount = 101;
            this.spreadsheet1.DisplayAlerts = true;
            this.spreadsheet1.FileName = "Book1";
            this.spreadsheet1.FormulaBarVisibility = true;
            formulaRangeSelectionController1.AllowMouseSelection = true;
            formulaRangeSelectionController1.AllowSelectionOnEditing = true;
            this.spreadsheet1.FormulaRangeSelectionController = formulaRangeSelectionController1;
            this.spreadsheet1.IsCustomTabItemContextMenuEnabled = false;
            this.spreadsheet1.Location = new System.Drawing.Point(0, 5);
            this.spreadsheet1.Name = "spreadsheet1";
            this.spreadsheet1.SelectedTabIndex = 0;
            this.spreadsheet1.SelectedTabItem = null;
            this.spreadsheet1.ShowBusyIndicator = true;
            this.spreadsheet1.Size = new System.Drawing.Size(1345, 880);
            this.spreadsheet1.TabIndex = 62;
            this.spreadsheet1.TabItemContextMenu = null;
            this.spreadsheet1.Text = "spreadsheet1";
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1803, 893);
            this.Controls.Add(this.spreadsheet1);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.materialLabel13);
            this.Controls.Add(this.materialLabel14);
            this.Controls.Add(this.materialLabel15);
            this.Controls.Add(this.materialLabel16);
            this.Controls.Add(this.materialLabel19);
            this.Controls.Add(this.materialLabel20);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAdd1);
            this.Controls.Add(this.txtAdd3);
            this.Controls.Add(this.txtAdd2);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.materialLabel21);
            this.Controls.Add(this.txtCounty);
            this.Controls.Add(this.materialLabel22);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.btnOpen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImport";
            this.ShowIcon = false;
            this.Text = "frmImport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.Windows.Forms.ButtonAdv btnOpen;
        private Syncfusion.Windows.Forms.ButtonAdv btnExtract;
        private System.Windows.Forms.ListView listView1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCountry;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCity;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAdd1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAdd3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAdd2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPostcode;
        private MaterialSkin.Controls.MaterialLabel materialLabel21;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCounty;
        private MaterialSkin.Controls.MaterialLabel materialLabel22;
        private Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet spreadsheet1;
    }
}