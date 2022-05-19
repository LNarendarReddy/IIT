namespace IIT
{
    public class ActionText
    {
        public int SNo { get; set; }

        public string Action { get; set; }

        public string Shortcut { get; set; }

        internal ActionText(string action, int sno = 0, bool buildShort = true, string shortCut = "")
        {
            SNo = sno;
            Action = action;
            Shortcut = buildShort ? $"Ctrl + {SNo}" : shortCut;
        }
    }
}
