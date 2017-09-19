using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgorTransExpressC
{
    public partial class CustomerSearch : Syncfusion.Windows.Forms.MetroForm
    {
        public customer SelectedCustomer { get; set; }
        public List<customer> CustomerList = new List<customer>();

        public CustomerSearch()
        {
            InitializeComponent();
        }

        public void Open(Form parent, string searchPhrase)
        {
            materialSingleLineTextField18.Text = searchPhrase;

            if (parent != null)
            {
                Show();
            }
            else
            {
                ShowDialog();
            }
        }

        private void materialSingleLineTextField18_TextChanged(object sender, EventArgs e)
        {
            string searchPhrase = materialSingleLineTextField18.Text;

            if (searchPhrase != "")
            {
                ShowList(searchPhrase);
            }
        }

        private void ShowList(string searchPhrase)
        {
            listView2.Items.Clear();

            using (igortransDBcontext db = new igortransDBcontext())
            {
                CustomerList = db.customers.Where(x => x.account.Contains(searchPhrase) || x.name.Contains(searchPhrase)).ToList();

                foreach (customer c in CustomerList)
                {
                    ListViewItem itm = new ListViewItem();
                    itm.Tag = c;
                    itm.Text = c.account;
                    itm.SubItems.Add(c.name);

                    listView2.Items.Add(itm);
                }
            }
        }

        private void ListView2_DoubleClick(object sender, System.EventArgs e)
        {
            if (listView2.SelectedItems.Count == 1)
            {
                SelectedCustomer = (customer)listView2.SelectedItems[0].Tag;
                Close();
            }
        }

        private void ClickEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (listView2.SelectedItems.Count == 1)
                {
                    SelectedCustomer = (customer)listView2.SelectedItems[0].Tag;
                    Close();
                }
            }
        }
    }
}