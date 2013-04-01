using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyPressCounter
{
    public partial class OptionsForm : Form
    {
        Options parentOptions = new Options();

        public OptionsForm(Options options)
        {
            InitializeComponent();

            parentOptions = options;
            InitializeStates();
        }

        private void InitializeStates()
        {
            switch (parentOptions.WindowMode)
            {
                case WindowModes.None:
                    radioButtonWMNone.Checked = true;
                    break;
                case WindowModes.Minimized:
                    radioButtonWMMinimize.Checked = true;
                    break;
                case WindowModes.AlwaysOnTop:
                    radioButtonWMAlwaysOnTop.Checked = true;
                    this.TopMost = true;
                    break;
            }

            switch (parentOptions.LoggingMode)
            {
                case LoggingModes.Off:
                    radioButtonLMOff.Checked = true;
                    break;
                case LoggingModes.OnlyWhenStarted:
                    radioButtonLMWhenStarted.Checked = true;
                    break;
                case LoggingModes.Always:
                    radioButtonLMAlways.Checked = true;
                    break;
            }

            checkBoxEnableHotkey.Checked = parentOptions.HotkeysEnabled;
        }

        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveOptions();
        }

        private void SaveOptions()
        {
            if (radioButtonWMNone.Checked)
                parentOptions.WindowMode = WindowModes.None;
            else if (radioButtonWMMinimize.Checked)
                parentOptions.WindowMode = WindowModes.Minimized;
            else if (radioButtonWMAlwaysOnTop.Checked)
                parentOptions.WindowMode = WindowModes.AlwaysOnTop;

            if (radioButtonLMOff.Checked)
                parentOptions.LoggingMode = LoggingModes.Off;
            else if (radioButtonLMWhenStarted.Checked)
                parentOptions.LoggingMode = LoggingModes.OnlyWhenStarted;
            else if (radioButtonLMAlways.Checked)
                parentOptions.LoggingMode = LoggingModes.Always;

            parentOptions.HotkeysEnabled = checkBoxEnableHotkey.Checked;
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
