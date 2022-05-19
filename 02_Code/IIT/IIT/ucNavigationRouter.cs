using DevExpress.XtraGrid.Columns;
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
        Action<string> actionExecute;

        public override string Caption => caption;

        public ucNavigationRouter(IEnumerable<string> buttons, string _caption, Action<string> _actionExecute)
        {
            InitializeComponent();
            buttonsList = buttons.Select(x => new ActionText() { Action = x }).ToList();
            caption = _caption;
            actionExecute = _actionExecute;
        }

        private void ucNavigationRouter_Load(object sender, EventArgs e)
        {
            Utility.SetGridFormatting(gvButtons);

            gcButtons.DataSource = buttonsList;
            lblHeader.Text = Caption;
            UpdateGridSize();
            
        }

        private void gvButtons_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle < 0) return;
            e.Info.DisplayText = $"{e.RowHandle + 1}";
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
                catch (Exception ex){ }
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
            actionExecute(Convert.ToString(gvButtons.GetRowCellValue(gvButtons.FocusedRowHandle, "Action")));
        }

        private void gcButtons_KeyUp(object sender, KeyEventArgs e)
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

    class ActionText { public string Action { get; set; } }
}
