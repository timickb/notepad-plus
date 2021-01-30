using System.Drawing;
using System.Windows.Forms;

namespace NotepadPlus.UI
{
    public class NToolStripDropDownButton : ToolStripDropDownButton
    {
        /// <summary>
        /// Меняет цветовую схему элемента контроля
        /// одну из списка UITheme.
        /// </summary>
        /// <param name="theme"></param>
        public void SetTheme(UITheme theme)
        {
            if (theme == UITheme.Default)
            {
                ForeColor = Color.Black;
                BackColor = Color.White;
            }
            else if (theme == UITheme.Dark)
            {
                ForeColor = Color.White;
                BackColor = Color.DimGray;
            }
        }
    }
}