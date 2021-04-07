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
using System.Configuration;
using System.Collections.Specialized;
using NAudio.Wave;

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

            //hklist.GetOrAdd("100000S", "C:/Users/Anton/Desktop/cnadycrushwavefrnots/bubble.wav");
            //hklist.GetOrAdd("000000Multiply", "C:/Users/Anton/Desktop/Never Gonna Give You Up Original.wav");
            NameValueCollection sAll;
            sAll = ConfigurationManager.AppSettings;
            Console.WriteLine(ConfigurationManager.GetSection("test")+"asdfdasf");
            for (int i = 0; sAll.AllKeys.Length > i; i++)
            {
                //Console.WriteLine(sAll.AllKeys[i]+"  ");
                hklist.GetOrAdd(sAll.AllKeys[i], sAll.Get(i));
            }
            foreach (var display in hklist)
            {
                Console.WriteLine("" + display.Key+display.Value);
            }

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
            start_listening();
            for (int n = -1; n < WaveOut.DeviceCount; n++)
            {
                var caps = WaveOut.GetCapabilities(n);
                Console.WriteLine($"{n}: {caps.ProductName}");

                comboBox2.Items.AddRange(new object[] {
                caps.ProductName});

                comboBox1.Items.AddRange(new object[] {
                caps.ProductName});

                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
            }
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

                //thread for playing the sound to user
                Soundplayer sndpl1 = new Soundplayer(comboBox1.SelectedIndex-1);//devices start counting from -1 not 0
                Thread thread1 = new Thread(sndpl1.playSound);
                thread1.Start(hklist[forHkList]);

                //thread for injecting into Mic
                Soundplayer sndpl2 = new Soundplayer(comboBox2.SelectedIndex - 1);//devices start counting from -1 not 0
                Thread thread2 = new Thread(sndpl2.playSound);
                thread2.Start(hklist[forHkList]);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainWindow1_Activated(object sender, EventArgs e)
        {

        }

        private WaveIn waveIn = null;
        private BufferedWaveProvider waveProvider = null;
        private WaveOut waveOut = null;

        private void StartBtn_Click(object sender, EventArgs e)
        {
            start_listening();
        }
        private void start_listening() 
        {
            if (waveIn != null)
                return;

            // create wave input from mic
            waveIn = new WaveIn(this.Handle);
            waveIn.BufferMilliseconds = 25;
            waveIn.DataAvailable += waveIn_DataAvailable;
            waveIn.RecordingStopped += waveIn_RecordingStopped;

            // create wave provider
            waveProvider = new BufferedWaveProvider(waveIn.WaveFormat);

            // create wave output to speakers
            waveOut = new WaveOut();
            waveOut.DesiredLatency = 100;
            Console.WriteLine("list auswahl "+comboBox2.SelectedIndex);
            if (comboBox2.SelectedIndex != -1)
                waveOut.DeviceNumber=comboBox2.SelectedIndex-1;
            waveOut.Init(waveProvider);
            waveOut.PlaybackStopped += wavePlayer_PlaybackStopped;

            // start recording and playback
            waveIn.StartRecording();
            waveOut.Play();
        }

        void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            // add received data to waveProvider buffer
            if (waveProvider != null)
                waveProvider.AddSamples(e.Buffer, 0, e.BytesRecorded);
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            if (waveIn != null)
                waveIn.StopRecording();
        }

        void waveIn_RecordingStopped(object sender, StoppedEventArgs e)
        {
            // stop playback
            if (waveOut != null)
                waveOut.Stop();

            // dispose of wave input
            if (waveIn != null)
            {
                waveIn.Dispose();
                waveIn = null;
            }

            // drop wave provider
            waveProvider = null;
        }

        void wavePlayer_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            // stop recording
            if (waveIn != null)
                waveIn.StopRecording();

            // dispose of wave output
            if (waveOut != null)
            {
                waveOut.Dispose();
                waveOut = null;
            }
        }

        private void MainWindow1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (waveIn != null)
                waveIn.StopRecording();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
