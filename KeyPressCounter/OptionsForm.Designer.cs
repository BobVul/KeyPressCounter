﻿namespace KeyPressCounter
{
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.tableLayoutPanelWindowMode = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonWMMinimize = new System.Windows.Forms.RadioButton();
            this.radioButtonWMAlwaysOnTop = new System.Windows.Forms.RadioButton();
            this.radioButtonWMNone = new System.Windows.Forms.RadioButton();
            this.labelWindowMode = new System.Windows.Forms.Label();
            this.checkBoxEnableHotkey = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDiscard = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonLMAlways = new System.Windows.Forms.RadioButton();
            this.labelLoggingMode = new System.Windows.Forms.Label();
            this.radioButtonLMWhenStarted = new System.Windows.Forms.RadioButton();
            this.radioButtonLMOff = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanelWindowMode.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelWindowMode
            // 
            this.tableLayoutPanelWindowMode.ColumnCount = 4;
            this.tableLayoutPanelWindowMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelWindowMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelWindowMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelWindowMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelWindowMode.Controls.Add(this.radioButtonWMMinimize, 2, 0);
            this.tableLayoutPanelWindowMode.Controls.Add(this.radioButtonWMAlwaysOnTop, 1, 0);
            this.tableLayoutPanelWindowMode.Controls.Add(this.radioButtonWMNone, 3, 0);
            this.tableLayoutPanelWindowMode.Controls.Add(this.labelWindowMode, 0, 0);
            this.tableLayoutPanelWindowMode.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelWindowMode.Name = "tableLayoutPanelWindowMode";
            this.tableLayoutPanelWindowMode.RowCount = 1;
            this.tableLayoutPanelWindowMode.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelWindowMode.Size = new System.Drawing.Size(329, 25);
            this.tableLayoutPanelWindowMode.TabIndex = 9;
            // 
            // radioButtonWMMinimize
            // 
            this.radioButtonWMMinimize.AutoSize = true;
            this.radioButtonWMMinimize.Location = new System.Drawing.Point(163, 3);
            this.radioButtonWMMinimize.Name = "radioButtonWMMinimize";
            this.radioButtonWMMinimize.Size = new System.Drawing.Size(65, 17);
            this.radioButtonWMMinimize.TabIndex = 3;
            this.radioButtonWMMinimize.Text = "Minimize";
            this.radioButtonWMMinimize.UseVisualStyleBackColor = true;
            // 
            // radioButtonWMAlwaysOnTop
            // 
            this.radioButtonWMAlwaysOnTop.AutoSize = true;
            this.radioButtonWMAlwaysOnTop.Location = new System.Drawing.Point(63, 3);
            this.radioButtonWMAlwaysOnTop.Name = "radioButtonWMAlwaysOnTop";
            this.radioButtonWMAlwaysOnTop.Size = new System.Drawing.Size(91, 17);
            this.radioButtonWMAlwaysOnTop.TabIndex = 2;
            this.radioButtonWMAlwaysOnTop.Text = "Always on top";
            this.radioButtonWMAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // radioButtonWMNone
            // 
            this.radioButtonWMNone.AutoSize = true;
            this.radioButtonWMNone.Checked = true;
            this.radioButtonWMNone.Location = new System.Drawing.Point(263, 3);
            this.radioButtonWMNone.Name = "radioButtonWMNone";
            this.radioButtonWMNone.Size = new System.Drawing.Size(51, 17);
            this.radioButtonWMNone.TabIndex = 1;
            this.radioButtonWMNone.TabStop = true;
            this.radioButtonWMNone.Text = "None";
            this.radioButtonWMNone.UseVisualStyleBackColor = true;
            // 
            // labelWindowMode
            // 
            this.labelWindowMode.AutoSize = true;
            this.labelWindowMode.Location = new System.Drawing.Point(3, 5);
            this.labelWindowMode.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelWindowMode.Name = "labelWindowMode";
            this.labelWindowMode.Size = new System.Drawing.Size(49, 13);
            this.labelWindowMode.TabIndex = 4;
            this.labelWindowMode.Text = "Window:";
            // 
            // checkBoxEnableHotkey
            // 
            this.checkBoxEnableHotkey.AutoSize = true;
            this.checkBoxEnableHotkey.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEnableHotkey.Location = new System.Drawing.Point(3, 3);
            this.checkBoxEnableHotkey.Name = "checkBoxEnableHotkey";
            this.checkBoxEnableHotkey.Size = new System.Drawing.Size(99, 17);
            this.checkBoxEnableHotkey.TabIndex = 10;
            this.checkBoxEnableHotkey.Text = "Enable hotkeys";
            this.checkBoxEnableHotkey.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.checkBoxEnableHotkey, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(329, 43);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(185, 134);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDiscard
            // 
            this.buttonDiscard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDiscard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonDiscard.Location = new System.Drawing.Point(266, 134);
            this.buttonDiscard.Name = "buttonDiscard";
            this.buttonDiscard.Size = new System.Drawing.Size(75, 23);
            this.buttonDiscard.TabIndex = 13;
            this.buttonDiscard.Text = "Discard";
            this.buttonDiscard.UseVisualStyleBackColor = true;
            this.buttonDiscard.Click += new System.EventHandler(this.buttonDiscard_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAbout.Location = new System.Drawing.Point(12, 134);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 14;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.radioButtonLMAlways, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelLoggingMode, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonLMWhenStarted, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonLMOff, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(329, 25);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // radioButtonLMAlways
            // 
            this.radioButtonLMAlways.AutoSize = true;
            this.radioButtonLMAlways.Location = new System.Drawing.Point(63, 3);
            this.radioButtonLMAlways.Name = "radioButtonLMAlways";
            this.radioButtonLMAlways.Size = new System.Drawing.Size(58, 17);
            this.radioButtonLMAlways.TabIndex = 2;
            this.radioButtonLMAlways.Text = "Always";
            this.radioButtonLMAlways.UseVisualStyleBackColor = true;
            // 
            // labelLoggingMode
            // 
            this.labelLoggingMode.AutoSize = true;
            this.labelLoggingMode.Location = new System.Drawing.Point(3, 5);
            this.labelLoggingMode.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelLoggingMode.Name = "labelLoggingMode";
            this.labelLoggingMode.Size = new System.Drawing.Size(48, 13);
            this.labelLoggingMode.TabIndex = 4;
            this.labelLoggingMode.Text = "Logging:";
            // 
            // radioButtonLMWhenStarted
            // 
            this.radioButtonLMWhenStarted.AutoSize = true;
            this.radioButtonLMWhenStarted.Location = new System.Drawing.Point(163, 3);
            this.radioButtonLMWhenStarted.Name = "radioButtonLMWhenStarted";
            this.radioButtonLMWhenStarted.Size = new System.Drawing.Size(87, 17);
            this.radioButtonLMWhenStarted.TabIndex = 3;
            this.radioButtonLMWhenStarted.Text = "While started";
            this.radioButtonLMWhenStarted.UseVisualStyleBackColor = true;
            // 
            // radioButtonLMOff
            // 
            this.radioButtonLMOff.AutoSize = true;
            this.radioButtonLMOff.Checked = true;
            this.radioButtonLMOff.Location = new System.Drawing.Point(263, 3);
            this.radioButtonLMOff.Name = "radioButtonLMOff";
            this.radioButtonLMOff.Size = new System.Drawing.Size(39, 17);
            this.radioButtonLMOff.TabIndex = 1;
            this.radioButtonLMOff.TabStop = true;
            this.radioButtonLMOff.Text = "Off";
            this.radioButtonLMOff.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonDiscard;
            this.ClientSize = new System.Drawing.Size(356, 169);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonDiscard);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanelWindowMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.tableLayoutPanelWindowMode.ResumeLayout(false);
            this.tableLayoutPanelWindowMode.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWindowMode;
        private System.Windows.Forms.RadioButton radioButtonWMMinimize;
        private System.Windows.Forms.RadioButton radioButtonWMAlwaysOnTop;
        private System.Windows.Forms.RadioButton radioButtonWMNone;
        private System.Windows.Forms.Label labelWindowMode;
        private System.Windows.Forms.CheckBox checkBoxEnableHotkey;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDiscard;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButtonLMAlways;
        private System.Windows.Forms.Label labelLoggingMode;
        private System.Windows.Forms.RadioButton radioButtonLMWhenStarted;
        private System.Windows.Forms.RadioButton radioButtonLMOff;
    }
}