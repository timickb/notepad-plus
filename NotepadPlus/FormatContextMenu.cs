using System.Windows.Forms;

namespace NotepadPlus
{
    public sealed class FormatContextMenu : ContextMenuStrip
    {
        private ToolStripMenuItem copyMenuItem;
        private ToolStripMenuItem pasteMenuItem;
        private ToolStripMenuItem selectAllMenuItem;
        private ToolStripMenuItem cutMenuItem;
        private ToolStripMenuItem fontChangeMenuItem;
        private ToolStripMenuItem colorChangeMenuItem;

        /// <summary>
        /// Контекстному меню необходима информация о том,
        /// с каким типом файла оно работает, чтобы оно
        /// могло отключить возможности форматирования текста.
        /// </summary>
        private Session _session;
        
        public FormatContextMenu(Session s)
        {
            _session = s;

            copyMenuItem = new ToolStripMenuItem("Копировать");
            pasteMenuItem = new ToolStripMenuItem("Вставить");
            selectAllMenuItem = new ToolStripMenuItem("Выделить все");
            cutMenuItem = new ToolStripMenuItem("Вырезать");
            fontChangeMenuItem = new ToolStripMenuItem("Изменить шрифт");
            colorChangeMenuItem = new ToolStripMenuItem("Изменить цвет текста");
            

            copyMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            pasteMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            cutMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            selectAllMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            fontChangeMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.F;
            colorChangeMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.C;

            Items.Add(copyMenuItem);
            Items.Add(pasteMenuItem);
            Items.Add(selectAllMenuItem);
            Items.Add(cutMenuItem);
            Items.Add(fontChangeMenuItem);
            Items.Add(colorChangeMenuItem);
            
            if (s.Type == FileType.RichText)
            {
                fontChangeMenuItem.Enabled = false;
                colorChangeMenuItem.Enabled = false;
            }

            copyMenuItem.Click += s.OnSelectionCopy;
            pasteMenuItem.Click += s.OnBufferPaste;
            selectAllMenuItem.Click += s.OnSelectedAll;
            cutMenuItem.Click += s.OnCutSelection;
            fontChangeMenuItem.Click += s.OnFontChange;
            colorChangeMenuItem.Click += s.OnForeColorChange;

        }
    }
}