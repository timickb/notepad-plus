using System.ComponentModel;

namespace NotepadPlus
{
    partial class SettingsFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorSchemeChoiceBox = new System.Windows.Forms.ComboBox();
            this.autoSaveChoiceBox = new System.Windows.Forms.ComboBox();
            this.colorSchemeApplyButton = new System.Windows.Forms.Button();
            this.autoSaveApplyButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.11494F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.88506F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.colorSchemeChoiceBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.autoSaveChoiceBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.colorSchemeApplyButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.autoSaveApplyButton, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.8125F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.1875F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 395F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(618, 544);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Цветовая схема";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Автосохранение";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorSchemeChoiceBox
            // 
            this.colorSchemeChoiceBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.colorSchemeChoiceBox.FormattingEnabled = true;
            this.colorSchemeChoiceBox.Location = new System.Drawing.Point(186, 31);
            this.colorSchemeChoiceBox.Margin = new System.Windows.Forms.Padding(3, 21, 3, 3);
            this.colorSchemeChoiceBox.Name = "colorSchemeChoiceBox";
            this.colorSchemeChoiceBox.Size = new System.Drawing.Size(205, 28);
            this.colorSchemeChoiceBox.TabIndex = 2;
            // 
            // autoSaveChoiceBox
            // 
            this.autoSaveChoiceBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.autoSaveChoiceBox.FormattingEnabled = true;
            this.autoSaveChoiceBox.Location = new System.Drawing.Point(186, 105);
            this.autoSaveChoiceBox.Margin = new System.Windows.Forms.Padding(3, 21, 3, 3);
            this.autoSaveChoiceBox.Name = "autoSaveChoiceBox";
            this.autoSaveChoiceBox.Size = new System.Drawing.Size(205, 28);
            this.autoSaveChoiceBox.TabIndex = 2;
            // 
            // colorSchemeApplyButton
            // 
            this.colorSchemeApplyButton.Location = new System.Drawing.Point(397, 26);
            this.colorSchemeApplyButton.Margin = new System.Windows.Forms.Padding(3, 16, 3, 3);
            this.colorSchemeApplyButton.Name = "colorSchemeApplyButton";
            this.colorSchemeApplyButton.Size = new System.Drawing.Size(125, 34);
            this.colorSchemeApplyButton.TabIndex = 3;
            this.colorSchemeApplyButton.Text = "Применить";
            this.colorSchemeApplyButton.UseVisualStyleBackColor = true;
            // 
            // autoSaveApplyButton
            // 
            this.autoSaveApplyButton.Location = new System.Drawing.Point(397, 87);
            this.autoSaveApplyButton.Margin = new System.Windows.Forms.Padding(3, 16, 3, 3);
            this.autoSaveApplyButton.Name = "autoSaveApplyButton";
            this.autoSaveApplyButton.Size = new System.Drawing.Size(125, 34);
            this.autoSaveApplyButton.TabIndex = 4;
            this.autoSaveApplyButton.Text = "Применить";
            this.autoSaveApplyButton.UseVisualStyleBackColor = true;
            // 
            // SettingsFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 544);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 600);
            this.Name = "SettingsFrame";
            this.ShowIcon = false;
            this.Text = "Настройки";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button autoSaveApplyButton;

        private System.Windows.Forms.ComboBox autoSaveChoiceBox;
        private System.Windows.Forms.Button colorSchemeApplyButton;
        private System.Windows.Forms.ComboBox colorSchemeChoiceBox;

        private System.Windows.Forms.ComboBox comboBox2;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}