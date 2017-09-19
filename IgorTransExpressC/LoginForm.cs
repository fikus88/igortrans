using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IgorTransExpressC;
using System.ComponentModel.DataAnnotations.Schema;

namespace IgorTransExpressC
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginFormLoad(object sender, EventArgs e)
        {
            materialSingleLineTextField2.Text = "fikus88"; // DEV
            materialSingleLineTextField1.Text = "test"; //DEV
        }

        private void OK_Click(Object sender, EventArgs e)
        {
            if (materialSingleLineTextField2.Text == "")
            {
                materialSingleLineTextField2.Focus();
                return;
            }

            if (materialSingleLineTextField1.Text == "")
            {
                materialSingleLineTextField1.Focus();
                return;
            }

            using (igortransDBcontext db = new igortransDBcontext())
            {
                string pass = Security.Encrypt(materialSingleLineTextField1.Text, true);
                user loggedUser = db.users.Where(u => u.password == pass && u.login == materialSingleLineTextField2.Text).FirstOrDefault();
                if (loggedUser != null)
                {
                    ApplicationSettings.LoggedUser = loggedUser;
                    IgorTransExpress x = new IgorTransExpress();
                    this.Hide();
                    x.Show();
                }
                else
                {
                    materialSingleLineTextField1.Text = "";
                    materialSingleLineTextField2.Text = "";
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user u = new user()
            {
                login = "fikus88",
                password = Security.Encrypt("test", true),
                access_level = 1,
                name = "Lukasz",
                surname = "Sikorski",
                position = "MD",
                email = "fikus88@gmail.com",
                phone = "07861550186"
            };

            using (igortransDBcontext db = new igortransDBcontext())
            {
                db.users.Add(u);
                db.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            company c = new company()
            {
                name = "Igor Trans Express",
                add1 = "57 Whittington Street",
                add2 = "",
                add3 = "",
                county = "Derbyshire",
                country = "United Kingdom",
                city = "Derby",
                postcode = "DE249AZ",
                telephone = "447592337042",
                email = "ask@igortransexpress.co.uk",
                vat = "182459289",
                logo = Sql.SaveFileAsBytea("..\\..\\..‪\\..\\..\\image\\top.png")
            };

            using (igortransDBcontext db = new igortransDBcontext())
            {
                db.companies.Add(c);
                db.SaveChanges();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customer c = new customer()
            {
                account = "TST",
                name = "Cus 1",
                add1 = "Add 1",
                add2 = "Add 2",
                add3 = "Add 3",
                county = "County",
                postcode = "Postcode",
                country = "Country",
                city = "City",
                telephone = "4590340-934",
                email = "dadads"
            };

            using (igortransDBcontext db = new igortransDBcontext())
            {
                db.customers.Add(c);
                db.SaveChanges();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (igortransDBcontext db = new igortransDBcontext())
            {
                invoice inv = new invoice()
                {
                    invoice_number = "0000001",
                    customerid = db.customers.FirstOrDefault().customerid,
                    date_created = DateTime.Now,
                    date_paid = FormHelper.EmptyDate,
                    status = 0,
                    total = 100.45M,
                    vat = 100.45M * 0.8M,
                    pdf = Sql.PDFFileToByte("C:\\Users\\Lukasz\\Documents\\IMG_20170907_0001.pdf")
                };

                db.invoices.Add(inv);
                db.SaveChanges();
            }
        }
    }
}