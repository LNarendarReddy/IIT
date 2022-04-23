using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Entity;
using System.Drawing;

namespace IIT
{
    public static class Utility
    {
        public static string UserName = "Test User";
        public static void ShowDialog(XtraForm frm)
        {
            frm.ShowInTaskbar  = false;
            frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;    
            frm.WindowState = System.Windows.Forms.FormWindowState.Normal;
            frm.IconOptions.ShowIcon = false;
            frm.ShowDialog();
        }

        public static void SetGridFormatting(GridView gridView)
        {
            gridView.Appearance.HeaderPanel.Font = new Font("Arial", 9F, FontStyle.Bold);
            gridView.Appearance.HeaderPanel.ForeColor = Color.White;
            gridView.Appearance.HeaderPanel.Options.UseFont = true;
            gridView.Appearance.HeaderPanel.Options.UseForeColor = true;

            gridView.OptionsBehavior.Editable = false;
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
    }
}
