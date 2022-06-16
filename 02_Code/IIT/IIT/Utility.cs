using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;

namespace IIT
{
    public static class Utility
    {
        public static EntityData CurrentEntity { get; set; }

        //public static object AssetsHeadID = 15;
        //public static object LiabilitiesHeadID = 16;
        //public static object IncomeHeadID = 17;
        //public static object ExpensesHeadID = 18;

        public static string UserName = "Test User";
        public static string ReportsPath = String.Empty;
        public static string CompanyPath = String.Empty;
        private static DataTable dtLedgers = null;
        private static DataTable dtBankingLedgers = null;
        private static DataTable dtNonCashLedgers = null;
        private static Dictionary<string, object> configData = null;

        public static string Caption = "India\'s Integrated Tax Software (IIT)";

        public static DataTable GetLedgers()
        {
            if(dtLedgers == null)
                dtLedgers = new LedgerRepository().GetLedgerList(CurrentEntity.ID);
            return dtLedgers;
        }
        public static DataTable GetBankingLedgers()
        {
            if(dtBankingLedgers == null)
            {
                DataTable dt = GetLedgers().Copy();
                DataView dv = dt.DefaultView;
                dv.RowFilter = "SUBGROUPNAME = 'Bank Balances'";
                dtBankingLedgers = dv.ToTable();
            }
            return dtBankingLedgers;
        }
        public static DataTable GetNonCashLedgers()
        {
            if (dtNonCashLedgers == null)
            {
                DataTable dt = GetLedgers().Copy();
                DataView dv = dt.DefaultView;
                dv.RowFilter = "SUBGROUPNAME <> 'Cash in Hand'";
                dtNonCashLedgers = dv.ToTable();
            }
            return dtNonCashLedgers;
        }
        public static void ClearLedgerCache()
        {
            dtLedgers = null;
            dtBankingLedgers = null;
            dtNonCashLedgers = null;
        }
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
                if(userControl.PreviousControl != null) userControl.PreviousControl.Visible = false;
            }

            frmSingularMain.Instance.pcMain.Controls.Clear();
            frmSingularMain.Instance.pcMain.Controls.Add(userControl);
            //frmSingularMain.Instance.tpMain.SetCell(userControl, 1, 1);
            frmSingularMain.Instance.CurrentControl = userControl;
            userControl.Focus();

            var helpText = userControl.HelpText.ToList();
            helpText.AddRange(new List<ActionText>() 
            {
                new ActionText("Select", buildShort: false, shortCut: "Enter") 
                , new ActionText("Close", buildShort: false, shortCut: "Esc")
            });

            frmSingularMain.Instance.gcHelpText.DataSource = helpText;
            string selectedEntityName = Convert.ToString(CurrentEntity?.EntityName ?? Caption);
            //frmSingularMain.Instance.Text = selectedEntityName;
            frmSingularMain.Instance.lblEntityName.Text = selectedEntityName;
            frmSingularMain.Instance.lblNavigationHeader.Text = userControl.Header;
            frmSingularMain.Instance.lcQuickOptions.Visible = userControl.ShowQuickOptions;

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
            Image image = null; 
            try
            {
                if (b == null)
                    return null;
                MemoryStream memStream = new MemoryStream();
                memStream.Write(b, 0, b.Length);
                image = Image.FromStream(memStream);
            }
            catch (Exception ex){}
            return image;
        }
        public static string ConvertNum(double? numbers,bool paisaconversion = false) // Call this function passing the number you desire to be changed
        {
            var pointindex = numbers.ToString().IndexOf(".");
            var paisaamt = 0;
            if (pointindex > 0)
            {
                paisaamt = Convert.ToInt32(numbers.ToString().Substring(pointindex + 1, numbers.ToString().Length - pointindex - 1));
                paisaamt = paisaamt < 10 ? paisaamt * 10 : paisaamt;
            }

            long number = Convert.ToInt64(numbers);

            if (number == 0) return "Zero";
            if (number == -2147483648) return "Minus Two Hundred and Fourteen Crore Seventy Four Lakh Eighty Three Thousand Six Hundred and Forty Eight";
            long[] num = new long[6];
            int first = 0;
            long u, h, t;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            if (number < 0)
            {
                sb.Append("Minus ");
                number = -number;
            }
            string[] words0 = { "", "One ", "Two ", "Three ", "Four ", "Five ", "Six ", "Seven ", "Eight ", "Nine " };
            string[] words1 = { "Ten ", "Eleven ", "Twelve ", "Thirteen ", "Fourteen ", "Fifteen ", "Sixteen ", "Seventeen ", "Eighteen ", "Nineteen " };
            string[] words2 = { "Twenty ", "Thirty ", "Forty ", "Fifty ", "Sixty ", "Seventy ", "Eighty ", "Ninety " };
            string[] words3 = { "Thousand ", "Lakh ", "Crore " };
            num[0] = number % 1000; // units
            num[1] = number / 1000;
            num[2] = number / 100000;
            num[1] = num[1] - 100 * num[2]; // thousands
            num[3] = number / 10000000; // crores
            num[2] = num[2] - 100 * num[3]; // lakhs
            num[4] = number / 10000000000; // thousand crores
            num[3] = num[3] - 1000 * num[4];

            for (int i = 5; i > 0; i--)
            {
                if (num[i] != 0)
                {
                    first = i;
                    break;
                }
            }
            for (int i = first; i >= 0; i--)
            {
                if (num[i] == 0) continue;
                u = num[i] % 10; // ones
                t = num[i] / 10;
                h = num[i] / 100; // hundreds
                t = t - 10 * h; // tens
                if (h > 0) sb.Append(words0[h] + "Hundred ");
                if (u > 0 || t > 0)
                {
                    if (h > 0 || i == 0) sb.Append("and ");
                    if (t == 0)
                        sb.Append(words0[u]);
                    else if (t == 1)
                        sb.Append(words1[u]);
                    else
                        sb.Append(words2[t - 2] + words0[u]);
                }
                
                int wordIndex = i > 3 ? i - 3 : i;
                if (wordIndex != 0) 
                {
                    sb.Append(words3[wordIndex - 1]); 
                }
            }

            if (paisaamt == 0 && paisaconversion == false)
            {
                sb.Append("ruppes only");
            }
            else if (paisaamt > 0)
            {
                var paisatext = ConvertNum(paisaamt, true);
                sb.AppendFormat("rupees and {0} paise only", paisatext);
            }
            return sb.ToString().TrimEnd();
        }
        public static Tuple<DateTime, DateTime> GetFinYear(DateTime inputDate)
        {
            DateTime startDate = new DateTime(inputDate.Month < 4 ? inputDate.Year - 1 : inputDate.Year, 4, 1);
            DateTime endDate = new DateTime(startDate.Year + 1, 3, 31);
            return new Tuple<DateTime, DateTime>(startDate, endDate);
        }

        public static T GetConfigValue<T>(string configName)
        {
            configData = configData ??
                    (configData = new LookUpRepository().GetConfig().AsEnumerable().ToDictionary(x => x["CONFIGNAME"].ToString(), x => x["CONFIGVALUE"]));
            if (configData.ContainsKey(configName))
            { 
                return (T)configData[configName]; 
            }
            
            if(configName.EndsWith("FROMDATE"))
            {
                return (T)((object)GetFinYear(DateTime.Now).Item1);
            }

            if (configName.EndsWith("TODATE"))
            {
                return (T)((object)GetFinYear(DateTime.Now).Item2);
            }

            if(configName.EndsWith("NARRATIONVISIBLE"))
            {
                return (T)(object)"No";
            }

            return default(T);
        }

        public static AdminSettings GetAdminSettings()
        {
            return new AdminSettings()
                {
                    FromDate = GetConfigValue<DateTime>("FROMDATE"),
                    ToDate = GetConfigValue<DateTime>("TODATE"),
                    ShowPurpose = GetConfigValue<string>("NARRATIONVISIBLE")
                };
        }

        public static void RefreshConfigData()
        {
            configData = null;
        }
    }


    public class AdminSettings
    {
        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public string ShowPurpose { get; set; }

    }
}
