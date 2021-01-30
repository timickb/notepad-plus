using System.Windows.Forms;
using NotepadPlus.UI;

namespace NotepadPlus
{
    public sealed class FormatContextMenu : ContextMenuStrip
    {
        private readonly NToolStripMenuItem _copyMenuItem;
        private readonly NToolStripMenuItem _pasteMenuItem;
        private readonly NToolStripMenuItem _selectAllMenuItem;
        private readonly NToolStripMenuItem _cutMenuItem;
        private readonly NToolStripMenuItem _fontChangeMenuItem;
        private readonly NToolStripMenuItem _colorChangeMenuItem;

        /// <summary>
        /// Контекстному меню необходима информация о том,
        /// с каким типом файла оно работает, чтобы оно
        /// могло отключить возможности форматирования текста.
        /// </summary>
        private Session _session;
        
        public FormatContextMenu(Session s)
        {
            _session = s;

            _copyMenuItem = new NToolStripMenuItem("Копировать");
            _pasteMenuItem = new NToolStripMenuItem("Вставить");
            _selectAllMenuItem = new NToolStripMenuItem("Выделить все");
            _cutMenuItem = new NToolStripMenuItem("Вырезать");
            _fontChangeMenuItem = new NToolStripMenuItem("Изменить шрифт");
            _colorChangeMenuItem = new NToolStripMenuItem("Изменить цвет текста");
            

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
            
            if (s.Type == FileType.PlainText)
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
            // KOSTYL: пришлось создавать копии пунктов меню (дублирование
            // огромного куска кода из конструктора выше). Оправадание:
            // торопился к дедлайну,а передача их по ссылке не работала правильно.
            NToolStripMenuItem copyMenuItem = new NToolStripMenuItem(_copyMenuItem.Text);
            NToolStripMenuItem pasteMenuItem = new NToolStripMenuItem(_pasteMenuItem.Text);
            NToolStripMenuItem selectAllMenuItem = new NToolStripMenuItem(_selectAllMenuItem.Text);
            NToolStripMenuItem cutMenuItem = new NToolStripMenuItem(_cutMenuItem.Text);
            NToolStripMenuItem colorChangeMenuItem = new NToolStripMenuItem(_colorChangeMenuItem.Text);
            NToolStripMenuItem fontChangeMenuItem = new NToolStripMenuItem(_fontChangeMenuItem.Text);
            
            copyMenuItem.Click += _session.OnSelectionCopy;
            pasteMenuItem.Click += _session.OnBufferPaste;
            selectAllMenuItem.Click += _session.OnSelectedAll;
            cutMenuItem.Click += _session.OnCutSelection;
            fontChangeMenuItem.Click += _session.OnFontChange;
            colorChangeMenuItem.Click += _session.OnForeColorChange;
            
            if (_session.Type == FileType.PlainText)
            {
                fontChangeMenuItem.Enabled = false;
                colorChangeMenuItem.Enabled = false;
            }
            
            copyMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            pasteMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            cutMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            selectAllMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            fontChangeMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.F;
            colorChangeMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.C;
            
            return new ToolStripItem[]
            {
                copyMenuItem, 
                pasteMenuItem,
                selectAllMenuItem,
                cutMenuItem,
                fontChangeMenuItem,
                colorChangeMenuItem
            };
        }
    }
}