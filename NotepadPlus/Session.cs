using System;
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
        public bool Pathed { get; private set; }
        
        /// <summary>
        /// Свойство показывает, нет
        /// ли в файле несохраненных изменений.
        /// </summary>
        public bool Saved { get; private set; }
        
        public string Path { get; set; }


        public Session(string title) : base(title)
        {
            _textArea = new RichTextBox { Dock = DockStyle.Fill };
            SetupTextArea();
            Controls.Add(_textArea);
            
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

        }

        private void OnFontChange(object sender, EventArgs e)
        {

        }

        private void OnSelectionChange(object sender, EventArgs e)
        {
            
        }

        private void OnTextChange(object sender, EventArgs e)
        {
            
        }
    }
}