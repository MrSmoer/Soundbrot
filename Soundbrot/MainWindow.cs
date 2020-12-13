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

namespace Soundbrot
{
    public partial class MainWindow1 : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainWindow1()
        {
            InitializeComponent();
        }


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
    }

}
