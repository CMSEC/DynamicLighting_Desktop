using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lighting
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool autoConnector = false;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (autoConnector)
                Application.Run(new AutoConnector());
            else
                Application.Run(new Connector());
            Application.Run(new ColorSystem());
        }
    }
}
