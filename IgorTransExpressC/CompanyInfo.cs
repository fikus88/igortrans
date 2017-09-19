using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgorTransExpressC
{
    public partial class CompanyInfo : Syncfusion.Windows.Forms.MetroForm
    {
        public CompanyInfo()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            LockControls(true);
            company Company = new company();

            using (igortransDBcontext db = new igortransDBcontext())
            {
                Company = db.companies.FirstOrDefault();
            }

            if (Company.companyid != 0)
            {
                LoadRecord(Company);

                if ((Enums.AccessLevel)ApplicationSettings.LoggedUser.access_level == Enums.AccessLevel.Admin)
                {
                    FormHelper.BtnEnabled(buttonAdv2, true);
                }
                else
                {
                    FormHelper.BtnEnabled(buttonAdv2, false);
                }

                FormHelper.BtnEnabled(buttonAdv5, false);
                FormHelper.BtnEnabled(buttonAdv3, false);
            }
        }

        private void LoadRecord(company Company)
        {
            materialSingleLineTextField1.Text = Company.name;
            materialSingleLineTextField2.Text = Company.add1;
            materialSingleLineTextField3.Text = Company.add2;
            materialSingleLineTextField4.Text = Company.add3;
            materialSingleLineTextField5.Text = Company.county;
            materialSingleLineTextField6.Text = Company.city;
            materialSingleLineTextField7.Text = Company.postcode;
            materialSingleLineTextField8.Text = Company.country;
            materialSingleLineTextField9.Text = Company.telephone;
            materialSingleLineTextField10.Text = Company.email;
            materialSingleLineTextField11.Text = Company.vat;
            this.Tag = Company;

            pictureBox1.Image = Sql.ByteToImage(Company.logo);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void LockControls(bool val)
        {
            foreach (Control c in this.panel1.Controls)
            {
                if (c is MaterialSkin.Controls.MaterialSingleLineTextField)
                {
                    ((MaterialSkin.Controls.MaterialSingleLineTextField)c).ReadOnly = val;
                }
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e) //SAVE
        {
            using (igortransDBcontext db = new igortransDBcontext())
            {
                company cmp =
                cmp = SavedRecord();
                db.Entry(cmp).State = System.Data.Entity.EntityState.Modified;
                if (db.SaveChanges() == 1)
                {
                    FormHelper.BtnEnabled(buttonAdv2, true);
                    FormHelper.BtnEnabled(buttonAdv3, false);
                    FormHelper.BtnEnabled(buttonAdv5, false);
                    buttonAdv4.Visible = false;
                    LockControls(true);
                }
                else
                {
                    MessageBox.Show("No changes saved");
                }
            }
            panel1.BackColor = Color.Gainsboro;
        }

        private company SavedRecord()
        {
            using (igortransDBcontext db = new igortransDBcontext())
            {
                company result = db.companies.Where(c => c.companyid == ((company)this.Tag).companyid).FirstOrDefault();

                result.name = materialSingleLineTextField1.Text;
                result.add1 = materialSingleLineTextField2.Text;
                result.add2 = materialSingleLineTextField3.Text;
                result.add3 = materialSingleLineTextField4.Text;
                result.county = materialSingleLineTextField5.Text;
                result.city = materialSingleLineTextField6.Text;
                result.postcode = materialSingleLineTextField7.Text;
                result.country = materialSingleLineTextField8.Text;
                result.telephone = materialSingleLineTextField9.Text;
                result.email = materialSingleLineTextField10.Text;
                result.vat = materialSingleLineTextField11.Text;
                result.logo = Sql.ImageToByte(pictureBox1.Image);

                return result;
            }
        }

        private void buttonAdv4_Click(object sender, EventArgs e) //OPEN FILE
        {
            OpenFileDialog x = new OpenFileDialog();
            if (x.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = x.FileName;
            }
        }

        private void buttonAdv2_Click(object sender, EventArgs e) //EDIT

        {
            LockControls(false);
            FormHelper.BtnEnabled(buttonAdv2, false);
            FormHelper.BtnEnabled(buttonAdv3, true);
            FormHelper.BtnEnabled(buttonAdv5, true);
            buttonAdv4.Visible = true;
            panel1.BackColor = Color.WhiteSmoke;
        }

        private void buttonAdv5_Click(object sender, EventArgs e) // SAVE
        {
            using (igortransDBcontext db = new igortransDBcontext())
            {
                company cmp =
                cmp = SavedRecord();
                db.Entry(cmp).State = System.Data.Entity.EntityState.Modified;
                if (db.SaveChanges() == 1)
                {
                    FormHelper.BtnEnabled(buttonAdv2, true);
                    FormHelper.BtnEnabled(buttonAdv3, false);
                    FormHelper.BtnEnabled(buttonAdv5, false);
                    buttonAdv4.Visible = false;
                    LockControls(true);
                }
                else
                {
                    MessageBox.Show("No changes saved");
                }
            }
            panel1.BackColor = Color.Gainsboro;
        }

        private void buttonAdv3_Click(object sender, EventArgs e) // CANCEL
        {
            LoadRecord((company)this.Tag);
            LockControls(true);
            FormHelper.BtnEnabled(buttonAdv2, true);
            FormHelper.BtnEnabled(buttonAdv3, false);
            FormHelper.BtnEnabled(buttonAdv5, false);
            buttonAdv4.Visible = false;
            panel1.BackColor = Color.Gainsboro;
        }
    }
}