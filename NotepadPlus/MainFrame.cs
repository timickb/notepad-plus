using System.IO;
using System.Windows.Forms;

namespace NotepadPlus
{
    public partial class MainFrame : Form
    {
        private FontDialog _fontDialog;
        private ColorDialog _colorDialog;

        public MainFrame()
        {
            InitializeComponent();

            Closing += OnApplicationExit;
            TabIndexChanged += OnTabSwitched;

            // При запуске программы автоматически создается новый файл.
            tabControl.Controls.Add(new Session("New file", FileType.PlainText));

            _fontDialog = new FontDialog();
            _colorDialog = new ColorDialog();
            
        }

        public DialogResult OpenDialogForUnsavedFile(Session s)
        {
            DialogResult result = MessageBox.Show(
                $"В файле {s.FilePath} остались несохраненные изменения. Хотите их сохранить?",
                "Несохраненные изменения",
                MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                OpenSaveFileDialog(s);
            }

            return result;
        }

        public void OpenSaveFileDialog(Session s)
        {
            SaveFileDialog sfd = new SaveFileDialog {Filter = "", RestoreDirectory = true};
            Stream stream;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // ReSharper disable once ConditionIsAlwaysTrueOrFalse
                if ((stream = sfd.OpenFile()) != null)
                {
                    s.SaveFileAs(stream, sfd.FileName);
                }
            }
        }
        
        public Session GetCurrentTab()
        {
            return (Session) tabControl.Controls[tabControl.SelectedIndex];
        }
        
    }
}