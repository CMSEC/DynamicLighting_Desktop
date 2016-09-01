using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Forms;
using Lighting;

namespace Lighting
{
    class KeyMacro
    {
        public string Name = "UNTITLED MACRO";
        public List<Keys> bindings = new List<Keys>();

        States state;
        Color color;

        Transitions transCurrent;
        decimal transSpeed;

        Idle idleCurrent;
        decimal cycleSpeed;
        decimal cycleDelay;
        Color idleColorCurrent;
        bool idleReverse;

        public KeyMacro ()
        {
        }
    }
}
