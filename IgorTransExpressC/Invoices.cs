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
    public partial class Invoices : Syncfusion.Windows.Forms.MetroForm
    {
        public Invoices()
        {
            InitializeComponent();
        }

        private CustomerSearch custSearch = new CustomerSearch();

        public static List<ButtonAdv> BtnList = new List<ButtonAdv>();
        private List<invoice> InvoiceList = new List<invoice>();
        private invoice SelectedInvoice;

        private void Invoices_Load(object sender, EventArgs e)
        {
            BtnList.Clear();

            BtnList.Add(buttonAdv1);
            BtnList.Add(buttonAdv2);
            BtnList.Add(buttonAdv3);
            BtnList.Add(buttonAdv4);
            BtnList.Add(buttonAdv5);
            FormHelper.AreRaisedButtonsVisible(BtnList, false);
            custSearch.FormClosing += new FormClosingEventHandler(CustomerSearchClosed);
            listView2.MouseDown += InvdetListMouseClick;
            ReloadInvoices();
            ReloadInvoicesList();
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void ReloadInvoices()
        {
            using (igortransDBcontext db = new igortransDBcontext())
            {
                InvoiceList = db.invoices.ToList();
            }
        }

        private void ReloadInvoicesList()

        {
            listView1.Items.Clear();

            listView1.ForeColor = Color.Red;
            foreach (invoice inv in InvoiceList)
            {
                ListViewItem itm = new ListViewItem()
                {
                    Text = inv.invoice_number,

                    Tag = inv.invoiceid,
                    UseItemStyleForSubItems = false,
                    ForeColor = Color.Red
                };

                switch (inv.status)
                {
                    case 0:
                        itm.ForeColor = Color.Red;
                        ;
                        break;

                    case 1:
                        itm.ForeColor = Color.Green;
                        break;

                    case 2:
                        itm.ForeColor = Color.Orange;
                        break;
                }

                listView1.Items.Add(itm);
            }
            listView1.Refresh();

            if (InvoiceList.Count == 0)
            {
                FormHelper.AreRaisedButtonsVisible(BtnList, false);
                FormHelper.BtnEnabled(buttonAdv4, true);
                panel1.Visible = false;
                panel2.Visible = false;
            }
        }

        private void LockFields(bool panel1val, bool panel2val, bool? newInvoice = false)
        {
            if (newInvoice == true)
            {
                materialSingleLineTextField7.ReadOnly = false;
            }
            else
            {
                materialSingleLineTextField7.ReadOnly = true;
            }

            materialSingleLineTextField13.ReadOnly = true;
            materialSingleLineTextField18.ReadOnly = true;
            materialSingleLineTextField20.ReadOnly = true;
            materialSingleLineTextField19.ReadOnly = true;
            materialSingleLineTextField22.ReadOnly = true;
            materialSingleLineTextField14.ReadOnly = true;
            materialSingleLineTextField21.ReadOnly = true;
            materialSingleLineTextField12.ReadOnly = true;
            materialSingleLineTextField10.ReadOnly = true;
            materialSingleLineTextField8.ReadOnly = true;
            dateTimePickerAdv1.ReadOnly = true;
            dateTimePickerAdv2.ReadOnly = panel1val;
            currencyTextBox2.ReadOnly = true;

            panel2.Enabled = panel2val;

            if (panel1val == true)
            {
                panel1.BackColor = Color.Gainsboro;
            }
            else
            {
                panel1.BackColor = Color.WhiteSmoke;
            }

            if (panel2val == true)
            {
                panel2.BackColor = Color.Gainsboro;
            }
            else
            {
                panel2.BackColor = Color.WhiteSmoke;
            }
        }

        private void ClearScreen()
        {
            foreach (Control c in panel2.Controls)
            {
                if (c is MaterialSingleLineTextField)
                {
                    ((MaterialSingleLineTextField)c).Text = "";

                    dateTimePickerAdv1.Value = DateTime.Now;
                    //   dateTimePickerAdv2.Value = FormHelper.EmptyDate;
                    dateTimePickerAdv2.EnableNullDate = true;
                    dateTimePickerAdv2.IsNullDate = true;
                }
            }

            listView2.Items.Clear();
        }

        private void MaterialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                invoice selectedInvoice = InvoiceList.Where(inv => inv.invoiceid ==
                Convert.ToInt32(listView1.SelectedItems[0].Tag)).FirstOrDefault();
                if (selectedInvoice != null)
                {
                    ShowInvoice(selectedInvoice);
                    panel1.Visible = true;
                    panel2.Visible = true;
                    FormHelper.AreRaisedButtonsVisible(BtnList, true);
                    LockFields(true, true);
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

        private void ShowCustomer(customer Customer)
        {
            materialSingleLineTextField7.Text = Customer.account;
            materialSingleLineTextField13.Text = Customer.name;
            materialSingleLineTextField18.Text = Customer.add1;
            materialSingleLineTextField20.Text = Customer.add2;
            materialSingleLineTextField19.Text = Customer.add3;
            materialSingleLineTextField22.Text = Customer.county;
            materialSingleLineTextField14.Text = Customer.city;
            materialSingleLineTextField21.Text = Customer.postcode;
            materialSingleLineTextField12.Text = Customer.country;
            materialSingleLineTextField10.Text = Customer.telephone;
            materialSingleLineTextField8.Text = Customer.email;
        }

        private void ShowInvoice(invoice inv, bool? isNewInvoice = false)
        {
            customer cust;
            using (igortransDBcontext db = new igortransDBcontext())
            {
                cust = db.customers.Where(c => c.customerid == inv.customerid).FirstOrDefault();
            }

            ShowCustomer(cust);
            dateTimePickerAdv1.Value = inv.date_created;
            dateTimePickerAdv1.ForeColor = DefaultForeColor;

            if (inv.date_paid != null)
            {
                dateTimePickerAdv2.Value = inv.date_paid;
                dateTimePickerAdv2.Format = DateTimePickerFormat.Long;
            }
            else
            {
                dateTimePickerAdv2.CustomFormat = " ";
                dateTimePickerAdv2.Format = DateTimePickerFormat.Custom;
                dateTimePickerAdv2.Text = "";
            }
            currencyTextBox2.ReadOnly = false;
            currencyTextBox2.DecimalValue = inv.total_paid;
        }

        private void buttonAdv4_Click(object sender, EventArgs e) // ADD
        {
            ClearScreen();
            LockFields(false, true, true);
            panel1.Visible = true;
            panel2.Visible = true;
            FormHelper.ViewModeButtons(BtnList, FormHelper.ViewMode.Add, this.Name);
            panel1.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;
            materialSingleLineTextField7.Focus();
        }

        private void materialSingleLineTextField7_Validating(object sender, CancelEventArgs e)
        {
            ValidateCustomer();
        }

        private void AccountFieldEnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateCustomer();
            }
        }

        private void ValidateCustomer()
        {
            if (materialSingleLineTextField7.Text != "")
            {
                customer selectedCustomer = new customer();
                using (igortransDBcontext db = new igortransDBcontext())
                {
                    selectedCustomer = db.customers.Where(x => x.account == materialSingleLineTextField7.Text).FirstOrDefault();

                    if (selectedCustomer != null)
                    {
                        ShowCustomer(selectedCustomer);
                    }
                    else
                    {
                        custSearch.Open(null, materialSingleLineTextField7.Text);
                        if (custSearch.SelectedCustomer == null)
                        {
                            materialSingleLineTextField7.Focus();
                            ClearScreen();
                        }
                    }
                }
            }
            else
            {
                ClearScreen();
            }
        }

        private void CustomerSearchClosed(object sender, FormClosingEventArgs e)
        {
            if (custSearch.SelectedCustomer != null)
            {
                materialSingleLineTextField7.Text = custSearch.SelectedCustomer.account;
                ShowCustomer(custSearch.SelectedCustomer);
            }
            else
            {
                ClearScreen();
                materialSingleLineTextField7.Focus();
            }
        }

        private void buttonAdv2_Click(object sender, EventArgs e) //EDIT
        {
            LockFields(false, true);
            FormHelper.ViewModeButtons(BtnList, FormHelper.ViewMode.Edit, this.Name);
            panel1.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;
        }

        private void buttonAdv1_Click(object sender, EventArgs e) // DELETE
        {
            if (listView1.SelectedItems.Count == 1)
            {
                DialogResult res = MessageBox.Show(null,
                    "Are you sure you want to delete this invoice ?",
                     "Delete Invoice",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    using (igortransDBcontext db = new igortransDBcontext())
                    {
                        int id = Convert.ToInt32(listView1.SelectedItems[0].Tag);
                        db.invoices.Remove(db.invoices.Where(inv => inv.invoiceid == id).FirstOrDefault());
                        db.SaveChanges();
                    }
                    FormHelper.ViewModeButtons(BtnList, FormHelper.ViewMode.View, this.Name);
                    ReloadInvoices();
                    ReloadInvoicesList();
                }
            }
        }

        private void buttonAdv3_Click(object sender, EventArgs e) // CANCEL
        {
            LockFields(true, true);

            FormHelper.ViewModeButtons(BtnList, FormHelper.ViewMode.View, this.Name);
            ReloadInvoices();
            ReloadInvoicesList();
            panel1.BackColor = Color.Gainsboro;
            panel2.BackColor = Color.Gainsboro;
        }

        private void InvdetListMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripEx1.Show(MousePosition);
            }
        }
    }
}

// TODO :
// Context Menu : List before Y 405, after Y 295 display panel5
// Handle add,edit,delete invdet
// handle live calculation of invoice
// handle live calc of total invoices

// Next stage : PDF read, write, save  ///////////////////////////// 