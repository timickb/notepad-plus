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