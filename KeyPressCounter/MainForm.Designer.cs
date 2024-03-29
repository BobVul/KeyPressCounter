﻿namespace KeyPressCounter
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.labelKeypressesDesc = new System.Windows.Forms.Label();
            this.labelTimeDesc = new System.Windows.Forms.Label();
            this.labelKPMDesc = new System.Windows.Forms.Label();
            this.tableLayoutPanelDisplay = new System.Windows.Forms.TableLayoutPanel();
            this.labelKPMVal = new System.Windows.Forms.Label();
            this.labelTimeVal = new System.Windows.Forms.Label();
            this.labelKeypressesVal = new System.Windows.Forms.Label();
            this.labelHotkeys = new System.Windows.Forms.Label();
            this.UpdateDisplay = new System.Windows.Forms.Timer(this.components);
            this.buttonOptions = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.tableLayoutPanelDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelKeypressesDesc
            // 
            this.labelKeypressesDesc.AutoSize = true;
            this.labelKeypressesDesc.Location = new System.Drawing.Point(3, 0);
            this.labelKeypressesDesc.Name = "labelKeypressesDesc";
            this.labelKeypressesDesc.Size = new System.Drawing.Size(61, 13);
            this.labelKeypressesDesc.TabIndex = 0;
            this.labelKeypressesDesc.Text = "Keypresses";
            // 
            // labelTimeDesc
            // 
            this.labelTimeDesc.AutoSize = true;
            this.labelTimeDesc.Location = new System.Drawing.Point(3, 13);
            this.labelTimeDesc.Name = "labelTimeDesc";
            this.labelTimeDesc.Size = new System.Drawing.Size(30, 13);
            this.labelTimeDesc.TabIndex = 1;
            this.labelTimeDesc.Text = "Time";
            // 
            // labelKPMDesc
            // 
            this.labelKPMDesc.AutoSize = true;
            this.labelKPMDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKPMDesc.Location = new System.Drawing.Point(3, 26);
            this.labelKPMDesc.Name = "labelKPMDesc";
            this.labelKPMDesc.Size = new System.Drawing.Size(58, 25);
            this.labelKPMDesc.TabIndex = 2;
            this.labelKPMDesc.Text = "KPM";
            // 
            // tableLayoutPanelDisplay
            // 
            this.tableLayoutPanelDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelDisplay.ColumnCount = 2;
            this.tableLayoutPanelDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDisplay.Controls.Add(this.labelKPMVal, 1, 2);
            this.tableLayoutPanelDisplay.Controls.Add(this.labelTimeVal, 1, 1);
            this.tableLayoutPanelDisplay.Controls.Add(this.labelKeypressesVal, 1, 0);
            this.tableLayoutPanelDisplay.Controls.Add(this.labelKeypressesDesc, 0, 0);
            this.tableLayoutPanelDisplay.Controls.Add(this.labelKPMDesc, 0, 2);
            this.tableLayoutPanelDisplay.Controls.Add(this.labelTimeDesc, 0, 1);
            this.tableLayoutPanelDisplay.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelDisplay.Name = "tableLayoutPanelDisplay";
            this.tableLayoutPanelDisplay.RowCount = 3;
            this.tableLayoutPanelDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDisplay.Size = new System.Drawing.Size(299, 70);
            this.tableLayoutPanelDisplay.TabIndex = 3;
            // 
            // labelKPMVal
            // 
            this.labelKPMVal.AutoSize = true;
            this.labelKPMVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKPMVal.Location = new System.Drawing.Point(152, 26);
            this.labelKPMVal.Name = "labelKPMVal";
            this.labelKPMVal.Size = new System.Drawing.Size(24, 25);
            this.labelKPMVal.TabIndex = 5;
            this.labelKPMVal.Text = "0";
            // 
            // labelTimeVal
            // 
            this.labelTimeVal.AutoSize = true;
            this.labelTimeVal.Location = new System.Drawing.Point(152, 13);
            this.labelTimeVal.Name = "labelTimeVal";
            this.labelTimeVal.Size = new System.Drawing.Size(13, 13);
            this.labelTimeVal.TabIndex = 4;
            this.labelTimeVal.Text = "0";
            // 
            // labelKeypressesVal
            // 
            this.labelKeypressesVal.AutoSize = true;
            this.labelKeypressesVal.Location = new System.Drawing.Point(152, 0);
            this.labelKeypressesVal.Name = "labelKeypressesVal";
            this.labelKeypressesVal.Size = new System.Drawing.Size(13, 13);
            this.labelKeypressesVal.TabIndex = 3;
            this.labelKeypressesVal.Text = "0";
            // 
            // labelHotkeys
            // 
            this.labelHotkeys.AutoSize = true;
            this.labelHotkeys.Location = new System.Drawing.Point(152, 96);
            this.labelHotkeys.Name = "labelHotkeys";
            this.labelHotkeys.Size = new System.Drawing.Size(139, 13);
            this.labelHotkeys.TabIndex = 6;
            this.labelHotkeys.Text = "Press F5 to start, F6 to stop.";
            // 
            // UpdateDisplay
            // 
            this.UpdateDisplay.Enabled = true;
            this.UpdateDisplay.Interval = 50;
            this.UpdateDisplay.Tick += new System.EventHandler(this.UpdateDisplay_Tick);
            // 
            // buttonOptions
            // 
            this.buttonOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOptions.Location = new System.Drawing.Point(12, 112);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(75, 23);
            this.buttonOptions.TabIndex = 8;
            this.buttonOptions.Text = "Options";
            this.buttonOptions.UseVisualStyleBackColor = true;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Location = new System.Drawing.Point(155, 112);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.Location = new System.Drawing.Point(236, 112);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 10;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 147);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonOptions);
            this.Controls.Add(this.tableLayoutPanelDisplay);
            this.Controls.Add(this.labelHotkeys);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "KeyPressCounter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanelDisplay.ResumeLayout(false);
            this.tableLayoutPanelDisplay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKeypressesDesc;
        private System.Windows.Forms.Label labelTimeDesc;
        private System.Windows.Forms.Label labelKPMDesc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDisplay;
        private System.Windows.Forms.Label labelKPMVal;
        private System.Windows.Forms.Label labelTimeVal;
        private System.Windows.Forms.Label labelKeypressesVal;
        private System.Windows.Forms.Label labelHotkeys;
        private System.Windows.Forms.Timer UpdateDisplay;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
    }
}

