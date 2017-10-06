#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Parsing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace IgorTransExpressC
{
    public partial class Invoice_Template : Syncfusion.Windows.Forms.MetroForm
    {
        public Invoice_Template()
        {
            InitializeComponent();
            this.Load += Form_Load;
        }

       
        private void Form_Load(object sender, EventArgs e)
        {

           

            //Create a new PDF document.

            PdfDocument pdfDocument = new PdfDocument();

            //Add a page to the PDF document.

            PdfPage pdfPage = pdfDocument.Pages.Add();

            //Create a PDF Template.

            PdfTemplate template = new PdfTemplate(100, 50);

            //Draw a rectangle on the template graphics 

            template.Graphics.DrawRectangle(PdfBrushes.BurlyWood, new System.Drawing.RectangleF(0, 0, 100, 50));

            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 14);

            PdfBrush brush = new PdfSolidBrush(Color.Black);

            //Draw a string using the graphics of the template.

            template.Graphics.DrawString("Hello World", font, brush, 5, 5);

            //Draw the template on the page graphics of the document.

            pdfPage.Graphics.DrawPdfTemplate(template, PointF.Empty);

            //Save the document.

            pdfDocument.Save("Output.pdf");

            //close the document

            pdfDocument.Close(true);

          
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
