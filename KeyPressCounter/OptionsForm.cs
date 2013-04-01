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

            parentOptions.HotkeysEnabled = checkBoxEnableHotkey.Checked;
        }
    }
}
