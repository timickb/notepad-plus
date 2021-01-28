using System;
using System.Windows.Forms;

namespace NotepadPlus
{
    public partial class MainFrame
    {
        private void OnAboutAppWindowOpen(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnCreateFile(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnCreateFileRtf(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnOpenFile(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnSaveFile(object sender, EventArgs e)
        {
            Session s = (Session) tabControl.Controls[tabControl.SelectedIndex];
            if (!s.HasPath)
            {
                OpenSaveFileDialog(s);
            }
            else
            {
                s.WriteChangesToFile();
            }
        }

        private void OnSaveFileAs(object sender, EventArgs e)
        {
            OpenSaveFileDialog(GetCurrentTab());
        }

        private void OnCloseCurrentTab(object sender, EventArgs e)
        {
            Session s = GetCurrentTab();
            if (!s.Saved)
            {
                DialogResult result = OpenDialogForUnsavedFile(s);
                if (result == DialogResult.No)
                {
                    tabControl.Controls.Remove(s);
                }
            }
            else
            {
                tabControl.Controls.Remove(s);
            }
        }

        private void OnFontChangeMenuItemClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnColorChangeMenuItemClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnExitMenuItemClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnZoomInClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnZoomOutClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnZoomResetClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnSettingsOpen(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            // Проверим наличие несохраненных вкладок.
            foreach (Session s in tabControl.Controls)
            {
                if (!s.Saved)
                {
                }
            }
        }
    }
}