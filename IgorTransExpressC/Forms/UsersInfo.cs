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

namespace IgorTransExpressC
{
    public partial class UsersInfo : Syncfusion.Windows.Forms.MetroForm
    {
        public UsersInfo()
        {
            InitializeComponent();
        }

        public static List<Syncfusion.Windows.Forms.ButtonAdv> BtnList = new List<Syncfusion.Windows.Forms.ButtonAdv>();
        private List<user> UserList = new List<user>();

        public void Form_Load(object sender, EventArgs e)
        {
            BtnList.Clear();
            BtnList.Add(buttonAdv1);
            BtnList.Add(buttonAdv2);
            BtnList.Add(buttonAdv3);
            BtnList.Add(buttonAdv4);
            BtnList.Add(buttonAdv5);

            listView1.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);

            FormHelper.AreRaisedButtonsVisible(BtnList, false);
            panel1.Visible = false;
            ReloadAccessLevelCombo();
            ReloadUsers();
            ReloadList();
        }

        private void ReloadList()

        {
            listView1.Items.Clear();
            foreach (user u in UserList)
            {
                ListViewItem itm = new ListViewItem();

                itm.Text = u.name + " " + u.surname;
                itm.Font = new Font(itm.Font.FontFamily, 11, FontStyle.Regular);
                itm.Tag = u.userid;

                listView1.Items.Add(itm);
            }
            listView1.Refresh();
        }

        private void ReloadAccessLevelCombo()
        {
            comboBox1.Items.Clear();

            comboBox1.DataSource = Enum.GetValues(typeof(Enums.AccessLevel));
        }

        private void MaterialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                user selectedUser = UserList.Where(u => u.userid == Convert.ToInt32(listView1.SelectedItems[0].Tag)).FirstOrDefault();
                if (selectedUser != null)
                {
                    ShowUser(selectedUser);
                    panel1.Visible = true;
                    FormHelper.AreRaisedButtonsVisible(BtnList, true);
                    LockFields(true);
                    FormHelper.ViewModeButtons(BtnList, FormHelper.ViewMode.View, this.Name);
                }
            }
            else
            {
                panel1.Visible = false;
                FormHelper.AreRaisedButtonsVisible(BtnList, false);
            }
        }

        private void ReloadUsers()
        {
            using (igortransDBcontext db = new igortransDBcontext())
            {
                UserList = db.users.ToList();
            }
        }

        private void ShowUser(user u)
        {
            materialSingleLineTextField1.Text = u.login;
            if ((Enums.AccessLevel)ApplicationSettings.LoggedUser.access_level == Enums.AccessLevel.Admin)
            {
                materialSingleLineTextField2.Text = Security.Decrypt(u.password, true);
            }
            else
            {
                materialSingleLineTextField2.Text = u.password;
            }
            materialSingleLineTextField3.Text = u.name;
            materialSingleLineTextField4.Text = u.surname;
            materialSingleLineTextField5.Text = u.position;
            materialSingleLineTextField9.Text = u.phone;
            materialSingleLineTextField11.Text = u.email;
            comboBox1.SelectedItem = (Enums.AccessLevel)u.access_level;
        }

        private void LockFields(bool val, bool? newUser = false)
        {
            if (newUser == true)
            {
                materialSingleLineTextField1.ReadOnly = val;
            }
            else
            {
                materialSingleLineTextField1.ReadOnly = false;
            }

            if ((Enums.AccessLevel)ApplicationSettings.LoggedUser.access_level == Enums.AccessLevel.Admin)
            {
                materialSingleLineTextField2.ReadOnly = val;
            }
            else
            {
                materialSingleLineTextField2.ReadOnly = false;
            }
            materialSingleLineTextField3.ReadOnly = val;
            materialSingleLineTextField4.ReadOnly = val;
            materialSingleLineTextField5.ReadOnly = val;
            materialSingleLineTextField9.ReadOnly = val;
            materialSingleLineTextField11.ReadOnly = val;
            comboBox1.Enabled = !val;
        }

        private void ClearScreen()
        {
            materialSingleLineTextField1.Text = "";
            materialSingleLineTextField2.Text = "";
            materialSingleLineTextField3.Text = "";
            materialSingleLineTextField4.Text = "";
            materialSingleLineTextField5.Text = "";
            materialSingleLineTextField9.Text = "";
            materialSingleLineTextField11.Text = "";
            comboBox1.SelectedItem = (Enums.AccessLevel.User);
        }

        private user SavedRecord(user usr, bool? isNew = false)

        {
            if (usr == null)
            {
                usr = new user();
            }
            if (isNew != false)
            {
                usr.login = materialSingleLineTextField1.Text;
            }
            usr.password = Security.Encrypt(materialSingleLineTextField2.Text, true);
            usr.name = materialSingleLineTextField3.Text;
            usr.surname = materialSingleLineTextField4.Text;
            usr.position = materialSingleLineTextField5.Text;
            usr.phone = materialSingleLineTextField9.Text;
            usr.email = materialSingleLineTextField11.Text;

            return usr;
        }

        private void buttonAdv1_Click(object sender, EventArgs e) //DELETE
        {
            if (listView1.Items.Count > 1)
            {
                DialogResult res = MessageBox.Show(null,
                    "Are you sure you want to delete this user ?",
                     "Delete User",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    using (igortransDBcontext db = new igortransDBcontext())
                    {
                        db.users.Remove(db.users.Where(u => u.login == materialSingleLineTextField1.Text).FirstOrDefault());
                        db.SaveChanges();
                    }
                    ReloadUsers();
                    ReloadList();
                    FormHelper.ViewModeButtons(BtnList, FormHelper.ViewMode.View, this.Name);
                    ClearScreen();
                    ShowUser(ApplicationSettings.LoggedUser);
                }
            }
        }

        private void buttonAdv4_Click(object sender, EventArgs e) // ADD
        {
            ClearScreen();
            LockFields(false, true);
            panel1.Visible = true;
            FormHelper.ViewModeButtons(BtnList, FormHelper.ViewMode.Add, this.Name);
            panel1.BackColor = Color.WhiteSmoke;
        }

        private void buttonAdv5_Click(object sender, EventArgs e) //SAVE
        {
            if (materialSingleLineTextField1.Text == "")
            {
                materialSingleLineTextField1.Focus();
                return;
            }
            using (igortransDBcontext db = new igortransDBcontext())
            {
                user usr = db.users.Where(u => u.login == materialSingleLineTextField1.Text).FirstOrDefault();

                if (usr != null)
                {
                    usr = SavedRecord(usr);

                    db.Entry(usr).State = System.Data.Entity.EntityState.Modified;
                }
                else
                {
                    usr = SavedRecord(usr, true);
                    db.Entry(usr).State = System.Data.Entity.EntityState.Added;
                }
                db.SaveChanges();
            }

            ReloadUsers();
            ReloadList();
            FormHelper.ViewModeButtons(BtnList, FormHelper.ViewMode.View, this.Name);
            LockFields(true);
            panel1.BackColor = Color.Gainsboro;
        }

        private void buttonAdv3_Click(object sender, EventArgs e) //CANCEL
        {
            LockFields(true);
            FormHelper.ViewModeButtons(BtnList, FormHelper.ViewMode.View, this.Name);
            panel1.BackColor = Color.Gainsboro;
        }

        private void buttonAdv2_Click(object sender, EventArgs e) //EDIT
        {
            LockFields(false);
            FormHelper.ViewModeButtons(BtnList, FormHelper.ViewMode.Edit, this.Name);
            panel1.BackColor = Color.WhiteSmoke;
        }
    }
}