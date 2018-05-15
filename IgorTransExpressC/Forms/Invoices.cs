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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using IgorTransExpressC.Forms;

namespace IgorTransExpressC
{
    public partial class Invoices : Syncfusion.Windows.Forms.MetroForm
    {
        public Invoices()
        {
            InitializeComponent();
        }

        private FormHelper.ViewMode Vmode;
        private CustomerSearch custSearch = new CustomerSearch();

        public static List<ButtonAdv> BtnList = new List<ButtonAdv>();
        private List<invoice> InvoiceList = new List<invoice>();
        private List<invdet> selectedInvoiceDetails = new List<invdet>();

        private invoice SelectedInvoice;
        private customer selectedCustomer;

        private event RecalcAsyncSingleHandler RecalcAsyncSingleCaller;

        private delegate void RecalcAsyncSingleHandler();

        private void RecalcAsyncSingle()
        {
            ;
            label3.Text = string.Format("{0:0,0.00}", CalcTotal());
            label8.Text = string.Format("{0:0,0.00}", CalcVat());
            label10.Text = string.Format("{0:0,0.00}", CalcSubtotal());
            label4.Text = string.Format("{0:0,0.00}", CalcPaid());
            label6.Text = string.Format("{0:0,0.00}", CalcOustanding());

            RecalcAsyncTotal();
        }

        private void ClearSingleCalc()
        {
            label3.Text = "0.00";
            label8.Text = "0.00";
            label10.Text = "0.00";
            label4.Text = "0.00";
            label6.Text = "0.00";
        }

        private event RecalcAsyncTotalHandler RecalcAsyncTotalCaller;

        private delegate void RecalcAsyncTotalHandler();

        private void RecalcAsyncTotal()
        {
        }

        private void Invoices_Load(object sender, EventArgs e)
        {
            this.RecalcAsyncSingleCaller += RecalcAsyncSingle;
            this.RecalcAsyncTotalCaller += RecalcAsyncTotal;
            deleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            BtnList.Clear();
            isItemEditPanelShown(false);
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
            panel4.Visible = false;
            Vmode = FormHelper.ViewMode.View;
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems != null &&
                (int)listView1.SelectedItems[0].Tag != 0)
            {
                using (igortransDBcontext db = new igortransDBcontext())
                {
                    int it = (int)listView1.SelectedItems[0].Tag;

                    invoice selectedInvoice = db.invoices.Where(x => x.invoiceid == it).FirstOrDefault();
                }

                if (SelectedInvoice.status != 2)
                {
                    DialogResult res = MessageBox.Show(this, "Are you sure yoo want to delete this line ?",
                "Delete Invoice line", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    if (res == DialogResult.OK)
                    {
                        DeleteDetailsLine();
                    }
                }
                else
                {
                    MessageBox.Show(this, "Unable to delete paid invoice", "Operation not allowed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void ReloadInvoices()
        {
            using (igortransDBcontext db = new igortransDBcontext())
            {
                InvoiceList = db.invoices.ToList();
                RecalcAsyncTotalCaller();
            }
        }

        private void ReloadInvoicesList()

        {
            listView1.Items.Clear();

            listView1.ForeColor = Color.Red;
            foreach (invoice inv in InvoiceList)
            {
                customer cust = null;
                using (igortransDBcontext db = new igortransDBcontext())
                {
                    cust = db.customers.Where(x => x.customerid == inv.customerid).First();
                }
                ListViewItem itm = new ListViewItem()
                {
                    Text = cust.name + " - " + inv.invoice_number,

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
                        itm.ForeColor = Color.Orange;
                        break;

                    case 2:
                        itm.ForeColor = Color.Green;
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
            materialSingleLineTextField1.ReadOnly = true;
            txtInvoiceRef.ReadOnly = panel1val;
            dateTimePickerAdv1.ReadOnly = true;
            dateTimePickerAdv2.ReadOnly = panel1val;
            currencyTextBox2.ReadOnly = panel1val;

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

            currencyTextBox2.DecimalValue = 0.00M;

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
                btnShowInvoice.Visible = false;
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

            selectedCustomer = Customer;
        }

        private void ShowInvoice(invoice inv, bool? isNewInvoice = false)
        {
            Vmode = FormHelper.ViewMode.View;
            isItemEditPanelShown(false);
            selectedInvoiceDetails.Clear();
            customer cust;
            listView2.Items.Clear();

            using (igortransDBcontext db = new igortransDBcontext())
            {
                cust = db.customers.Where(c => c.customerid == inv.customerid).FirstOrDefault();
            }

            ShowCustomer(cust);
            dateTimePickerAdv1.Value = inv.date_created;
            dateTimePickerAdv1.ForeColor = DefaultForeColor;

            btnShowInvoice.Visible = true;
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
            materialSingleLineTextField1.Text = inv.invoice_number;
            materialSingleLineTextField1.Font = new Font(materialSingleLineTextField1.Font, FontStyle.Bold | FontStyle.Italic);
            currencyTextBox2.ReadOnly = false;
            currencyTextBox2.DecimalValue = inv.total_paid;
            txtInvoiceRef.Text = inv.@ref;
            SelectedInvoice = inv;
            panel4.Visible = true;
            ShowInvoiceDetails(inv);
        }

        private void ShowInvoiceDetails(invoice invoice)
        {
            listView2.Items.Clear();
            using (igortransDBcontext db = new igortransDBcontext())
            {
                selectedInvoiceDetails = db.invdets.Where(x => x.invoiceid == invoice.invoiceid).ToList();
            }

            if (selectedInvoiceDetails.Count != 0)
            {
                foreach (invdet invdet in selectedInvoiceDetails)
                {
                    ListViewItem itm = new ListViewItem();
                    itm.Text = invdet.line.ToString();
                    itm.Tag = invdet.invdetid;
                    itm.SubItems.Add(invdet.delivery_date.ToShortDateString());
                    itm.SubItems.Add(invdet.line_ref);
                    itm.SubItems.Add(invdet.delivery_from);
                    itm.SubItems.Add(invdet.delivery_to);
                    itm.SubItems.Add(invdet.comments);
                    itm.SubItems.Add(string.Format("{0:0,0.00}", invdet.line_total));
                    itm.SubItems.Add(invdet.@ref);

                    listView2.Items.Add(itm);
                }
            }

            RecalcAsyncSingle();
        }

        private void buttonAdv4_Click(object sender, EventArgs e) // ADD
        {
            Vmode = FormHelper.ViewMode.Add;
            ClearScreen();
            ClearSingleCalc();
            LockFields(false, true, true);
            panel1.Visible = true;
            panel2.Visible = true;
            FormHelper.ViewModeButtons(BtnList, FormHelper.ViewMode.Add, this.Name);
            panel1.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;
            materialSingleLineTextField7.Focus();
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
                        SaveInvoice(true);
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
                SaveInvoice(true);
            }
            else
            {
                ClearScreen();
                materialSingleLineTextField7.Focus();
            }
        }

        private void buttonAdv2_Click(object sender, EventArgs e) //EDIT
        {
            Vmode = FormHelper.ViewMode.Edit;
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
                        db.invdets.RemoveRange(db.invdets.Where(invdet => invdet.invoiceid == id));
                        db.SaveChanges();
                    }
                    FormHelper.ViewModeButtons(BtnList, FormHelper.ViewMode.View, this.Name);
                    ReloadInvoices();

                    ReloadInvoicesList();
                }
            }

            Vmode = FormHelper.ViewMode.View;
        }

        private void buttonAdv3_Click(object sender, EventArgs e) // CANCEL
        {
            LockFields(true, true);

            FormHelper.ViewModeButtons(BtnList, FormHelper.ViewMode.View, this.Name);
            ReloadInvoices();
            ReloadInvoicesList();
            panel1.BackColor = Color.Gainsboro;
            panel2.BackColor = Color.Gainsboro;
            Vmode = FormHelper.ViewMode.View;
        }

        private void InvdetListMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && (Vmode == FormHelper.ViewMode.Edit || Vmode == FormHelper.ViewMode.Add))
            {
                contextMenuStripEx1.Show(MousePosition);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 1)
            {
                SaveDetailsRecord(false);
            }
            else
            {
                SaveDetailsRecord(true);
            }

            ShowInvoiceDetails(SelectedInvoice);
            isItemEditPanelShown(false);

            ReloadInvoices();
            ReloadInvoicesList();
        }

        private void SaveDetailsRecord(bool? isNew = false)
        {
            using (igortransDBcontext db = new igortransDBcontext())
            {
                if (isNew == true)
                {
                    int ln = 1;
                    if (db.invdets.Count(x => x.invoiceid == SelectedInvoice.invoiceid) > 0)
                    {
                        ln = db.invdets.Where(x => x.invoiceid == SelectedInvoice.invoiceid).Max(x => x.line) + 1;
                    }

                    invdet selectedInvdet = new invdet
                    {
                        line = ln,
                        invoiceid = db.invoices.Max(x => x.invoiceid),
                        delivery_date = dateTimePickerAdv3.Value,
                        line_ref = textBoxExt1.Text,
                        comments = textBoxExt4.Text,
                        delivery_from = textBoxExt2.Text,
                        delivery_to = textBoxExt3.Text,
                        @ref = richTextBox1.Text,
                        line_total = currencyTextBox1.DecimalValue
                    };
                    db.Entry(selectedInvdet).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                }
                else
                {
                    int currentInvdetid = Convert.ToInt32(listView2.SelectedItems[0].Tag);
                    invdet selectedInvdet = db.invdets.Where(x => x.invdetid == currentInvdetid
                    ).FirstOrDefault();

                    selectedInvdet.invoiceid = SelectedInvoice.invoiceid;
                    selectedInvdet.delivery_date = dateTimePickerAdv3.Value;
                    selectedInvdet.line_ref = textBoxExt1.Text;
                    selectedInvdet.comments = textBoxExt4.Text;
                    selectedInvdet.delivery_from = textBoxExt2.Text;
                    selectedInvdet.delivery_to = textBoxExt3.Text;
                    selectedInvdet.@ref = richTextBox1.Text;
                    selectedInvdet.line_total = Convert.ToDecimal(currencyTextBox1.Text);

                    db.Entry(selectedInvdet).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isItemEditPanelShown(false);
            ShowInvoiceDetails(SelectedInvoice);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e) //ADD DETAIL
        {
            isItemEditPanelShown(true);
            ClearDetailsPanel();
            listView2.SelectedItems.Clear();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e) //EDIT DETAIL
        {
            if (listView2.SelectedItems.Count == 1)
            {
                using (igortransDBcontext db = new igortransDBcontext())
                {
                    int xid = (int)listView1.SelectedItems[0].Tag;

                    invoice selectedInvoice = db.invoices.Where(x => x.invoiceid == xid).FirstOrDefault();
                    if (selectedInvoice.status != 2)
                    {
                        isItemEditPanelShown(true);
                        LoadDetailLine();
                    }
                    else
                    {
                        MessageBox.Show(this, "Unable to edit completed invoice", "Operation terminated.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadDetailLine()
        {
            int lineId = Convert.ToInt32(listView2.SelectedItems[0].Tag);
            using (igortransDBcontext db = new igortransDBcontext())
            {
                invdet selectedInvdet = db.invdets.Where(x => x.invdetid == lineId).FirstOrDefault();

                if (selectedInvdet != null)
                {
                    dateTimePickerAdv3.Value = selectedInvdet.delivery_date;
                    textBoxExt1.Text = selectedInvdet.line_ref;
                    textBoxExt2.Text = selectedInvdet.delivery_from;
                    textBoxExt3.Text = selectedInvdet.delivery_to;
                    textBoxExt4.Text = selectedInvdet.comments;
                    richTextBox1.Text = selectedInvdet.@ref;
                    currencyTextBox1.DecimalValue = selectedInvdet.line_total;
                }
            }
        }

        private void DeleteDetailsLine()
        {
            int lineid = Convert.ToInt32(listView2.SelectedItems[0].Tag);
            using (igortransDBcontext db = new igortransDBcontext())
            {
                invdet selectedInvdet = db.invdets.Where(x => x.invdetid == lineid).FirstOrDefault();

                if (selectedInvdet != null)
                {
                    db.invdets.Remove(selectedInvdet);

                    ReloadInvoices();
                    ReloadInvoicesList();
                    LockFields(true, true);
                    FormHelper.ViewModeButtons(BtnList, FormHelper.ViewMode.View, this.Name);
                    panel1.BackColor = Color.Gainsboro;
                    panel2.BackColor = Color.Gainsboro;
                    RecalcAsyncSingleCaller();
                }
            }
        }

        private void ClearDetailsPanel()
        {
            dateTimePickerAdv3.Value = DateTime.Now;
            textBoxExt1.Text = "";
            textBoxExt2.Text = "";
            textBoxExt3.Text = "";
            textBoxExt4.Text = "";
            richTextBox1.Text = "";
            currencyTextBox1.Text = Convert.ToString(0.00M);
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void isItemEditPanelShown(bool value)
        {
            if (value == true)
            {
                listView2.Size = new Size(listView2.Size.Width, 295);
            }
            else
            {
                listView2.Size = new Size(listView2.Size.Width, 405);
            }

            panel5.Visible = value;
        }

        private void buttonAdv5_Click(object sender, EventArgs e) //SAVE
        {
            SaveInvoice(false);
            RecalcAsyncSingleCaller();
        }

        private void SaveInvoice(bool isNew)
        {
            if (isNew != true)
            {
                SelectedInvoice.customerid = selectedCustomer.customerid;
                SelectedInvoice.date_created = dateTimePickerAdv1.Value;
                SelectedInvoice.date_paid = dateTimePickerAdv2.Value;
                SelectedInvoice.total_paid = currencyTextBox2.DecimalValue;
                SelectedInvoice.status = CalcInvoiceStatus();
                SelectedInvoice.vat = CalcVat();
                SelectedInvoice.pdf = null;
                SelectedInvoice.invoice_number = materialSingleLineTextField1.Text;
                SelectedInvoice.total = CalcTotal();
                SelectedInvoice.@ref = txtInvoiceRef.Text;

                using (igortransDBcontext db = new igortransDBcontext())
                {
                    db.Entry(SelectedInvoice).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    SelectedInvoice = db.invoices.Where(x => x.invoiceid == SelectedInvoice.invoiceid).FirstOrDefault();
                }
            }
            else
            {
                invoice newInvoice = new invoice
                {
                    customerid = selectedCustomer.customerid,
                    date_created = dateTimePickerAdv1.Value,
                    date_paid = dateTimePickerAdv2.Value,
                    status = 0,
                    total = 0.00M,
                    vat = 0.00M,
                    pdf = null,
                    invoice_number = GetNextInvoiceNumber().ToString(),
                    total_paid = 0.00M,
                };
                newInvoice.@ref = txtInvoiceRef.Text;

                materialSingleLineTextField1.Text = newInvoice.invoice_number;

                using (igortransDBcontext db = new igortransDBcontext())
                {
                    db.Entry(newInvoice).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                    SelectedInvoice = db.invoices.Where(x => x.invoiceid == db.invoices.Max(xx => xx.invoiceid)).FirstOrDefault();
                }
            }
        }

        private void buttonAdv5_Click_1(object sender, EventArgs e) // SAVE
        {
            SaveInvoice(false);
            ReloadInvoices();
            ReloadInvoicesList();
            LockFields(true, true);
            FormHelper.ViewModeButtons(BtnList, FormHelper.ViewMode.View, this.Name);
            panel1.BackColor = Color.Gainsboro;
            panel2.BackColor = Color.Gainsboro;
            RecalcAsyncSingleCaller();
        }

        // INVOICE CALCULATION METHODS

        #region "Calculations"

        private short CalcInvoiceStatus()
        {
            decimal totalToPay = 0.00M;

            if (selectedInvoiceDetails.Count > 0)
            {
                totalToPay = selectedInvoiceDetails.Sum(x => (x.line_total * 1.2M));

                if (totalToPay == SelectedInvoice.total_paid)
                {
                    return 2;
                }
                else if (totalToPay > 0 && SelectedInvoice.total_paid == 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
                {
                }
            }
            else
            {
                return 0;
            }
        }

        private decimal CalcVat()
        {
            return (selectedInvoiceDetails.Sum(x => x.line_total * 1.2M) - selectedInvoiceDetails.Sum(x => x.line_total));
        }

        private long GetNextInvoiceNumber()
        {
            long curNum = IgorTransExpressC.Properties.Settings.Default.InvoiceNum;
            Properties.Settings.Default.InvoiceNum += 1;
            Properties.Settings.Default.Save();

            return curNum;
        }

        private decimal CalcTotal()
        {
            return selectedInvoiceDetails.Sum(x => (x.line_total * 1.2M));
        }

        private decimal CalcSubtotal()
        {
            return selectedInvoiceDetails.Sum(x => (x.line_total));
        }

        private decimal CalcOustanding()
        {
            return (selectedInvoiceDetails.Sum(x => (x.line_total * 1.2M)) - SelectedInvoice.total_paid);
        }

        private decimal CalcPaid()
        {
            return SelectedInvoice.total_paid;
        }

        #endregion "Calculations"

        private void currencyTextBoxValueChanged(object sender, EventArgs e)
        {
            RecalcAsyncTotalCaller();
        }

        private void btnShowInvoice_Click(object sender, EventArgs e)
        {
            string rpPath = Application.StartupPath + "\\Reports\\rpt_Invoice.rpt";
            ReportDocument rp = new ReportDocument();
            rp.Load(rpPath);
            rp.Refresh();
            rp.SetParameterValue("@invoiceID", SelectedInvoice.invoiceid);

            frmInvoiceViewer viewer = new frmInvoiceViewer() { WindowState = FormWindowState.Maximized };
            viewer.Report = rp;
            viewer.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}

// TODO :
// handle live calculation of all invoices

// Next stage : Invoice viewer handle export, email print. GET HISTORICAL FROM XLSX