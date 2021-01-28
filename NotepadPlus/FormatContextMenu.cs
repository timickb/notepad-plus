using System.Windows.Forms;

namespace NotepadPlus
{
    public sealed class FormatContextMenu : ContextMenuStrip
    {
        private readonly ToolStripMenuItem _copyMenuItem;
        private readonly ToolStripMenuItem _pasteMenuItem;
        private readonly ToolStripMenuItem _selectAllMenuItem;
        private readonly ToolStripMenuItem _cutMenuItem;
        private readonly ToolStripMenuItem _fontChangeMenuItem;
        private readonly ToolStripMenuItem _colorChangeMenuItem;

        /// <summary>
        /// Контекстному меню необходима информация о том,
        /// с каким типом файла оно работает, чтобы оно
        /// могло отключить возможности форматирования текста.
        /// </summary>
        private Session _session;
        
        public FormatContextMenu(Session s)
        {
            _session = s;

            _copyMenuItem = new ToolStripMenuItem("Копировать");
            _pasteMenuItem = new ToolStripMenuItem("Вставить");
            _selectAllMenuItem = new ToolStripMenuItem("Выделить все");
            _cutMenuItem = new ToolStripMenuItem("Вырезать");
            _fontChangeMenuItem = new ToolStripMenuItem("Изменить шрифт");
            _colorChangeMenuItem = new ToolStripMenuItem("Изменить цвет текста");
            

            _copyMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            _pasteMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            _cutMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            _selectAllMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            _fontChangeMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.F;
            _colorChangeMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.C;

            Items.Add(_copyMenuItem);
            Items.Add(_pasteMenuItem);
            Items.Add(_selectAllMenuItem);
            Items.Add(_cutMenuItem);
            Items.Add(_fontChangeMenuItem);
            Items.Add(_colorChangeMenuItem);
            
            if (s.Type == FileType.RichText)
            {
                _fontChangeMenuItem.Enabled = false;
                _colorChangeMenuItem.Enabled = false;
            }

            _copyMenuItem.Click += s.OnSelectionCopy;
            _pasteMenuItem.Click += s.OnBufferPaste;
            _selectAllMenuItem.Click += s.OnSelectedAll;
            _cutMenuItem.Click += s.OnCutSelection;
            _fontChangeMenuItem.Click += s.OnFontChange;
            _colorChangeMenuItem.Click += s.OnForeColorChange;

        }
        
        /// <summary>
        /// Возвращает массив из пунктов меню для
        /// использования его в dropdownFormatButton.
        /// </summary>
        /// <returns></returns>
        public ToolStripItem[] GetRangeOfItems()
        {
            return new ToolStripItem[]
            {
                _copyMenuItem,
                _pasteMenuItem,
                _selectAllMenuItem,
                _cutMenuItem,
                _fontChangeMenuItem,
                _colorChangeMenuItem
            };
        }
    }
}