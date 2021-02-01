using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using NotepadPlus.UI;

namespace NotepadPlus
{
    public partial class MainFrame : Form
    {
        private Configuration _config;
        public MainFrame(Configuration config)
        {
            _config = config;
            
            Program.OpenedFrames.Add(this);
            InitializeComponent();

            Closing += OnFormClosing;
            tabControl.SelectedIndexChanged += OnTabSwitched;

            fileMenuItemCreatePlaintext.PerformClick();
            dropdownFormatButton.DropDownItems.AddRange(GetCurrentTab().ContextMenu.GetRangeOfItems());

            SetApplicationUITheme(UITheme.Default);
            
            AutoSaver autoSaver = new AutoSaver(tabControl);
            autoSaver.Start();

        }

        public void SetApplicationUITheme(UITheme theme)
        {
            this.mainMenu.SetTheme(theme);
            this.dropdownFileButton.SetTheme(theme);
            this.fileMenuItemCreate.SetTheme(theme);
            this.fileMenuItemCreatePlaintext.SetTheme(theme);
            this.fileMenuItemCreateRtf.SetTheme(theme);
            this.fileMenuItemOpen.SetTheme(theme);
            this.fileMenuItemSave.SetTheme(theme);
            this.fileMenuItemSaveAs.SetTheme(theme);
            this.fileMenuItemSaveAll.SetTheme(theme);
            this.fileMenuItemOpenNewWindow.SetTheme(theme);
            this.toolStripSeparator2.SetTheme(theme);
            this.fileMenuItemClose.SetTheme(theme);
            this.fileMenuItemExit.SetTheme(theme);
            this.dropdownEditButton.SetTheme(theme);
            this.dropdownFormatButton.SetTheme(theme);
            this.dropdownSettingsButton.SetTheme(theme);
            this.zoomInMenuItem.SetTheme(theme);
            this.zoomOutMenuItem.SetTheme(theme);
            this.zoomResetMenuItem.SetTheme(theme);
            this.toolStripSeparator1.SetTheme(theme);
            this.editorSettingsMenuItem.SetTheme(theme);
            this.dropdownInfoButton.SetTheme(theme);
            this.infoMenuItemAbout.SetTheme(theme);
            this.tabControl.SetTheme(theme);
            
            foreach(Session s in tabControl.Controls)
            {
                s.SetTheme(theme);
            }
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

        public void WriteChangesToConfig()
        {
            string jsonData = JsonConvert.SerializeObject(_config);

            try
            {
                StreamWriter sw = new StreamWriter("appsettings.json");
                sw.Write(jsonData);
                sw.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно записать настройки в файл.", "Ошибка");
            }
        }
    }
}