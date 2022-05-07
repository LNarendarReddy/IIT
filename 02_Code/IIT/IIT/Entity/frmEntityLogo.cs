﻿using DevExpress.XtraEditors;
using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmEntityLogo : DevExpress.XtraEditors.XtraForm
    {
        EntityData entityData = null;
        public frmEntityLogo(EntityData _entityData)
        {
            InitializeComponent();
            entityData = _entityData;
        }

        private void frmEntityLogo_Load(object sender, EventArgs e)
        {
            pELogo.Image = Utility.BinaryToImage(entityData.LogoData);
            pELogo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Never;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (pELogo.Image != null)
                {
                    entityData.LogoData = Utility.ConvertImagetoBinary(pELogo.Image);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}