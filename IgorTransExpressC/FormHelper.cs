using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;
using Syncfusion.Windows.Forms;

namespace IgorTransExpressC
{
    internal class FormHelper

    {
        public static void BtnEnabled(ButtonAdv btn, bool val, bool? isVisible = true)
        {
            btn.Enabled = val;
            btn.Refresh();
            if (btn.Visible == false)
            {
                btn.Visible = true;
            }
        }

        public static void AreRaisedButtonsVisible(List<ButtonAdv> btns, bool val)
        {
            foreach (ButtonAdv b in btns)
            {
                b.Visible = val;
                b.Refresh();
            }
        }

        public static DateTime EmptyDate = Convert.ToDateTime("1001-01-01");

        public static void ViewModeButtons(List<ButtonAdv> btn, ViewMode vmode, string sender)
        {
            switch (vmode)
            {
                case ViewMode.Add:

                    BtnEnabled(btn[0], false); //DELETE
                    BtnEnabled(btn[1], false); //EDIT
                    BtnEnabled(btn[2], true); //CANCEL
                    BtnEnabled(btn[3], false); //ADD
                    BtnEnabled(btn[4], true); //SAVE
                    break;

                case ViewMode.Edit:

                    BtnEnabled(btn[0], false); //DELETE
                    BtnEnabled(btn[1], false); //EDIT
                    BtnEnabled(btn[2], true); //CANCEL
                    BtnEnabled(btn[3], false); //ADD
                    BtnEnabled(btn[4], true); //SAVE
                    break;

                case ViewMode.View:
                    if (sender == "UserInfo")
                    {
                        if ((Enums.AccessLevel)ApplicationSettings.LoggedUser.access_level == Enums.AccessLevel.Admin)
                        {
                            BtnEnabled(btn[3], true);
                            BtnEnabled(btn[1], true);
                            BtnEnabled(btn[0], true);
                        }
                        else
                        {
                            BtnEnabled(btn[3], false);
                            BtnEnabled(btn[1], false);
                            BtnEnabled(btn[0], false);
                        }
                    }
                    else
                    {
                        BtnEnabled(btn[3], true);
                        BtnEnabled(btn[1], true);
                        BtnEnabled(btn[0], true);
                    }

                    BtnEnabled(btn[2], false);
                    BtnEnabled(btn[4], false);
                    break;
            }
        }

        public enum ViewMode
        {
            View = 1,
            Edit = 2,
            Add = 3
        }
    }
}