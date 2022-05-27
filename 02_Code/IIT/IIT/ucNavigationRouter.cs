﻿using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Scrolling;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace IIT
{
    public partial class ucNavigationRouter : NavigationBase
    {
        List<ActionText> buttonsList;
        private const int GridMinWidth = 300;
        private const int GridMinHeight = 100;
        private string caption;

        public override IEnumerable<ActionText> HelpText => buttonsList;

        public override string Caption => caption;

        public ucNavigationRouter(IEnumerable<string> buttons, string _caption)
        {
            InitializeComponent();
            int i = 1;
            buttonsList = buttons.Select(x => new ActionText(x, i++)).ToList();
            caption = _caption;
        }

        private void ucNavigationRouter_Load(object sender, EventArgs e)
        {
            gcButtons.DataSource = buttonsList;
            lblHeader.Text = Caption;
            gvButtons.BestFitColumns();
            UpdateGridSize();
        }

        private void UpdateGridSize()
        {
            GridViewInfo viewInfo = (GridViewInfo)gvButtons.GetViewInfo();
            FieldInfo fi = typeof(GridView).GetField("scrollInfo", BindingFlags.Instance | BindingFlags.NonPublic);
            ScrollInfo scrollInfo = (ScrollInfo)fi.GetValue(gvButtons);
            int width = viewInfo.ViewRects.IndicatorWidth;
            foreach (GridColumn column in gvButtons.VisibleColumns)
            {
                if (viewInfo.GetColumnLeftCoord(column) < viewInfo.ViewRects.ColumnPanelWidth)
                    gvButtons.LeftCoord = width;
                try
                {
                    width += viewInfo.ColumnsInfo[column].Bounds.Width;
                }
                catch (Exception ex) { }
            }
            if (scrollInfo.VScrollVisible) width += scrollInfo.VScrollSize;
            int height = viewInfo.CalcRealViewHeight(new Rectangle(0, 0, ClientSize.Width, ClientSize.Height), true);
            if (scrollInfo.HScrollVisible) height += scrollInfo.HScrollSize;
            width = Math.Max(GridMinWidth, width);
            width = Math.Min(ClientSize.Width - gcButtons.Location.X, width);
            height = Math.Max(GridMinHeight, height);
            height = Math.Min(ClientSize.Height - gcButtons.Location.Y, height);
            gcButtons.Size = new Size(width, height);
            gvButtons.LayoutChanged();
        }

        private void gcButtons_Click(object sender, EventArgs e)
        {
            ActionExecute(Convert.ToString(gvButtons.GetRowCellValue(gvButtons.FocusedRowHandle, "Action")));
        }

        public virtual void ActionExecute(string actionText) => throw new NotImplementedException();

        private void gcButtons_KeyDown(object sender, KeyEventArgs e)
        {
            int inputNumber = gvButtons.FocusedRowHandle + 1;
            if (e.KeyCode != Keys.Enter)
            {
                if (!e.Control || !char.IsNumber((char)e.KeyCode)
                    || !int.TryParse(((char)e.KeyCode).ToString(), out inputNumber) || !(inputNumber > 0) || !(inputNumber <= gvButtons.RowCount))
                    return;
            }

            gvButtons.FocusedRowHandle = inputNumber - 1;
            gcButtons_Click(sender, e);
        }
    }
}
