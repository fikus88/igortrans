#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace IgorTransExpressC
{
    partial class Invoice_Template
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
            Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings pdfViewerPrinterSettings1 = new Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice_Template));
            this.pdfDocumentView1 = new Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.panel3 = new System.Windows.Forms.Panel();
            this.trackBarEx13 = new Syncfusion.Windows.Forms.Tools.TrackBarEx(0, 10);
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.trackBarEx14 = new Syncfusion.Windows.Forms.Tools.TrackBarEx(0, 10);
            this.trackBarEx5 = new Syncfusion.Windows.Forms.Tools.TrackBarEx(0, 10);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBarEx6 = new Syncfusion.Windows.Forms.Tools.TrackBarEx(0, 10);
            this.materialSingleLineTextField18 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdfDocumentView1
            // 
            this.pdfDocumentView1.AutoScroll = true;
            this.pdfDocumentView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.pdfDocumentView1.Location = new System.Drawing.Point(556, 3);
            this.pdfDocumentView1.Name = "pdfDocumentView1";
            this.pdfDocumentView1.PageBorderThickness = 1;
            pdfViewerPrinterSettings1.PrintLocation = ((System.Drawing.PointF)(resources.GetObject("pdfViewerPrinterSettings1.PrintLocation")));
            this.pdfDocumentView1.PrinterSettings = pdfViewerPrinterSettings1;
            this.pdfDocumentView1.ScrollDisplacementValue = 0;
            this.pdfDocumentView1.ShowHorizontalScrollBar = true;
            this.pdfDocumentView1.ShowVerticalScrollBar = true;
            this.pdfDocumentView1.Size = new System.Drawing.Size(585, 704);
            this.pdfDocumentView1.TabIndex = 0;
            this.pdfDocumentView1.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.Default;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(945, 3);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(43, 19);
            this.materialLabel5.TabIndex = 30;
            this.materialLabel5.Text = "Logo";
            this.materialLabel5.Visible = false;
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabControlAdv1.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(480, 558);
            this.tabControlAdv1.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.FixedSingleBorderColor = System.Drawing.Color.Silver;
            this.tabControlAdv1.FocusOnTabClick = false;
            this.tabControlAdv1.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Location = new System.Drawing.Point(70, 59);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabControlAdv1.ShowSeparator = false;
            this.tabControlAdv1.Size = new System.Drawing.Size(480, 558);
            this.tabControlAdv1.TabIndex = 43;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.AutoScroll = true;
            this.tabPageAdv1.Controls.Add(this.panel3);
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 22);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(477, 534);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "Location and Size";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.materialSingleLineTextField18);
            this.panel3.Controls.Add(this.trackBarEx13);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.trackBarEx14);
            this.panel3.Controls.Add(this.trackBarEx5);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.trackBarEx6);
            this.panel3.Location = new System.Drawing.Point(9, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 124);
            this.panel3.TabIndex = 47;
            // 
            // trackBarEx13
            // 
            this.trackBarEx13.BackColor = System.Drawing.Color.White;
            this.trackBarEx13.BeforeTouchSize = new System.Drawing.Size(179, 20);
            this.trackBarEx13.ForeColor = System.Drawing.Color.Gray;
            this.trackBarEx13.Location = new System.Drawing.Point(258, 86);
            this.trackBarEx13.Name = "trackBarEx13";
            this.trackBarEx13.Size = new System.Drawing.Size(179, 20);
            this.trackBarEx13.Style = Syncfusion.Windows.Forms.Tools.TrackBarEx.Theme.Metro;
            this.trackBarEx13.TabIndex = 45;
            this.trackBarEx13.Text = "trackBarEx13";
            this.trackBarEx13.TimerInterval = 100;
            this.trackBarEx13.Value = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(196, 86);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 20);
            this.label19.TabIndex = 44;
            this.label19.Text = "Height";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(196, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 20);
            this.label20.TabIndex = 43;
            this.label20.Text = "Width";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // trackBarEx14
            // 
            this.trackBarEx14.BackColor = System.Drawing.Color.White;
            this.trackBarEx14.BeforeTouchSize = new System.Drawing.Size(179, 20);
            this.trackBarEx14.ForeColor = System.Drawing.Color.Gray;
            this.trackBarEx14.Location = new System.Drawing.Point(258, 60);
            this.trackBarEx14.Name = "trackBarEx14";
            this.trackBarEx14.Size = new System.Drawing.Size(179, 20);
            this.trackBarEx14.Style = Syncfusion.Windows.Forms.Tools.TrackBarEx.Theme.Metro;
            this.trackBarEx14.TabIndex = 42;
            this.trackBarEx14.Text = "trackBarEx14";
            this.trackBarEx14.TimerInterval = 100;
            this.trackBarEx14.Value = 5;
            // 
            // trackBarEx5
            // 
            this.trackBarEx5.BackColor = System.Drawing.Color.White;
            this.trackBarEx5.BeforeTouchSize = new System.Drawing.Size(179, 20);
            this.trackBarEx5.ForeColor = System.Drawing.Color.Gray;
            this.trackBarEx5.Location = new System.Drawing.Point(258, 35);
            this.trackBarEx5.Name = "trackBarEx5";
            this.trackBarEx5.Size = new System.Drawing.Size(179, 20);
            this.trackBarEx5.Style = Syncfusion.Windows.Forms.Tools.TrackBarEx.Theme.Metro;
            this.trackBarEx5.TabIndex = 41;
            this.trackBarEx5.Text = "trackBarEx5";
            this.trackBarEx5.TimerInterval = 100;
            this.trackBarEx5.Value = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(207, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(207, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "X";
            // 
            // trackBarEx6
            // 
            this.trackBarEx6.BackColor = System.Drawing.Color.White;
            this.trackBarEx6.BeforeTouchSize = new System.Drawing.Size(179, 20);
            this.trackBarEx6.ForeColor = System.Drawing.Color.Gray;
            this.trackBarEx6.Location = new System.Drawing.Point(258, 9);
            this.trackBarEx6.Name = "trackBarEx6";
            this.trackBarEx6.Size = new System.Drawing.Size(179, 20);
            this.trackBarEx6.Style = Syncfusion.Windows.Forms.Tools.TrackBarEx.Theme.Metro;
            this.trackBarEx6.TabIndex = 36;
            this.trackBarEx6.Text = "trackBarEx6";
            this.trackBarEx6.TimerInterval = 100;
            this.trackBarEx6.Value = 5;
            // 
            // materialSingleLineTextField18
            // 
            this.materialSingleLineTextField18.Depth = 0;
            this.materialSingleLineTextField18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialSingleLineTextField18.Hint = "";
            this.materialSingleLineTextField18.Location = new System.Drawing.Point(16, 46);
            this.materialSingleLineTextField18.MaxLength = 32767;
            this.materialSingleLineTextField18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField18.Name = "materialSingleLineTextField18";
            this.materialSingleLineTextField18.PasswordChar = '\0';
            this.materialSingleLineTextField18.ReadOnly = false;
            this.materialSingleLineTextField18.SelectedText = "";
            this.materialSingleLineTextField18.SelectionLength = 0;
            this.materialSingleLineTextField18.SelectionStart = 0;
            this.materialSingleLineTextField18.Size = new System.Drawing.Size(174, 23);
            this.materialSingleLineTextField18.TabIndex = 46;
            this.materialSingleLineTextField18.TabStop = false;
            this.materialSingleLineTextField18.UseSystemPasswordChar = false;
            // 
            // Invoice_Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1144, 710);
            this.Controls.Add(this.tabControlAdv1);
            this.Controls.Add(this.pdfDocumentView1);
            this.Controls.Add(this.materialLabel5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Invoice_Template";
            this.ShowIcon = false;
            this.Text = "Invoice Template";
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView pdfDocumentView1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Syncfusion.Windows.Forms.Tools.TrackBarEx trackBarEx6;
        private Syncfusion.Windows.Forms.Tools.TrackBarEx trackBarEx5;
        private Syncfusion.Windows.Forms.Tools.TrackBarEx trackBarEx13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private Syncfusion.Windows.Forms.Tools.TrackBarEx trackBarEx14;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField18;
    }
}