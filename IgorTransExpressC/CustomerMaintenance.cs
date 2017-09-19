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
using Syncfusion.Windows.Forms;

namespace IgorTransExpressC
{
    public partial class CustomerMaintenance : Syncfusion.Windows.Forms.MetroForm
    {
        public CustomerMaintenance()
        {
            InitializeComponent();
        }

        public static List<ButtonAdv> BtnList = new List<ButtonAdv>();
        private List<customer> CustomerList = new List<customer>();

        public void Form_Load(object sender, EventArgs e)
        {
            BtnList.Clear();
            BtnList.Add(buttonAdv1);
            BtnList.Add(buttonAdv2);
            BtnList.Add(buttonAdv3);
            BtnList.Add(buttonAdv4);
            BtnList.Add(buttonAdv5);

            FormHelper.AreRaisedButtonsVisible(BtnList, false);
            panel1.Visible = false;
            panel2.Visible = false;
            ReloadCustomers();
            ReloadList();
        }

        private void ReloadList()

        {
            listView1.Items.Clear();
            foreach (customer c in CustomerList)
            {
                ListViewItem itm = new ListViewItem();

                itm.Text = c.name;

                itm.Tag = c.customerid;

                listView1.Items.Add(itm);
            }
            listView1.Refresh();

            if (CustomerList.Count == 0)
            {
                FormHelper.AreRaisedButtonsVisible(BtnList, false);
                FormHelper.BtnEnabled(buttonAdv4, true);
                panel1.Visible = false;
                panel2.Visible = false;
            }
        }

        private void ReloadCustomers()
        {
            using (igortransDBcontext db = new igortransDBcontext())
            {
                CustomerList = db.customers.ToList();
            }
        }

        private void MaterialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                customer selectedCustomer = CustomerList.Where(u => u.customerid ==
                Convert.ToInt32(listView1.SelectedItems[0].Tag)).FirstOrDefault();

                if (selectedCustomer != null)
                {
                    ShowCustomer(selectedCustomer);
                    panel1.Visible = true;
                    panel2.Visible = true;
                    FormHelper.AreRaisedButtonsVisible(BtnList, true);
                    LockFields(true);
                    FormHelper.ViewModeButtons(BtnList, FormHelper.ViewMode.View, this.Name);
                }
            }
            else
            {
                panel1.Visible = false;
                panel2.Visible = false;
                FormHelper.AreRaisedButtonsVisible(BtnList, false);
            }
        }

        private void ClearScreen()
        {
            materialSingleLineTextField6.Text = "";
            materialSingleLineTextField1.Text = "";
            materialSingleLineTextField2.Text = "";
            materialSingleLineTextField3.Text = "";
            materialSingleLineTextField4.Text = "";
            materialSingleLineTextField5.Text = "";
            materialSingleLineTextField9.Text = "";
            materialSingleLineTextField11.Text = "";
            materialSingleLineTextField15.Text = "";
            materialSingleLineTextField16.Text = "";
            materialSingleLineTextField17.Text = "";
        }

        private void LockFields(bool val, bool? newCustomer = false)
        {
            if (newCustomer == false)
            {
                materialSingleLineTextField6.ReadOnly = true;
            }
            else
            {
                materialSingleLineTextField6.ReadOnly = val;
            }

            materialSingleLineTextField1.ReadOnly = val;
            materialSingleLineTextField2.ReadOnly = val;
            materialSingleLineTextField3.ReadOnly = val;
            materialSingleLineTextField4.ReadOnly = val;
            materialSingleLineTextField5.ReadOnly = val;
            materialSingleLineTextField9.ReadOnly = val;
            materialSingleLineTextField11.ReadOnly = val;
            materialSingleLineTextField15.ReadOnly = val;
            materialSingleLineTextField16.ReadOnly = val;
            materialSingleLineTextField17.ReadOnly = val;

            if (val == true)
            {
                panel1.BackColor = Color.Gainsboro;
                panel2.BackColor = Color.Gainsboro;
            }
            else
            {
                panel1.BackColor = Color.WhiteSmoke;
                panel2.BackColor = Color.WhiteSmoke;
            }
        }

        private void ShowCustomer(customer c)
        {
            materialSingleLineTextField6.Text = c.account;
            materialSingleLineTextField1.Text = c.name;

            materialSingleLineTextField2.Text = c.add1;

            materialSingleLineTextField3.Text = c.add2;
            materialSingleLineTextField4.Text = c.add3;
            materialSingleLineTextField5.Text = c.county;
            materialSingleLineTextField9.Text = c.city;
            materialSingleLineTextField11.Text = c.postcode;
            materialSingleLineTextField15.Text = c.country;
            materialSingleLineTextField16.Text = c.email;
            materialSingleLineTextField17.Text = c.telephone;
        }

        private customer SavedRecord(customer cr, bool? isNew = false)

        {
            if (cr == null)
            {
                cr = new customer();
            }
            if (isNew != false)
            {
                cr.account = materialSingleLineTextField6.Text.ToUpper();
            }
            cr.name = materialSingleLineTextField1.Text;
            cr.add1 = materialSingleLineTextField2.Text;
            cr.add2 = materialSingleLineTextField3.Text;
            cr.add3 = materialSingleLineTextField4.Text;

            cr.county = materialSingleLineTextField5.Text;
            cr.city = materialSingleLineTextField9.Text;
            cr.postcode = materialSingleLineTextField11.Text;
            cr.country = materialSingleLineTextField15.Text;
            cr.telephone = materialSingleLineTextField16.Text;
            cr.email = materialSingleLineTextField17.Text;

            return cr;
        }

        private void buttonAdv4_Click(object sender, EventArgs e) // ADD
        {
            ClearScreen();
            LockFields(false, true);
            panel1.Visible = true;
            panel2.Visible = true;
            FormHelper.ViewModeButtons(BtnList, FormHelper.ViewMode.Add, this.Name);
        }

        private void buttonAdv2_Click(object sender, EventArgs e) //EDIT
        {
            LockFields(false);
            FormHelper.ViewModeButtons(BtnList, FormHelper.ViewMode.Edit, this.Name);
            panel1.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;
        }

        private void buttonAdv5_Click(object sender, EventArgs e) // SAVE
        {
            if (materialSingleLineTextField6.Text == "")
            {
                materialSingleLineTextField6.Focus();
                return;
            }
            using (igortransDBcontext db = new igortransDBcontext())
            {
                customer csr = db.customers.Where(c => c.account == materialSingleLineTextField6.Text).FirstOrDefault();

                if (csr != null)
                {
                    csr = SavedRecord(csr);

                    db.Entry(csr).State = System.Data.Entity.EntityState.Modified;
                }
                else
                {
                    csr = SavedRecord(csr, true);
                    db.Entry(csr).State = System.Data.Entity.EntityState.Added;
                }
                db.SaveChanges();
            }

            ReloadCustomers();
            ReloadList();
            FormHelper.ViewModeButtons(BtnList, FormHelper.ViewMode.View, this.Name);
            LockFields(true);
        }

        private void buttonAdv1_Click(object sender, EventArgs e) // DELETE
        {
            if (listView1.Items.Count > 1)
            {
                DialogResult res = MessageBox.Show(null,
                    "Are you sure you want to delete this customer ?",
                     "Delete Customer",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    using (igortransDBcontext db = new igortransDBcontext())
                    {
                        db.customers.Remove(db.customers.Where(u =>
                        u.customerid == Convert.ToInt32(listView1.SelectedItems[0].Tag)).FirstOrDefault());

                        db.SaveChanges();
                    }

                    FormHelper.ViewModeButtons(BtnList, FormHelper.ViewMode.View, this.Name);
                    ReloadCustomers();
                    ReloadList();
                }
            }
        }

        private void buttonAdv3_Click(object sender, EventArgs e) // CANCEL
        {
            LockFields(true);
            FormHelper.ViewModeButtons(BtnList, FormHelper.ViewMode.View, this.Name);
            ReloadCustomers();
            ReloadList();
        }
    }
}