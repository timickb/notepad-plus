using System.Drawing;
using System.Windows.Forms;

namespace NotepadPlus.UI
{
    public class NToolStrip : ToolStrip
    {
        public void SetTheme(UITheme theme)
        {
            if (theme == UITheme.Default)
            {
                BackColor = Color.White;
                ForeColor = Color.Black;
            }
            else if (theme == UITheme.Dark)
            {
                BackColor = Color.DimGray;
                ForeColor = Color.White;
            }
        }
    }
}