using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace KeyPressCounter
{
    public partial class MainForm : Form
    {
        InterceptKeys KeyboardHook = new InterceptKeys();
        Stopwatch TimeCounter = new Stopwatch();
        int KeypressCounter = new Int32();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            KeyboardHook.KeyDown += new KeyEventHandler(KeyboardHook_KeyDown);
            KeyboardHook.CreateHook();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            KeyboardHook.Dispose();
        }

        void KeyboardHook_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    StartCount();
                    break;
                case Keys.F6:
                    StopCount();
                    break;
                default:
                    IncrementCount();
                    break;
            }
        }

        private void StartCount()
        {
            this.WindowState = FormWindowState.Minimized;
            TimeCounter.Restart();
            KeypressCounter = new Int32();
        }

        private void StopCount()
        {
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
            TimeCounter.Stop();
        }

        private void IncrementCount()
        {
            if (!TimeCounter.IsRunning)
                return;

            KeypressCounter++;
        }

        private void UpdateDisplay_Tick(object sender, EventArgs e)
        {
            labelKeypressesVal.Text = KeypressCounter.ToString();
            labelTimeVal.Text = TimeCounter.Elapsed.ToString();
            labelKPMVal.Text = (KeypressCounter / TimeCounter.Elapsed.TotalMinutes).ToString();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            using (AboutBox about = new AboutBox())
            {
                about.ShowDialog();
            }
        }
    }
}
