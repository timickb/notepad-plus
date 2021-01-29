using System.IO;
using System.Windows.Forms;

namespace NotepadPlus
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();

            Closing += OnApplicationExit;
            tabControl.SelectedIndexChanged += OnTabSwitched;
            
            fileMenuItemCreatePlaintext.PerformClick();
            dropdownFormatButton.DropDownItems.AddRange(GetCurrentTab().ContextMenu.GetRangeOfItems());

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