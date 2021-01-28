using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NotepadPlus
{
    /// <summary>
    /// Сущность, представляющая собой
    /// вкладку в окне редактора и
    /// содержащая информацию о соответствующем
    /// файле.
    /// </summary>
    public partial class Session : TabPage
    {
        /// <summary>
        /// Способ создания сессии путем загрузки
        /// существующего файла из файловой системы.
        /// </summary>
        /// <param name="stream">Stream.</param>
        /// <param name="path">Полный путь к файлу на диске.</param>
        /// <returns>Объект новой сессии.</returns>
        public static Session LoadFile(Stream stream, string path)
        {
            StreamReader sr = new StreamReader(stream);

            path = Path.GetFullPath(path);

            FileType type = Utils.DetermineFileType(sr, path);
            
            Session newSession = new Session(path, type);
            newSession.SetContent(sr.ReadToEnd());
            newSession.FilePath = path;
            newSession.HasPath = true;
            newSession.Saved = true;

            sr.Close();

            return newSession;
        }
        
        private RichTextBox _textArea;
        private FontDialog _fontDialog;
        private ColorDialog _colorDialog;

        /// <summary>
        /// Свойство показывает, существует ли
        /// уже файл на диске или был создан
        /// только что и ни разу не сохранялся.
        /// </summary>
        public bool HasPath { get; private set; }

        /// <summary>
        /// Свойство показывает, нет
        /// ли в файле несохраненных изменений.
        /// </summary>
        public bool Saved { get; private set; }

        /// <summary>
        /// Полный путь к файлу на диске.
        /// </summary>
        public string FilePath { get; private set; }

        /// <summary>
        /// Формат файла.
        /// </summary>
        public FileType Type { get; private set; }
        
        /// <summary>
        /// Обертка для величины масштабирования
        /// текста в RichTextBox.
        /// </summary>
        public float ZoomFactor
        {
            get => _textArea.ZoomFactor;
            set
            {
                if (value <= 0.1 || value >= 10) return;
                _textArea.ZoomFactor = value;
            }
        }
        
        /// <summary>
        /// Контекстное меню, которое вызывается
        /// с помощью ПКМ.
        /// </summary>
        public FormatContextMenu ContextMenu { get; }


        public Session(string title, FileType type) : base(title)
        {
            _textArea = new RichTextBox {Dock = DockStyle.Fill};
            _fontDialog = new FontDialog();
            _colorDialog = new ColorDialog();

            SetupTextArea();
            
            Controls.Add(_textArea);
            
            Type = type;
            HasPath = false;
            Saved = true;
            FilePath = string.Empty;
            ContextMenu = new FormatContextMenu(this);
        }

        private void SetupTextArea()
        {
            _textArea.Multiline = true;
            _textArea.BorderStyle = BorderStyle.None;
            _textArea.SelectionChanged += OnSelectionChange;
            _textArea.TextChanged += OnTextChange;
            _textArea.ContextMenuStrip = ContextMenu;

        }

        public void WriteChangesToFile()
        {
            if (!HasPath) return;

            StreamWriter sw = new StreamWriter(FilePath);

            switch (Type)
            {
                case FileType.PlainText:
                    sw.Write(_textArea.Text);
                    break;
                case FileType.RichText:
                    sw.Write(_textArea.Rtf);
                    break;
            }

            sw.Close();
            MakeSaved();
        }

        public void SaveFileAs(Stream s, string path)
        {
            if (Type == FileType.PlainText)
            {
                s.Write(Encoding.ASCII.GetBytes(_textArea.Text));
            }
            else if (Type == FileType.RichText)
            {
                s.Write(Encoding.ASCII.GetBytes(_textArea.Rtf));
            }
            
            s.Close();
            FilePath = path;
            Text = path;
            MakeSaved();
        }

        public string GetRtfContent()
        {
            return _textArea.Rtf;
        }

        public void SetContent(string content)
        {
            if (Type == FileType.PlainText)
            {
                _textArea.Text = content;
            }
            else if (Type == FileType.RichText)
            {
                _textArea.Rtf = content;
            }
        }

        public string GetTextContent()
        {
            return _textArea.Text;
        }

        private void MakeSaved()
        {
            Saved = true;
            HasPath = true;
            Text = Path.GetFileName(FilePath);
            if (Type == FileType.PlainText) ForeColor = Color.CornflowerBlue;
        }

        private void MakeUnsaved()
        {
            Saved = false;
            Text = Path.GetFileName(FilePath) + " *";
        }

        public void SetSelectionFont(Font f)
        {
            _textArea.SelectionFont = f;
        }

        public void SetSelectionColor(Font f)
        {
            _textArea.SelectionFont = f;
        }
        
    }
}