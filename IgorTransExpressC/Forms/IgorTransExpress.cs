using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using IgorTransExpressC.Forms;

namespace IgorTransExpressC
{
    public partial class IgorTransExpress : Syncfusion.Windows.Forms.MetroForm
    {
        public IgorTransExpress()
        {
            InitializeComponent();
        }

        private void IgorTransExpress_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            if (ApplicationSettings.LoggedUser != null)
            {
                this.statusStripLabel1.Text = "Logged in as : " + ApplicationSettings.LoggedUser.name + " " + ApplicationSettings.LoggedUser.surname;

                if (ApplicationSettings.LoggedUser.access_level == Convert.ToInt32(Enums.AccessLevel.Admin))
                {
                    this.statusStripLabel1.Text += " with ADMIN rights.";
                }
            }
        }

        private void IgorTransExpress_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)

            {
                if (f.Name == "CompanyInfo")
                {
                    return;
                }
            }

            this.IsMdiContainer = true;
            CompanyInfo ci = new CompanyInfo()
            {
                MdiParent = this
            };
            ci.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "UserInfo")
                {
                    return;
                }
            }

            this.IsMdiContainer = true;
            UsersInfo ui = new UsersInfo()
            {
                MdiParent = this
            };
            ui.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "CustomerMaintenance")
                {
                    return;
                }
            }

            this.IsMdiContainer = true;
            CustomerMaintenance cm = new CustomerMaintenance()
            {
                MdiParent = this
            };
            cm.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "Invoices")
                {
                    return;
                }
            }

            this.IsMdiContainer = true;
            Invoices cm = new Invoices()
            {
                MdiParent = this
            };
            cm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmImport")
                {
                    return;
                }
            }

            this.IsMdiContainer = true;
            frmImport imp = new frmImport()
            {
                MdiParent = this
            };
            imp.Show();
        }
    }
}