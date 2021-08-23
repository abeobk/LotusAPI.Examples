using LotusAPI;
using LotusAPI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIExample {
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();

            //setup logger
            Logger.Add(new LogViewLogger(logview1));
            logFileWatcher1.Start();

            Library.InitializeNoPlugin();

            btHOME.Checked = true;
        }
    }
}
