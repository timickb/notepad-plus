using System.Drawing;

namespace NotepadPlus
{
    partial class MainFrame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.ToolStrip();
            this.dropdownFileButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.fileMenuItemCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuItemCreatePlaintext = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuItemCreateRtf = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fileMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dropdownEditButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.dropdownFormatButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.formatMenuItemChangeFont = new System.Windows.Forms.ToolStripMenuItem();
            this.formatMenuItemChangeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.dropdownSettingsButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.zoomInMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomResetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editorSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropdownInfoButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.infoMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = Color.White;
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dropdownFileButton,
            this.dropdownEditButton,
            this.dropdownFormatButton,
            this.dropdownSettingsButton,
            this.dropdownInfoButton});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenu.Size = new System.Drawing.Size(1366, 34);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "toolStrip1";
            // 
            // dropdownFileButton
            // 
            this.dropdownFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dropdownFileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItemCreate,
            this.fileMenuItemOpen,
            this.fileMenuItemSave,
            this.fileMenuItemSaveAs,
            this.toolStripSeparator2,
            this.fileMenuItemClose,
            this.fileMenuItemExit});
            this.dropdownFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dropdownFileButton.Name = "dropdownFileButton";
            this.dropdownFileButton.Size = new System.Drawing.Size(71, 29);
            this.dropdownFileButton.Text = "Файл";
            // 
            // fileMenuItemCreate
            // 
            this.fileMenuItemCreate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItemCreatePlaintext,
            this.fileMenuItemCreateRtf});
            this.fileMenuItemCreate.Name = "fileMenuItemCreate";
            this.fileMenuItemCreate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.fileMenuItemCreate.Size = new System.Drawing.Size(398, 34);
            this.fileMenuItemCreate.Text = "Создать";
            this.fileMenuItemCreate.Click += new System.EventHandler(this.OnCreateFile);
            // 
            // fileMenuItemCreatePlaintext
            // 
            this.fileMenuItemCreatePlaintext.Name = "fileMenuItemCreatePlaintext";
            this.fileMenuItemCreatePlaintext.Size = new System.Drawing.Size(280, 34);
            this.fileMenuItemCreatePlaintext.Text = "Текстовый файл";
            this.fileMenuItemCreatePlaintext.Click += new System.EventHandler(this.OnCreateFileRtf);
            // 
            // fileMenuItemCreateRtf
            // 
            this.fileMenuItemCreateRtf.Name = "fileMenuItemCreateRtf";
            this.fileMenuItemCreateRtf.Size = new System.Drawing.Size(280, 34);
            this.fileMenuItemCreateRtf.Text = "Файл в формате RTF";
            // 
            // fileMenuItemOpen
            // 
            this.fileMenuItemOpen.Name = "fileMenuItemOpen";
            this.fileMenuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fileMenuItemOpen.Size = new System.Drawing.Size(398, 34);
            this.fileMenuItemOpen.Text = "Открыть";
            this.fileMenuItemOpen.Click += new System.EventHandler(this.OnOpenFile);
            // 
            // fileMenuItemSave
            // 
            this.fileMenuItemSave.Name = "fileMenuItemSave";
            this.fileMenuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fileMenuItemSave.Size = new System.Drawing.Size(398, 34);
            this.fileMenuItemSave.Text = "Сохранить";
            this.fileMenuItemSave.Click += new System.EventHandler(this.OnSaveFile);
            // 
            // fileMenuItemSaveAs
            // 
            this.fileMenuItemSaveAs.Name = "fileMenuItemSaveAs";
            this.fileMenuItemSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.fileMenuItemSaveAs.Size = new System.Drawing.Size(398, 34);
            this.fileMenuItemSaveAs.Text = "Сохранить как";
            this.fileMenuItemSaveAs.Click += new System.EventHandler(this.OnSaveFileAs);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(395, 6);
            // 
            // fileMenuItemClose
            // 
            this.fileMenuItemClose.Name = "fileMenuItemClose";
            this.fileMenuItemClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.fileMenuItemClose.Size = new System.Drawing.Size(398, 34);
            this.fileMenuItemClose.Text = "Закрыть текущую вкладку";
            this.fileMenuItemClose.Click += new System.EventHandler(this.OnCloseCurrentTab);
            // 
            // fileMenuItemExit
            // 
            this.fileMenuItemExit.Name = "fileMenuItemExit";
            this.fileMenuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.fileMenuItemExit.Size = new System.Drawing.Size(398, 34);
            this.fileMenuItemExit.Text = "Выход";
            this.fileMenuItemExit.Click += new System.EventHandler(this.OnExitMenuItemClick);
            // 
            // dropdownEditButton
            // 
            this.dropdownEditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dropdownEditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dropdownEditButton.Name = "dropdownEditButton";
            this.dropdownEditButton.Size = new System.Drawing.Size(91, 29);
            this.dropdownEditButton.Text = "Правка";
            // 
            // dropdownFormatButton
            // 
            this.dropdownFormatButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dropdownFormatButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatMenuItemChangeFont,
            this.formatMenuItemChangeColor});
            this.dropdownFormatButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dropdownFormatButton.Name = "dropdownFormatButton";
            this.dropdownFormatButton.Size = new System.Drawing.Size(94, 29);
            this.dropdownFormatButton.Text = "Формат";
            // 
            // formatMenuItemChangeFont
            // 
            this.formatMenuItemChangeFont.Name = "formatMenuItemChangeFont";
            this.formatMenuItemChangeFont.Size = new System.Drawing.Size(385, 34);
            this.formatMenuItemChangeFont.Text = "Изменить шрифт";
            this.formatMenuItemChangeFont.Click += new System.EventHandler(this.OnFontChangeMenuItemClick);
            // 
            // formatMenuItemChangeColor
            // 
            this.formatMenuItemChangeColor.Name = "formatMenuItemChangeColor";
            this.formatMenuItemChangeColor.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.formatMenuItemChangeColor.Size = new System.Drawing.Size(385, 34);
            this.formatMenuItemChangeColor.Text = "Изменить цвет текста";
            this.formatMenuItemChangeColor.Click += new System.EventHandler(this.OnColorChangeMenuItemClick);
            // 
            // dropdownSettingsButton
            // 
            this.dropdownSettingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dropdownSettingsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInMenuItem,
            this.zoomOutMenuItem,
            this.zoomResetMenuItem,
            this.toolStripSeparator1,
            this.editorSettingsMenuItem});
            this.dropdownSettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dropdownSettingsButton.Name = "dropdownSettingsButton";
            this.dropdownSettingsButton.Size = new System.Drawing.Size(118, 29);
            this.dropdownSettingsButton.Text = "Настройки";
            // 
            // zoomInMenuItem
            // 
            this.zoomInMenuItem.Name = "zoomInMenuItem";
            this.zoomInMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.zoomInMenuItem.Size = new System.Drawing.Size(418, 34);
            this.zoomInMenuItem.Text = "Увеличить масштаб";
            this.zoomInMenuItem.Click += new System.EventHandler(this.OnZoomInClick);
            // 
            // zoomOutMenuItem
            // 
            this.zoomOutMenuItem.Name = "zoomOutMenuItem";
            this.zoomOutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.zoomOutMenuItem.Size = new System.Drawing.Size(418, 34);
            this.zoomOutMenuItem.Text = "Уменьшить масштаб";
            this.zoomOutMenuItem.Click += new System.EventHandler(this.OnZoomOutClick);
            // 
            // zoomResetMenuItem
            // 
            this.zoomResetMenuItem.Name = "zoomResetMenuItem";
            this.zoomResetMenuItem.Size = new System.Drawing.Size(418, 34);
            this.zoomResetMenuItem.Text = "Сбросить масштаб";
            this.zoomResetMenuItem.Click += new System.EventHandler(this.OnZoomResetClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(415, 6);
            // 
            // editorSettingsMenuItem
            // 
            this.editorSettingsMenuItem.Name = "editorSettingsMenuItem";
            this.editorSettingsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.editorSettingsMenuItem.Size = new System.Drawing.Size(418, 34);
            this.editorSettingsMenuItem.Text = "Параметры редактора";
            this.editorSettingsMenuItem.Click += new System.EventHandler(this.OnSettingsOpen);
            // 
            // dropdownInfoButton
            // 
            this.dropdownInfoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dropdownInfoButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoMenuItemAbout});
            this.dropdownInfoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dropdownInfoButton.Name = "dropdownInfoButton";
            this.dropdownInfoButton.Size = new System.Drawing.Size(99, 29);
            this.dropdownInfoButton.Text = "Справка";
            // 
            // infoMenuItemAbout
            // 
            this.infoMenuItemAbout.Name = "infoMenuItemAbout";
            this.infoMenuItemAbout.Size = new System.Drawing.Size(227, 34);
            this.infoMenuItemAbout.Text = "О программе";
            this.infoMenuItemAbout.Click += new System.EventHandler(this.OnAboutAppWindowOpen);
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 34);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1366, 580);
            this.tabControl.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 614);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.mainMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.Text = "Notepad+";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        
        private System.Windows.Forms.ToolStripMenuItem infoMenuItemAbout;

        private System.Windows.Forms.ToolStripDropDownButton dropdownInfoButton;

        private System.Windows.Forms.ToolStripMenuItem fileMenuItemCreatePlaintext;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItemCreateRtf;

        private System.Windows.Forms.ToolStripMenuItem formatMenuItemChangeColor;
        private System.Windows.Forms.ToolStripMenuItem formatMenuItemChangeFont;

        private System.Windows.Forms.ToolStripMenuItem fileMenuItemClose;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

        private System.Windows.Forms.ToolStripMenuItem editorSettingsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private System.Windows.Forms.ToolStripMenuItem zoomResetMenuItem;

        private System.Windows.Forms.ToolStripMenuItem zoomInMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutMenuItem;

        private System.Windows.Forms.ToolStripDropDownButton dropdownFormatButton;
        private System.Windows.Forms.ToolStripDropDownButton dropdownSettingsButton;

        private System.Windows.Forms.ToolStripDropDownButton dropdownEditButton;

        private System.Windows.Forms.ToolStripMenuItem fileMenuItemCreate;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItemSaveAs;

        private System.Windows.Forms.ToolStripDropDownButton dropdownFileButton;
        

        private System.Windows.Forms.ToolStrip mainMenu;
        private System.Windows.Forms.TabControl tabControl;

        #endregion
    }
}

