namespace KeyPressCounter
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelKeypressesVal = new System.Windows.Forms.Label();
            this.labelTimeVal = new System.Windows.Forms.Label();
            this.labelKPMVal = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.UpdateDisplay = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelKPMVal, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelTimeVal, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelKeypressesVal, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelKeypressesDesc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelKPMDesc, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelTimeDesc, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // labelKeypressesVal
            // 
            this.labelKeypressesVal.AutoSize = true;
            this.labelKeypressesVal.Location = new System.Drawing.Point(103, 0);
            this.labelKeypressesVal.Name = "labelKeypressesVal";
            this.labelKeypressesVal.Size = new System.Drawing.Size(13, 13);
            this.labelKeypressesVal.TabIndex = 3;
            this.labelKeypressesVal.Text = "0";
            // 
            // labelTimeVal
            // 
            this.labelTimeVal.AutoSize = true;
            this.labelTimeVal.Location = new System.Drawing.Point(103, 13);
            this.labelTimeVal.Name = "labelTimeVal";
            this.labelTimeVal.Size = new System.Drawing.Size(13, 13);
            this.labelTimeVal.TabIndex = 4;
            this.labelTimeVal.Text = "0";
            // 
            // labelKPMVal
            // 
            this.labelKPMVal.AutoSize = true;
            this.labelKPMVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKPMVal.Location = new System.Drawing.Point(103, 26);
            this.labelKPMVal.Name = "labelKPMVal";
            this.labelKPMVal.Size = new System.Drawing.Size(24, 25);
            this.labelKPMVal.TabIndex = 5;
            this.labelKPMVal.Text = "0";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(15, 9);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(139, 13);
            this.labelDesc.TabIndex = 6;
            this.labelDesc.Text = "Press F5 to start, F6 to stop.";
            // 
            // UpdateDisplay
            // 
            this.UpdateDisplay.Enabled = true;
            this.UpdateDisplay.Interval = 50;
            this.UpdateDisplay.Tick += new System.EventHandler(this.UpdateDisplay_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelDesc);
            this.Name = "MainForm";
            this.Text = "KeyPressCounter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKeypressesDesc;
        private System.Windows.Forms.Label labelTimeDesc;
        private System.Windows.Forms.Label labelKPMDesc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelKPMVal;
        private System.Windows.Forms.Label labelTimeVal;
        private System.Windows.Forms.Label labelKeypressesVal;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Timer UpdateDisplay;
    }
}

