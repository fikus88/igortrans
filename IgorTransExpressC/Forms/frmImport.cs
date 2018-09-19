using Syncfusion.XlsIO;
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
    public partial class frmImport : Syncfusion.Windows.Forms.MetroForm
    {
        public frmImport()
        {
            InitializeComponent();

            spreadsheet1.Click += spreadsheet1_Click;
        }

        private void buttonAdv1_Click(object sender, EventArgs e) // OPEN
        {
            OpenFileDialog fd = new OpenFileDialog();

            DialogResult res = fd.ShowDialog();

            if (res == DialogResult.OK)
            {
                spreadsheet1.Open(fd.FileName);
            }
        }

        private void buttonAdv2_Click(object sender, EventArgs e) //EXTRACT
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            DataTable data = new DataTable();
            data.Columns.Add("Name");
            data.Columns.Add("Add1");
            data.Columns.Add("Add2");
            data.Columns.Add("Add3");
            data.Columns.Add("County");
            data.Columns.Add("City");
            data.Columns.Add("Postcode");
            data.Columns.Add("Country");

            listView1.Columns.Add("Name");
            listView1.Columns.Add("Add1");
            listView1.Columns.Add("Add2");
            listView1.Columns.Add("Add3");
            listView1.Columns.Add("County");
            listView1.Columns.Add("City");
            listView1.Columns.Add("Postcode");
            listView1.Columns.Add("Country");
            listView1.View = View.Details;

            IWorksheet actveSheet = spreadsheet1.ActiveSheet;

            txtName.Focus();
        }

        private void spreadsheet1_Click(object sender, EventArgs e)
        {
            IRange rng = spreadsheet1.ActiveSheet.Range;

            if (rng != null)
            {
                if (txtAdd1.Focused)
                {
                    txtAdd1.Text = rng.Value;
                    txtAdd2.Focus();
                }
                else if (txtAdd2.Focused)
                {
                    txtAdd2.Text = rng.Value;
                    txtAdd3.Focus();
                }
                else if (txtAdd3.Focused)
                {
                    txtAdd3.Text = rng.Value;
                    txtCounty.Focus();
                }
                else if (txtCounty.Focused)
                {
                    txtCounty.Text = rng.Value;
                    txtCity.Focus();
                }
                else if (txtCity.Focused)
                {
                    txtCity.Text = rng.Value;
                    txtPostcode.Focus();
                }
                else if (txtCountry.Focused)
                {
                    txtCountry.Text = rng.Value;

                    ListViewItem itm = new ListViewItem() { Text = txtName.Text };
                    itm.SubItems.Add(txtAdd1.Text);
                    itm.SubItems.Add(txtAdd2.Text);
                    itm.SubItems.Add(txtAdd3.Text);
                    itm.SubItems.Add(txtCounty.Text);
                    itm.SubItems.Add(txtCity.Text);
                    itm.SubItems.Add(txtPostcode.Text);
                    itm.SubItems.Add(txtCountry.Text);

                    listView1.Items.Add(itm);
                }
            }
        }
    }
}