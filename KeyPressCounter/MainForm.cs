﻿using System;
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
        Options options = new Options();


        public MainForm()
        {
            InitializeComponent();

            ApplyOptions();
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
            if (options.HotkeysEnabled)
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
            else
            {
                IncrementCount();
            }
        }

        private void StartCount()
        {
            if (options.WindowMode == WindowModes.Minimized)
                this.WindowState = FormWindowState.Minimized;
            TimeCounter.Restart();
            KeypressCounter = new Int32();
        }

        private void StopCount()
        {
            if (options.WindowMode == WindowModes.Minimized)
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
            labelTimeVal.Text = TimeCounter.Elapsed.ToString("d'.'hh':'mm':'ss'.'ff");
            labelKPMVal.Text = (KeypressCounter / TimeCounter.Elapsed.TotalMinutes).ToString("0.00");
        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            using (OptionsForm optionsForm = new OptionsForm(options))
            {
                if (optionsForm.ShowDialog() == DialogResult.OK)
                {
                    ApplyOptions();
                }
            }
        }

        private void ApplyOptions()
        {
            switch (options.WindowMode)
            {
                case WindowModes.None:
                    this.TopMost = false;
                    break;
                case WindowModes.Minimized:
                    this.TopMost = false;
                    break;
                case WindowModes.AlwaysOnTop:
                    this.TopMost = true;
                    break;
            }

            if (options.HotkeysEnabled)
                this.labelDesc.Visible = true;
            else
                this.labelDesc.Visible = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartCount();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopCount();
        }
    }
}
