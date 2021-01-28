using System;
using System.Windows.Forms;

namespace NotepadPlus
{
    public partial class Session
    {
        public void OnBufferPaste(object sender, EventArgs e)
        {
            DataFormats.Format format;
            format = DataFormats.GetFormat(Type == FileType.RichText ? DataFormats.Rtf : DataFormats.Text);

            if (_textArea.CanPaste(format))
            {
                _textArea.Paste(format);
            }
        }

        public void OnSelectionCopy(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(_textArea.SelectedText);
        }

        public void OnSelectionRtfCopy(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(_textArea.SelectedRtf);
        }

        public void OnSelectedAll(object sender, EventArgs e)
        {
            _textArea.SelectAll();
        }

        public void OnCutSelection(object sender, EventArgs e)
        {
            _textArea.Cut();
        }

        public void OnForeColorChange(object sender, EventArgs e)
        {
            if (_colorDialog.ShowDialog() == DialogResult.OK)
            {
                _textArea.SelectionColor = _colorDialog.Color;
            }
            if (Type == FileType.RichText) Saved = false;
        }

        public void OnFontChange(object sender, EventArgs e)
        {
            if (_fontDialog.ShowDialog() == DialogResult.OK)
            {
                _textArea.SelectionFont = _fontDialog.Font;
            }
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
    }
}