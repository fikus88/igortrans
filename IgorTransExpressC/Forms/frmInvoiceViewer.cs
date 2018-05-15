using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgorTransExpressC.Forms
{
    public partial class frmInvoiceViewer : Syncfusion.Windows.Forms.MetroForm
    {
        public ReportDocument Report;

        public frmInvoiceViewer()
        {
            InitializeComponent();

            this.Load += FrmInvoiceViewer_Load;
        }

        private void FrmInvoiceViewer_Load(object sender, EventArgs e)
        {
            if (Report != null)
            {
                crystalReportViewer1.ReportSource = Report;
                //.RefreshReport();
            }
        }
    }
}