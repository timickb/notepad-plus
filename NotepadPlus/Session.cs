using System;
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
    public class Session : TabPage
    {
        private RichTextBox _textArea;

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


        public Session(string title, FileType type) : base(title)
        {
            _textArea = new RichTextBox {Dock = DockStyle.Fill};
            SetupTextArea();
            Controls.Add(_textArea);
            Type = type;
            HasPath = false;
            Saved = true;
            FilePath = string.Empty;
        }

        private void SetupTextArea()
        {
            _textArea.Multiline = true;
            _textArea.BorderStyle = BorderStyle.None;
            _textArea.SelectionChanged += OnSelectionChange;
            _textArea.TextChanged += OnTextChange;
            _textArea.FontChanged += OnFontChange;
            _textArea.ForeColorChanged += OnForeColorChange;
        }

        private void OnForeColorChange(object sender, EventArgs e)
        {
            if (Type == FileType.RichText) Saved = false;
        }

        private void OnFontChange(object sender, EventArgs e)
        {
            if (Type == FileType.RichText) Saved = false;
        }

        private void OnSelectionChange(object sender, EventArgs e)
        {
            MakeUnsaved();
        }

        private void OnTextChange(object sender, EventArgs e)
        {
            MakeUnsaved();
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

        public string GetTextContent()
        {
            return _textArea.Text;
        }

        private void MakeSaved()
        {
            Saved = true;
            HasPath = true;
            Text = Path.GetFileName(FilePath);
        }

        private void MakeUnsaved()
        {
            Saved = false;
            Text = Path.GetFileName(FilePath) + " *";
        }
    }
}