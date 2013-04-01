using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KeyPressCounter
{
    [Serializable]
    public class Options
    {
        public WindowModes WindowMode { get; set; }
        public bool HotkeysEnabled { get; set; }
        public LoggingModes LoggingMode { get; set; }
    }
}
