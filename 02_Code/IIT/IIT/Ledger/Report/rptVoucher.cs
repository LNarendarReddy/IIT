using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace IIT
{
    public partial class rptVoucher : DevExpress.XtraReports.UI.XtraReport
    {
        public rptVoucher()
        {
            InitializeComponent();
            Parameter imageParameter = new Parameter() { Type = typeof(byte[]), Name = "LogoData",Visible = false };
            this.Parameters.Add(imageParameter);
            pbLogo.DataBindings.Add(new XRBinding(imageParameter, "Image", string.Empty));
            imageParameter.Value = Utility.CurrentEntity.LogoData;
        }
    }
}
