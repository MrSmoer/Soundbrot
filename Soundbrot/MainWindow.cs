using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;
using System.Collections.Concurrent;
using System.Threading;

namespace Soundbrot
{
    public partial class MainWindow1 : Form
    {
        globalKeyboardHook gkh = new globalKeyboardHook();
        ConcurrentDictionary<String, String> hklist = new ConcurrentDictionary<String, String>();
        ConcurrentDictionary<String, int> modKeys = new ConcurrentDictionary<string, int>();


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainWindow1()
        {
            InitializeComponent();

            #region initialize lists
            modKeys["LShiftKey"] = 0;
            modKeys["RShiftKey"] = 0;
            modKeys["LMenu"] = 0;
            modKeys["RMenu"] = 0;
            modKeys["LControlKey"] = 0;
            modKeys["RControlKey"] = 0;

            hklist.GetOrAdd("100000S", "C:/Users/Anton/Desktop/cnadycrushwavefrnots/bubble.wav");
            hklist.GetOrAdd("000000Multiply", "C:/Users/Anton/Desktop/Never Gonna Give You Up Original.wav");
            #endregion
        }

        //Syntax for TKey:
        // 1/0 -> true/false 
        //possible modifier keys: LShiftKey, RShiftKey, LMenu, RMenu, LControlKey, RControlKey (6)
        // example: LShift+S-> 100000S
        String convertForHklist(Keys key, ConcurrentDictionary<String, int> pmodKeys)
        {
            string forHkList = ""
                + pmodKeys["LShiftKey"]
                + pmodKeys["RShiftKey"]
                + pmodKeys["LMenu"]
                + pmodKeys["RMenu"]
                + pmodKeys["LControlKey"]
                + pmodKeys["RControlKey"]
                + key;
            //Console.WriteLine(forHkList);
            return forHkList;
        }

        #region Managing Keyboard listener
        private void MainWindow_Load(object sender, EventArgs e)
        {
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
            gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);
            Console.WriteLine("test");
        }

        void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            String KeyString = e.KeyCode.ToString();
            if (modKeys.ContainsKey(KeyString))
            {
                modKeys[KeyString] = 0;
                Console.WriteLine("modkey released " + convertForHklist(e.KeyCode, modKeys));
                Console.WriteLine(convertForHklist(e.KeyCode, modKeys));
            }
            Console.WriteLine("Up\t" + e.KeyCode.ToString());
            //e.Handled = true;
        }

        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("test");
            String KeyString = e.KeyCode.ToString();
            if (modKeys.ContainsKey(KeyString))
            {
                modKeys[KeyString] = 1;
                Console.WriteLine("modkey pressed " + convertForHklist(e.KeyCode, modKeys));
            }

            Console.WriteLine("Down\t" + e.KeyCode.ToString());
            String forHkList = convertForHklist(e.KeyCode, modKeys);
            if (hklist.ContainsKey(forHkList))
            {
                Console.WriteLine("playSound!");

                Soundplayer sndpl = new Soundplayer();
                Thread thread1 = new Thread(sndpl.playSound);
                thread1.Start(hklist[forHkList]);
            }
            else
            {
                Console.WriteLine("not in lsit");
            }
            //e.Handled = true;
        }
        #endregion




        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void settingsic_Paint(object sender, PaintEventArgs e)
        {

        }

        private void settingsic_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(value: foldoutmenu.Size.Width);
            if (foldoutmenu.Size.Width == 182)
            {
                foldoutmenu.Width = 0;
            }
            else
            {
                foldoutmenu.Width = 182;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        //lights up clickable surfaces

        void control_MouseEnter(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null)
                control.BackColor = System.Drawing.Color.MistyRose;
        }


        void control_MouseLeave(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null)
                control.BackColor = System.Drawing.Color.LightCoral;
        }
        private void MainWindow1_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                SystemTrayIc.Visible = true;
            }
        }
        private void MainWindow_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            SystemTrayIc.Visible = false;
        }

        private void MinimizeToSysTray_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SystemTrayIc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            SystemTrayIc.Visible = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            SystemTrayIc.Visible = false;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void topbar_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
