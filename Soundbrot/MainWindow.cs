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
        public bool enabled = true; 
        globalKeyboardHook gkh = new globalKeyboardHook();
        ConcurrentDictionary<String, String> hklist = new ConcurrentDictionary<String, String>();
        ConcurrentDictionary<String, int> modKeys = new ConcurrentDictionary<string, int>();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public bool restartListen = false;
        public int listenDevice = 2;
        public int headphones = 1;
        public int mic = 0;

        

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainWindow1()
        {
            InitializeComponent();

            #region initialize lists
            zerInMods();

            //hklist.GetOrAdd("100000S", "C:/Users/Anton/Desktop/cnadycrushwavefrnots/bubble.wav");
            //hklist.GetOrAdd("000000Multiply", "C:/Users/Anton/Desktop/Never Gonna Give You Up Original.wav");
            NameValueCollection sAll;
            sAll = ConfigurationManager.AppSettings;
            
            listenDevice = int.Parse(sAll.Get("listenDevice"));
            headphones = int.Parse(sAll.Get("headphones"));
            mic = int.Parse(sAll.Get("mic"));

            Console.WriteLine("lsdv: "+listenDevice+ " hedfons: "+headphones);

            for (int i = 3; sAll.AllKeys.Length > i; i++)
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

        public void zerInMods()
        {
            modKeys["LShiftKey"] = 0;
            modKeys["RShiftKey"] = 0;
            modKeys["LMenu"] = 0;
            modKeys["RMenu"] = 0;
            modKeys["LControlKey"] = 0;
            modKeys["RControlKey"] = 0;
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

            for (int n = -1; n < WaveOut.DeviceCount; n++)
            {
                var caps = WaveOut.GetCapabilities(n);
                Console.WriteLine($"{n}: {caps.ProductName}");

                cmbBxsHeadphones.Items.AddRange(new object[] {
                caps.ProductName});

                cmbBxListenDevice.Items.AddRange(new object[] {
                caps.ProductName});

            }

            for (int n = -1; n < WaveIn.DeviceCount; n++)
            {
                var miccaps = WaveIn.GetCapabilities(n);
                Console.WriteLine($"{n}: {miccaps.ProductName}");

                cmbBxMic.Items.AddRange(new object[] { 
                miccaps.ProductName});
            }
            if (cmbBxsHeadphones.Items.Count > headphones)
                cmbBxsHeadphones.SelectedIndex = headphones;
            else cmbBxsHeadphones.SelectedIndex = 0;

            if (cmbBxListenDevice.Items.Count > listenDevice)
                cmbBxListenDevice.SelectedIndex = listenDevice;
            else cmbBxListenDevice.SelectedIndex = 0;

            if (cmbBxMic.Items.Count > mic)
                cmbBxMic.SelectedIndex = mic;
            else cmbBxMic.SelectedIndex = 0;
            start_listening();

        }



        void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            if (enabled) {
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
        }

        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            if (enabled)
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
                    Soundplayer sndpl1 = new Soundplayer(cmbBxsHeadphones.SelectedIndex - 1);//devices start counting from -1 not 0
                    Thread thread1 = new Thread(sndpl1.playSound);
                    thread1.Start(hklist[forHkList]);

                    //thread for injecting into Mic
                    Soundplayer sndpl2 = new Soundplayer(cmbBxListenDevice.SelectedIndex - 1);//devices start counting from -1 not 0
                    Thread thread2 = new Thread(sndpl2.playSound);
                    thread2.Start(hklist[forHkList]);
                }
                else
                {
                    Console.WriteLine("not in lsit");
                }
            }
            else Console.WriteLine("Its Disabled");
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
            //Thread.Sleep(10);
            if (waveIn != null)
            {
                Console.WriteLine("already wave there");
                return;
            }


            // create wave input from mic
            waveIn = new WaveIn(this.Handle);
            if (WaveIn.DeviceCount >= mic)
                waveIn.DeviceNumber = mic - 1;
            else Console.WriteLine("else triggerde" + cmbBxMic.SelectedIndex);
            waveIn.BufferMilliseconds = 25;
            waveIn.DataAvailable += waveIn_DataAvailable;
            waveIn.RecordingStopped += waveIn_RecordingStopped;

            // create wave provider
            waveProvider = new BufferedWaveProvider(waveIn.WaveFormat);

            // create wave output to speakers
            waveOut = new WaveOut();
            waveOut.DesiredLatency = 100;
            Console.WriteLine("list auswahl "+listenDevice);

            if (WaveOut.DeviceCount>=listenDevice)
                waveOut.DeviceNumber = listenDevice - 1;
            else Console.WriteLine("else triggerde"+cmbBxListenDevice.SelectedIndex);
            waveOut.Init(waveProvider);
            waveOut.PlaybackStopped += wavePlayer_PlaybackStopped;

            // start recording and playback
            waveIn.StartRecording();
            waveOut.Play();
            Console.WriteLine("listening started");
        }

        void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            // add received data to waveProvider buffer
            if (waveProvider != null)
                waveProvider.AddSamples(e.Buffer, 0, e.BytesRecorded);
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            stopListening();
        }
        public void stopListening()
        {
            if (waveIn != null)
            {
                waveIn.StopRecording();
                Console.WriteLine("");
            }
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

                Console.WriteLine("Done");
            }
            if (restartListen) {
                restartListen = false;
                start_listening();
            }
        }

        private void MainWindow1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (waveIn != null)
                waveIn.StopRecording();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            headphones = cmbBxsHeadphones.SelectedIndex;
            AddUpdateAppSettings("headphones", headphones.ToString());

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listenDevice = cmbBxListenDevice.SelectedIndex;
            stopListening();
            Console.WriteLine("index changed, index: " + cmbBxListenDevice.SelectedIndex);
            Console.WriteLine("asdfds"+listenDevice);
            AddUpdateAppSettings("listenDevice", listenDevice.ToString());
            restartListen = true;
        }

        private void cmbBxMic_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            mic = cmbBxMic.SelectedIndex;
            stopListening();
            AddUpdateAppSettings("mic", mic.ToString());
            restartListen = true;
        }

        static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }

        private void enabledToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (enabledToolStripMenuItem.Checked)
            {
                enabled = true;
                zerInMods();
                enabledChckBx.Checked = true;
            }
            else
            {
                enabled = false;
                zerInMods();
                enabledChckBx.Checked = false;
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (enabledChckBx.Checked)
            {
                enabled = true;
                zerInMods();
                enabledToolStripMenuItem.Checked = true;
            }
            else
            {
                enabled = false;
                zerInMods();
                enabledToolStripMenuItem.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Click");
            Panel pl = CreateHkeyPanel("", "");
            hkeys.Add(pl);
            hkeylistpanel.Controls.Add(pl);
            vScrollBar1.Maximum = hkeylistpanel.Height;
            vScrollBar1.LargeChange = outerPanel.Height;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            string sSelectedFile;
            sSelectedFile = selectFile();
            Console.WriteLine(sSelectedFile);
            pathTextBox.Text = sSelectedFile;
        }

        public string selectFile() {
            string sSelectedFile;
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;

            if (choofdlog.ShowDialog() == DialogResult.OK) 
            { 
                sSelectedFile = choofdlog.FileName;
            }
            else
                sSelectedFile = string.Empty;
            return sSelectedFile;
        }

        List<Panel> hkeys = new List<Panel>();
        public Panel CreateHkeyPanel(string hotkey, string path) 
        {
            int yCord = 13;//hkeys.Count() * 112 + 13;
            if (hkeys.Count > 0)
                yCord = hkeys[hkeys.Count - 1].Location.Y + 103;// hkeys.Count() * 112 + 13;

            Console.Write("hkeyscnt: "+hkeys.Count()+ "ycrd: "+yCord);
            //yCord = 13;
            Panel pnl = new Panel();
            pnl.SuspendLayout();
            Button pdeleteHkey = new Button();
            Label phkeyTitle = new Label();
            Label phkeyLabel = new Label();
            Label psoundpthlabel = new Label();
            TextBox phkeyTextBox = new TextBox();
            Button pselectFileBtn = new Button();
            TextBox ppathTextBox = new TextBox();
            Label pSoundlabel = new Label();

            //pdeleteHKey
            pdeleteHkey.Location = new System.Drawing.Point(635, 15);
            pdeleteHkey.Name = "deleteHkey";
            pdeleteHkey.Size = new System.Drawing.Size(85, 23);
            pdeleteHkey.TabIndex = 16;
            pdeleteHkey.Text = "Delete";
            pdeleteHkey.UseVisualStyleBackColor = true;
            pdeleteHkey.Click += new System.EventHandler(this.button1_Click_1);

            //phkeyTitle
            phkeyTitle.AutoSize = true;
            phkeyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phkeyTitle.Location = new System.Drawing.Point(28, 18);
            phkeyTitle.Name = "hkeyTitle";
            phkeyTitle.Size = new System.Drawing.Size(57, 20);
            phkeyTitle.TabIndex = 15;
            phkeyTitle.Text = "label1";

            //phkeyLabel
            phkeyLabel.AutoSize = true;
            phkeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phkeyLabel.Location = new System.Drawing.Point(29, 63);
            phkeyLabel.Name = "hkeyLabel";
            phkeyLabel.Size = new System.Drawing.Size(56, 17);
            phkeyLabel.TabIndex = 14;
            phkeyLabel.Text = "Hotkey:";

            //psoundpthlabel
            psoundpthlabel.AutoSize = true;
            psoundpthlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            psoundpthlabel.Location = new System.Drawing.Point(342, 63);
            psoundpthlabel.Name = "soundpthlabel";
            psoundpthlabel.Size = new System.Drawing.Size(41, 17);
            psoundpthlabel.TabIndex = 13;
            psoundpthlabel.Text = "Path:";

            //phkeyTextBox
            phkeyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phkeyTextBox.Location = new System.Drawing.Point(87, 60);
            phkeyTextBox.Name = "hkeyTextBox";
            phkeyTextBox.Size = new System.Drawing.Size(201, 23);
            phkeyTextBox.TabIndex = 12;
            phkeyTextBox.Text = "Click here";
            phkeyTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);

            //pselectFileBtn
            pselectFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pselectFileBtn.Location = new System.Drawing.Point(635, 60);
            pselectFileBtn.Name = "selectFileBtn";
            pselectFileBtn.Size = new System.Drawing.Size(86, 23);
            pselectFileBtn.TabIndex = 11;
            pselectFileBtn.Text = "Select File";
            pselectFileBtn.UseVisualStyleBackColor = true;
            pselectFileBtn.Click += new System.EventHandler(this.button2_Click);

            //ppathTextBox
            ppathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ppathTextBox.Location = new System.Drawing.Point(396, 60);
            ppathTextBox.Name = "pathTextBox";
            ppathTextBox.Size = new System.Drawing.Size(237, 23);
            ppathTextBox.TabIndex = 10;
            ppathTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);

            //pSoundlabel
            pSoundlabel.AutoSize = true;
            pSoundlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pSoundlabel.Location = new System.Drawing.Point(8, 8);
            pSoundlabel.Name = "Soundlabel";
            pSoundlabel.Size = new System.Drawing.Size(0, 20);
            pSoundlabel.TabIndex = 9;
            pSoundlabel.Text = this.pathTextBox.Text;
            pSoundlabel.Click += new System.EventHandler(this.Soundlabel_Click);

            //pnl (main panel)
            pnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnl.Controls.Add(pdeleteHkey);
            pnl.Controls.Add(phkeyTitle);
            pnl.Controls.Add(phkeyLabel);
            pnl.Controls.Add(psoundpthlabel);
            pnl.Controls.Add(phkeyTextBox);
            pnl.Controls.Add(pselectFileBtn);
            pnl.Controls.Add(ppathTextBox);
            pnl.Controls.Add(pSoundlabel);
            pnl.Location = new System.Drawing.Point(14, yCord);//13 first y, 119 second: 103 distance
            pnl.Name = "pnl";
            pnl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            pnl.Size = new System.Drawing.Size(746, 100);
            pnl.TabIndex = 7;
            pnl.ResumeLayout(false);
            pnl.PerformLayout();

            return pnl;
        }

        private void Soundlabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int diference = e.OldValue - e.NewValue;
            scrollWindw(diference);
        }

        private void scrollWindw(int delta) 
        {
            foreach (Control c in outerPanel.Controls)
            {
                c.Location = new Point(c.Location.X, c.Location.Y + delta);
            }

        }

        private void outerPanel_MouseEnter(object sender, EventArgs e)
        {
            vScrollBar1.Focus();
            //Console.WriteLine("Wfdasd");
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

    }

}
