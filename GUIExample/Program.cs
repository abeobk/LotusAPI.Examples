using LotusAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIExample {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Registry.SetApplicationName("Abeosystem\\Example\\GUI");

            var f = Abeo.Controls.Dialogs.SplashWindow.CreateForm_<FormMain>(null, "Example app", true, 2000);
            Application.Run(f);
        }
    }
}
