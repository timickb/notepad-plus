using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NotepadPlus.UI;

namespace NotepadPlus
{
    /// <summary>
    /// Сущность, представляющая собой
    /// вкладку в окне редактора и
    /// содержащая информацию о соответствующем
    /// файле.
    /// </summary>
    public sealed partial class Session : TabPage
    {
        public const string UnsavedFileMark = "*";
        
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
        
        private RichTextBox _textArea = new RichTextBox {Dock = DockStyle.Fill};
        private FontDialog _fontDialog = new FontDialog();
        private ColorDialog _colorDialog = new ColorDialog();

        /// <summary>
        /// Свойство показывает, существует ли
        /// уже файл на диске или был создан
        /// только что и ни разу не сохранялся.
        /// </summary>
        [System.Text.Json.Serialization.JsonIgnore]
        public bool HasPath { get; private set; }

        /// <summary>
        /// Свойство показывает, нет
        /// ли в файле несохраненных изменений.
        /// </summary>
        [System.Text.Json.Serialization.JsonIgnore]
        public bool Saved { get; private set; }

        /// <summary>
        /// Полный путь к файлу на диске.
        /// </summary>
        [JsonPropertyName("filePath")]
        public string FilePath { get; private set; }

        /// <summary>
        /// Формат файла.
        /// </summary>
        [JsonPropertyName("fileType")]
        [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
        public FileType Type { get; private set; }
        
        /// <summary>
        /// Обертка для величины масштабирования
        /// текста в RichTextBox.
        /// </summary>
        [System.Text.Json.Serialization.JsonIgnore]
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
        [System.Text.Json.Serialization.JsonIgnore]
        public FormatContextMenu ContextMenu { get; }
        
        public Session(string title, FileType type) : base(title)
        {
            Type = type;
            HasPath = false;
            Saved = true;
            FilePath = title;
            ContextMenu = new FormatContextMenu(this);
            SetupTextArea();

        }

        [JsonConstructor]
        public Session(FileType fileType, string filePath)
        {
            Type = fileType;
            HasPath = true;
            Saved = true;
            FilePath = filePath;
            ContextMenu = new FormatContextMenu(this);

            try
            {
                StreamReader sr = new StreamReader(filePath);
                switch (Type)
                {
                    case FileType.PlainText:
                        _textArea.Text = sr.ReadToEnd();
                        break;
                    case FileType.RichText:
                        _textArea.Rtf = sr.ReadToEnd();
                        break;
                }
                sr.Close();
            }
            catch (Exception)
            {
                // жесть какая-то..., еще не придумал, что с этим можно сделать.
            }


            SetupTextArea();
        }

        private void SetupTextArea()
        {
            _textArea.Multiline = true;
            _textArea.BorderStyle = BorderStyle.None;
            _textArea.SelectionChanged += OnSelectionChange;
            _textArea.TextChanged += OnTextChange;
            
            /*ContextMenuStrip rightClickMenu = new ContextMenuStrip();
            ToolStripMenuItem copyItem = ContextMenu.CopyMenuItem;
            rightClickMenu.Items.Add(copyItem);
            _textArea.ContextMenuStrip = rightClickMenu;*/

            _textArea.ContextMenuStrip = ContextMenu;
            Controls.Add(_textArea);
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

        private void MakeSaved()
        {
            Saved = true;
            HasPath = true;
            Text = Path.GetFileName(FilePath);
            if (Type == FileType.PlainText) ForeColor = Color.CornflowerBlue;
        }

        private void MakeUnsaved()
        {
            if (!Saved) return;
            Saved = false;
            Text = $@"{Path.GetFileName(FilePath)} {UnsavedFileMark}";
        }

        public void SetTheme(UITheme theme)
        {
            switch (theme)
            {
                case UITheme.Default:
                {
                    _textArea.BackColor = Color.White;
                    if (Type == FileType.PlainText)
                    {
                        _textArea.ForeColor = Color.Black;
                    }

                    break;
                }
                case UITheme.Dark:
                {
                    _textArea.BackColor = Color.DimGray;
                    if (Type == FileType.PlainText)
                    {
                        _textArea.ForeColor = Color.White;
                    }

                    break;
                }
            }
        }
        
        /// <summary>
        /// Отменить последнее действие
        /// в текстовом поле.
        /// </summary>
        public void Undo()
        {
            if (_textArea.CanUndo)
            {
                _textArea.Undo();
            }
        }
        
        /// <summary>
        /// Отменить отмену последнего
        /// действия в текстовом поле.
        /// </summary>
        public void Redo()
        {
            if (_textArea.CanRedo)
            {
                _textArea.Redo();
            }
        }
        
        /// <summary>
        /// Изменяет формат текущего
        /// файла на текстовый.
        /// </summary>
        public void ConvertToPlaintext()
        {
            string text = _textArea.Text;
            _textArea.Clear();
            _textArea.Text = text;
            Type = FileType.PlainText;
        }
        /// <summary>
        /// Изменяет формат текущего
        /// файла на RTF.
        /// </summary>
        public void ConvertToRichtext()
        {
            Type = FileType.RichText;
        }

        public override string ToString()
        {
            return $"{Type}, {Name}";
        }
    }
}