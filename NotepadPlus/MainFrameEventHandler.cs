using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace NotepadPlus
{
    public partial class MainFrame
    {
        private void OnAboutAppWindowOpen(object sender, EventArgs e)
        {
            // TODO: окно "О программе".
        }

        private void OnCreateFile(object sender, EventArgs e)
        {
            // TODO: меню выбора формата файла.
        }

        private void OnCreateFileRtf(object sender, EventArgs e)
        {
            tabControl.Controls.Add(new Session("New file (RTF)", FileType.RichText));
        }

        private void OnCreateFileText(object sender, EventArgs e)
        {
            tabControl.Controls.Add(new Session("New file", FileType.PlainText));
        }

        private void OnOpenFile(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Session s = Session.LoadFile(openFileDialog.OpenFile(), openFileDialog.FileName);
                tabControl.Controls.Add(s);
            }
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
            if (_fontDialog.ShowDialog() == DialogResult.OK)
            {
                GetCurrentTab().SetSelectionFont(_fontDialog.Font);
            }
        }

        private void OnColorChangeMenuItemClick(object sender, EventArgs e)
        {
            if (_colorDialog.ShowDialog() == DialogResult.OK)
            {
                GetCurrentTab().SetSelectionFont(_fontDialog.Font);
            }
        }

        private void OnExitMenuItemClick(object sender, EventArgs e)
        {
            OnApplicationExit(sender, (CancelEventArgs) e);
        }

        private void OnZoomInClick(object sender, EventArgs e)
        {
            foreach (Session s in tabControl.Controls)
            {
                s.ZoomFactor = (float) (s.ZoomFactor + 0.2);
            }
        }

        private void OnZoomOutClick(object sender, EventArgs e)
        {
            foreach (Session s in tabControl.Controls)
            {
                s.ZoomFactor = (float) (s.ZoomFactor - 0.2);
            }
        }

        private void OnZoomResetClick(object sender, EventArgs e)
        {
            foreach (Session s in tabControl.Controls)
            {
                s.ZoomFactor = 1f;
            }
        }

        private void OnSettingsOpen(object sender, EventArgs e)
        {
            // TODO: Форма с настройками.
        }

        private void OnApplicationExit(object sender, CancelEventArgs e)
        {
            // Проверим наличие несохраненных вкладок.
            foreach (Session s in tabControl.Controls)
            {
                if (!s.Saved)
                {
                    DialogResult result = OpenDialogForUnsavedFile(s);

                    // Если пользователь нажал "отмена" в ответ на
                    // предложение сохранить файл - отменяем закрытие программы.
                    if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void OnTabSwitched(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}