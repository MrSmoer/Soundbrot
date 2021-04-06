using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;
using System.Runtime.InteropServices;
using System.Collections.Concurrent;
using System.Windows.Input;
using System.IO;
using NAudio.Wave;
using System.Threading;

namespace Soundbrot
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow1());
       }
    }
}
