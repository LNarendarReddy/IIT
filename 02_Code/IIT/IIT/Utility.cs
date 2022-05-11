using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace IIT
{
    public static class Utility
    {
        public static EntityData CurrentEntity { get; set; }

        public static string UserName = "Test User";
        public static string ReportsPath = String.Empty;
        public static string CompanyPath = String.Empty;
        public static void ShowDialog(XtraForm frm)
        {
            frm.ShowInTaskbar  = false;
            frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;    
            frm.WindowState = System.Windows.Forms.FormWindowState.Normal;
            frm.IconOptions.ShowIcon = false;
            frm.ControlBox = false;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            frm.ShowDialog();
        }

        public static void ShowDialog(NavigationBase userControl)
        {
            if (userControl == null) return;

            userControl.Dock = System.Windows.Forms.DockStyle.Fill;            
            userControl.AutoSize = true;
            if(frmSingularMain.Instance.pcMain.Controls.Count == 1 && userControl.PreviousControl == null)
            {
                userControl.PreviousControl = frmSingularMain.Instance.pcMain.Controls[0] as NavigationBase;
            }

            frmSingularMain.Instance.pcMain.Controls.Clear();
            frmSingularMain.Instance.pcMain.Controls.Add(userControl);
            //frmSingularMain.Instance.tpMain.SetCell(userControl, 1, 1);
            userControl.Focus();

            var helpText = userControl.HelpText.ToList();
            helpText.AddRange( new List<string>() { "Enter ==> Select", "Esc ==> Close" });

            frmSingularMain.Instance.lblHelpText.Text = string.Join(Environment.NewLine + Environment.NewLine, helpText);
        }

        public static void SetGridFormatting(GridView gridView)
        {
            gridView.Appearance.HeaderPanel.Font = new Font("Arial", 9F, FontStyle.Bold);
            gridView.Appearance.HeaderPanel.ForeColor = Color.White;
            gridView.Appearance.HeaderPanel.Options.UseFont = true;
            gridView.Appearance.HeaderPanel.Options.UseForeColor = true;
            gridView.OptionsView.ShowGroupPanel = false;
        }

        public static void PropogateAddress(CheckEdit chkSame, BaseEdit source, BaseEdit target)
        {
            if (!chkSame.Checked) { return; }

            target.EditValue = source.EditValue;
        }

        public static void BindAddress(Address addressObj, bool enabled, TextEdit txtHno, TextEdit txtArea, TextEdit txtCity
            , TextEdit txtDistrict, LookUpEdit cmbState, TextEdit txtPinCode)
        {
            txtHno.Enabled = enabled;
            txtArea.Enabled = enabled;
            txtCity.Enabled = enabled;
            txtDistrict.Enabled = enabled;
            cmbState.Enabled = enabled;
            txtPinCode.Enabled = enabled;

            txtHno.EditValue = addressObj.HNo;
            txtArea.EditValue = addressObj.Area;
            txtCity.EditValue = addressObj.City;
            txtDistrict.EditValue = addressObj.District;
            cmbState.EditValue = addressObj.StateID;
            txtPinCode.EditValue = addressObj.PinCode;
        }

        public static object AssetsHeadID = 15;
        public static object LiabilitiesHeadID = 16;
        public static object IncomeHeadID = 17;
        public static object ExpensesHeadID = 18;

        public static byte[] ConvertImagetoBinary(Image img)
        {
            byte[] photo_aray = null;
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    photo_aray = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(photo_aray, 0, photo_aray.Length);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return photo_aray;
        }

        public static Image BinaryToImage(byte[] b)
        {
            if (b == null)
                return null;

            MemoryStream memStream = new MemoryStream();
            memStream.Write(b, 0, b.Length);
            return Image.FromStream(memStream);
        }

        public static string ConvertNum(long Input) // Call this function passing the number you desire to be changed
        {
            string output = null;
            if (Input < 1000)
                output = FindNumber(Input); // if its less than 1000 then just look it up
            else
            {
                string[] nparts; // used to break the number up into 3 digit parts
                string n = Input.ToString(); // string version of the number
                int i = Input.ToString().Length; // length of the string to help break it up

                while (!(i - 3 <= 0))
                {
                    n = n.Insert(i - 3, ","); // insert commas to use as splitters
                    i = i - 3; // this insures that we get the correct number of parts
                }
                nparts = n.Split(','); // split the string into the array

                i = Input.ToString().Length; // return i to initial value for reuse
                int p = 0; // p for parts, used for finding correct suffix
                foreach (string s in nparts)
                {
                    long x = Convert.ToInt64(s); // x is used to compare the part value to other values
                    p = p + 1;
                    if (p == nparts.Length)
                    {
                        if (x != 0)
                        {
                            if (Convert.ToInt64(s) < 100)
                                output = output + " And " + FindNumber(Convert.ToInt64(s)); // look up the number, no suffix 
                            else
                                output = output + " " + FindNumber(Convert.ToInt64(s));
                        }
                    }
                    else if (x != 0)
                    {
                        if (output == null)
                            output = output + FindNumber(Convert.ToInt64(s)) + " " + FindSuffix(i, Convert.ToInt64(s)); // look up the number and suffix
                        else
                            output = output + " " + FindNumber(Convert.ToInt64(s)) + " " + FindSuffix(i, Convert.ToInt64(s));// look up the snumber and suffix
                    }
                    i = i - 3; // reduce the suffix counter by 3 to step down to the next suffix
                }
            }
            return output + " Only";
        }

        private static string FindNumber(long Number)
        {
            string Words = null;
            string[] Digits = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };
            string[] Teens = new[] { "", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

            if (Number < 11)
                Words = Digits[Number];
            else if (Number < 20)
                Words = Teens[Number - 10];
            else if (Number == 20)
                Words = "Twenty";
            else if (Number < 30)
                Words = "Twenty " + Digits[Number - 20];
            else if (Number == 30)
                Words = "Thirty";
            else if (Number < 40)
                Words = "Thirty " + Digits[Number - 30];
            else if (Number == 40)
                Words = "Fourty";
            else if (Number < 50)
                Words = "Fourty " + Digits[Number - 40];
            else if (Number == 50)
                Words = "Fifty";
            else if (Number < 60)
                Words = "Fifty " + Digits[Number - 50];
            else if (Number == 60)
                Words = "Sixty";
            else if (Number < 70)
                Words = "Sixty " + Digits[Number - 60];
            else if (Number == 70)
                Words = "Seventy";
            else if (Number < 80)
                Words = "Seventy " + Digits[Number - 70];
            else if (Number == 80)
                Words = "Eighty";
            else if (Number < 90)
                Words = "Eighty " + Digits[Number - 80];
            else if (Number == 90)
                Words = "Ninety";
            else if (Number < 100)
                Words = "Ninety " + Digits[Number - 90];
            else if (Number < 1000)
            {
                Words = Number.ToString();
                Words = Words.Insert(1, ",");
                string[] wparts = Words.Split(',');
                Words = FindNumber(Convert.ToInt64(wparts[0])) + " " + "Hundred";
                string n = FindNumber(Convert.ToInt64(wparts[1]));
                if (Convert.ToInt64(wparts[1]) != 0)
                    Words = Words + " And " + n;
            }

            return Words;
        }

        private static string FindSuffix(long Length, long l)
        {
            string word;

            if (l != 0)
            {
                if (Length > 12)
                    word = "Trillion";
                else if (Length > 9)
                    word = "Billion";
                else if (Length > 6)
                    word = "Million";
                else if (Length > 3)
                    word = "Thousand";
                else if (Length > 2)
                    word = "Hundred";
                else
                    word = "";
            }
            else
                word = "";

            return word;
        }

        public static Tuple<DateTime, DateTime> GetFinYear(DateTime inputDate)
        {
            DateTime startDate = new DateTime(inputDate.Month < 4 ? inputDate.Year - 1 : inputDate.Year, 4, 1);
            DateTime endDate = new DateTime(startDate.Year + 1, 3, 31);
            return new Tuple<DateTime, DateTime>(startDate, endDate);
        }
    }
}
