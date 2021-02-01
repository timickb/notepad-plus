using System.Drawing;
using System.Windows.Forms;

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
            this.mainMenu = new NotepadPlus.UI.NToolStrip();
            this.dropdownFileButton = new NotepadPlus.UI.NToolStripDropDownButton();
            this.fileMenuItemCreate = new NotepadPlus.UI.NToolStripMenuItem();
            this.fileMenuItemCreatePlaintext = new NotepadPlus.UI.NToolStripMenuItem();
            this.fileMenuItemOpenNewWindow = new NotepadPlus.UI.NToolStripMenuItem();
            this.fileMenuItemCreateRtf = new NotepadPlus.UI.NToolStripMenuItem();
            this.fileMenuItemOpen = new NotepadPlus.UI.NToolStripMenuItem();
            this.fileMenuItemSave = new NotepadPlus.UI.NToolStripMenuItem();
            this.fileMenuItemSaveAs = new NotepadPlus.UI.NToolStripMenuItem();
            this.fileMenuItemSaveAll = new NotepadPlus.UI.NToolStripMenuItem();
            this.editMenuItemRedo = new NotepadPlus.UI.NToolStripMenuItem();
            this.editMenuItemUndo = new NotepadPlus.UI.NToolStripMenuItem();
            this.editMenuItemChangeSyntax = new NotepadPlus.UI.NToolStripMenuItem();
            this.editMenuItemChangeType = new NotepadPlus.UI.NToolStripMenuItem();
            this.syntaxMenuItemC = new NotepadPlus.UI.NToolStripMenuItem();
            this.syntaxMenuItemCpp = new NotepadPlus.UI.NToolStripMenuItem();
            this.syntaxMenuItemCs = new NotepadPlus.UI.NToolStripMenuItem();
            this.syntaxMenuItemJava = new NotepadPlus.UI.NToolStripMenuItem();
            this.syntaxMenuItemPython = new NotepadPlus.UI.NToolStripMenuItem();
            this.syntaxMenuItemJS = new NotepadPlus.UI.NToolStripMenuItem();
            this.typeMenuItemPlaintext = new NotepadPlus.UI.NToolStripMenuItem();
            this.typeMenuItemRichtext = new NotepadPlus.UI.NToolStripMenuItem();
            this.toolStripSeparator2 = new NotepadPlus.UI.NToolStripSeparator();
            this.fileMenuItemClose = new NotepadPlus.UI.NToolStripMenuItem();
            this.fileMenuItemExit = new NotepadPlus.UI.NToolStripMenuItem();
            this.dropdownEditButton = new NotepadPlus.UI.NToolStripDropDownButton();
            this.dropdownFormatButton = new NotepadPlus.UI.NToolStripDropDownButton();
            this.dropdownSettingsButton = new NotepadPlus.UI.NToolStripDropDownButton();
            this.zoomInMenuItem = new NotepadPlus.UI.NToolStripMenuItem();
            this.zoomOutMenuItem = new NotepadPlus.UI.NToolStripMenuItem();
            this.zoomResetMenuItem = new NotepadPlus.UI.NToolStripMenuItem();
            this.toolStripSeparator1 = new NotepadPlus.UI.NToolStripSeparator();
            this.editorSettingsMenuItem = new NotepadPlus.UI.NToolStripMenuItem();
            this.dropdownInfoButton = new NotepadPlus.UI.NToolStripDropDownButton();
            this.infoMenuItemAbout = new NotepadPlus.UI.NToolStripMenuItem();
            this.tabControl = new NotepadPlus.UI.NTabControl();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = Color.White;
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenu.Items.AddRange(new [] {
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
            this.fileMenuItemSaveAll,
            this.fileMenuItemOpenNewWindow,
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
            this.fileMenuItemCreate.DropDownItems.AddRange(new [] {
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
            this.fileMenuItemCreatePlaintext.Click += new System.EventHandler(this.OnCreateFileText);
            this.fileMenuItemCreatePlaintext.ShortcutKeys = Keys.Control | Keys.T;
            // 
            // fileMenuItemCreateRtf
            // 
            this.fileMenuItemCreateRtf.Name = "fileMenuItemCreateRtf";
            this.fileMenuItemCreateRtf.Size = new System.Drawing.Size(280, 34);
            this.fileMenuItemCreateRtf.Text = "Файл в формате RTF";
            this.fileMenuItemCreateRtf.Click += new System.EventHandler(this.OnCreateFileRtf);
            this.fileMenuItemCreateRtf.ShortcutKeys = Keys.Control | Keys.Shift | Keys.T;
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
            // fileMenuItemSaveAll
            //
            this.fileMenuItemSaveAll.Name = "fileMenuItemSaveAll";
            this.fileMenuItemSaveAll.ShortcutKeys = Keys.Control | Keys.Shift | Keys.A;
            this.fileMenuItemSaveAll.Text = "Сохранить все открытые вкладки";
            this.fileMenuItemSaveAll.Click += new System.EventHandler(this.OnSaveFileAll);
            //
            // fileMenuItemOpenNewWindow
            //
            this.fileMenuItemOpenNewWindow.Name = "fileMenuItemOpenNewWindow";
            this.fileMenuItemOpenNewWindow.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
            this.fileMenuItemOpenNewWindow.Text = "Открыть новое окно";
            this.fileMenuItemOpenNewWindow.Click += new System.EventHandler(this.OnOpenNewWindow);
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
            // editMenuItemUndo
            //
            this.editMenuItemUndo.Name = "editMenuItemUndo";
            this.editMenuItemUndo.ShortcutKeys = Keys.Control | Keys.Z;
            this.editMenuItemUndo.Text = "Undo";
            this.editMenuItemUndo.Click += new System.EventHandler(this.OnUndoChanges);
            //
            // editMenuItemRedo
            //
            this.editMenuItemRedo.Name = "editMenuItemRedo";
            this.editMenuItemRedo.ShortcutKeys = Keys.Control | Keys.Shift | Keys.Z;
            this.editMenuItemRedo.Text = "Redo";
            this.editMenuItemRedo.Click += new System.EventHandler(this.OnRedoChanges);
            //
            // editMenuItemChangeSyntax
            //
            this.editMenuItemChangeSyntax.Name = "editMenuItemChangeSyntax";
            this.editMenuItemChangeSyntax.Text = "Подсветка синтаксиса";
            this.editMenuItemChangeSyntax.DropDownItems.AddRange(new System.Windows.Forms.ToolStripMenuItem[] {
                this.syntaxMenuItemC,
                this.syntaxMenuItemCpp,
                this.syntaxMenuItemCs,
                this.syntaxMenuItemJava,
                this.syntaxMenuItemPython,
                this.syntaxMenuItemJS
            });
            //
            // editMenuItemChangeType
            //
            this.editMenuItemChangeType.Name = "editMenuItemChangeType";
            this.editMenuItemChangeType.Text = "Изменить формат документа";
            this.editMenuItemChangeType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripMenuItem[]
            {
                this.typeMenuItemPlaintext,
                this.typeMenuItemRichtext
            });
            //
            // typeMenuItemPlaintext
            //
            this.typeMenuItemPlaintext.Name = "typeMenuItemPlaintext";
            this.typeMenuItemPlaintext.Text = "Текстовый документ";
            this.typeMenuItemPlaintext.Click += new System.EventHandler(this.OnConvertToPlaintext);
            //
            // typeMenuItemRichtext
            //
            this.typeMenuItemRichtext.Name = "typeMenuItemRichtext";
            this.typeMenuItemRichtext.Text = "Документ RTF";
            this.typeMenuItemRichtext.Click += new System.EventHandler(this.OnConvertToRichtext);
            // 
            // dropdownEditButton
            // 
            this.dropdownEditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dropdownEditButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.editMenuItemUndo,
                this.editMenuItemRedo,
                this.editMenuItemChangeSyntax,
                this.editMenuItemChangeType
            });
            this.dropdownEditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dropdownEditButton.Name = "dropdownEditButton";
            this.dropdownEditButton.Size = new System.Drawing.Size(91, 29);
            this.dropdownEditButton.Text = "Правка";
            // 
            // dropdownFormatButton
            // 
            this.dropdownFormatButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dropdownFormatButton.Name = "dropdownFormatButton";
            this.dropdownFormatButton.Size = new System.Drawing.Size(94, 29);
            this.dropdownFormatButton.Text = "Формат";
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
            this.dropdownInfoButton.DropDownItems.AddRange(new [] {
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
        
        private NotepadPlus.UI.NToolStripMenuItem infoMenuItemAbout;

        private NotepadPlus.UI.NToolStripDropDownButton dropdownInfoButton;

        private NotepadPlus.UI.NToolStripMenuItem fileMenuItemCreatePlaintext;
        private NotepadPlus.UI.NToolStripMenuItem fileMenuItemCreateRtf;

        private NotepadPlus.UI.NToolStripMenuItem fileMenuItemClose;

        private NotepadPlus.UI.NToolStripSeparator toolStripSeparator2;

        private NotepadPlus.UI.NToolStripMenuItem editorSettingsMenuItem;
        private NotepadPlus.UI.NToolStripSeparator toolStripSeparator1;

        private NotepadPlus.UI.NToolStripMenuItem zoomResetMenuItem;

        private NotepadPlus.UI.NToolStripMenuItem zoomInMenuItem;
        private NotepadPlus.UI.NToolStripMenuItem zoomOutMenuItem;

        private NotepadPlus.UI.NToolStripDropDownButton dropdownFormatButton;
        private NotepadPlus.UI.NToolStripDropDownButton dropdownSettingsButton;

        private NotepadPlus.UI.NToolStripDropDownButton dropdownEditButton;

        private NotepadPlus.UI.NToolStripMenuItem fileMenuItemCreate;
        private NotepadPlus.UI.NToolStripMenuItem fileMenuItemExit;
        private NotepadPlus.UI.NToolStripMenuItem fileMenuItemOpen;
        private NotepadPlus.UI.NToolStripMenuItem fileMenuItemSave;
        private NotepadPlus.UI.NToolStripMenuItem fileMenuItemSaveAs;
        private NotepadPlus.UI.NToolStripMenuItem fileMenuItemOpenNewWindow;
        private NotepadPlus.UI.NToolStripMenuItem fileMenuItemSaveAll;

        private NotepadPlus.UI.NToolStripMenuItem editMenuItemUndo;
        private NotepadPlus.UI.NToolStripMenuItem editMenuItemRedo;
        private NotepadPlus.UI.NToolStripMenuItem editMenuItemChangeSyntax;
        private NotepadPlus.UI.NToolStripMenuItem editMenuItemChangeType;

        private NotepadPlus.UI.NToolStripMenuItem syntaxMenuItemCs;
        private NotepadPlus.UI.NToolStripMenuItem syntaxMenuItemJava;
        private NotepadPlus.UI.NToolStripMenuItem syntaxMenuItemPython;
        private NotepadPlus.UI.NToolStripMenuItem syntaxMenuItemCpp;
        private NotepadPlus.UI.NToolStripMenuItem syntaxMenuItemC;
        private NotepadPlus.UI.NToolStripMenuItem syntaxMenuItemJS;

        private NotepadPlus.UI.NToolStripMenuItem typeMenuItemPlaintext;
        private NotepadPlus.UI.NToolStripMenuItem typeMenuItemRichtext;
        

        private NotepadPlus.UI.NToolStripDropDownButton dropdownFileButton;
        

        private NotepadPlus.UI.NToolStrip mainMenu;
        private NotepadPlus.UI.NTabControl tabControl;

        #endregion
    }
}

