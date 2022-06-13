namespace IIT
{
    public class ActionText
    {
        public int SNo { get; set; }

        public string Action { get; set; }

        public string Shortcut { get; set; }

        public bool IsHeader { get; set; }

        internal ActionText(string action, int sno = 0, bool buildShort = true, string shortCut = "", bool isHeader = false)
        {
            Action = action;
            IsHeader = isHeader;
            if (!isHeader)
            {
                SNo = sno;
                Shortcut = buildShort ? $"Ctrl + {SNo}" : shortCut;
            }
        }
    }
}
