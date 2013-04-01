using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml.Serialization;
using System.IO;

namespace KeyPressCounter
{
    public partial class MainForm : Form
    {
        const string optionsFile = "KeyPressCounter.options.xml";
        const string logFile = "KeyPressCounter.log.csv";
        Options options;
        InterceptKeys keyboardHook = new InterceptKeys();
        Stopwatch timeCounter = new Stopwatch();
        int keypressCounter = new Int32();
        List<DateTime> keypressLog = new List<DateTime>();


        public MainForm()
        {
            InitializeComponent();

            LoadOptions();
            ApplyOptions();

            Timer logTimer = new Timer();
            logTimer.Interval = (int)TimeSpan.FromMinutes(1).TotalMilliseconds;
            logTimer.Tick += new EventHandler(logTimer_Tick);
            logTimer.Enabled = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            keyboardHook.KeyUp += new KeyEventHandler(KeyboardHook_KeyUp);
            keyboardHook.CreateHook();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            keyboardHook.Dispose();
        }

        void KeyboardHook_KeyUp(object sender, KeyEventArgs e)
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

            LogKeypress();
        }

        private void LogKeypress()
        {
            keypressLog.Add(DateTime.Now);
        }

        void logTimer_Tick(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(logFile, true))
            {
                foreach (DateTime item in keypressLog)
                {
                    writer.WriteLine(item.ToString("O"));
                }
                keypressLog.Clear();
            }
        }

        private void StartCount()
        {
            if (options.WindowMode == WindowModes.Minimized)
                this.WindowState = FormWindowState.Minimized;
            timeCounter.Restart();
            keypressCounter = new Int32();
        }

        private void StopCount()
        {
            if (options.WindowMode == WindowModes.Minimized)
                this.WindowState = FormWindowState.Normal;
            this.BringToFront();
            timeCounter.Stop();
        }

        private void IncrementCount()
        {
            if (!timeCounter.IsRunning)
                return;

            keypressCounter++;
        }

        private void UpdateDisplay_Tick(object sender, EventArgs e)
        {
            labelKeypressesVal.Text = keypressCounter.ToString();
            labelTimeVal.Text = timeCounter.Elapsed.ToString("d'.'hh':'mm':'ss'.'ff");
            labelKPMVal.Text = (keypressCounter / timeCounter.Elapsed.TotalMinutes).ToString("0.00");
        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            using (OptionsForm optionsForm = new OptionsForm(options))
            {
                if (optionsForm.ShowDialog() == DialogResult.OK)
                {
                    SaveOptions();
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
                this.labelHotkeys.Visible = true;
            else
                this.labelHotkeys.Visible = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartCount();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopCount();
        }

        private void SaveOptions()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Options));
            using (StreamWriter writer = new StreamWriter(optionsFile))
            {
                serializer.Serialize(writer, options);
            }
        }

        private void LoadOptions()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Options));
            try
            {
                using (StreamReader reader = new StreamReader(optionsFile))
                {
                    options = (Options)serializer.Deserialize(reader);
                }
            }
            catch (FileNotFoundException)
            {
                options = new Options();
            }
        }
    }
}
