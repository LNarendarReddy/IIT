using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace IIT
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Assembly asm = typeof(IITSkin).Assembly;
            DevExpress.Skins.SkinManager.Default.RegisterAssembly(asm);
            BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("IITSkin");
            Application.EnableVisualStyles();
            SkinManager.EnableFormSkins();
            SkinManager.EnableMdiFormSkins();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(frmSingularMain.Instance);
        }
    }
    public class SkinRegistration : Component
    {
        public SkinRegistration()
        {
            DevExpress.Skins.SkinManager.Default.RegisterAssembly(typeof(IITSkin).Assembly);
        }
    }
}
