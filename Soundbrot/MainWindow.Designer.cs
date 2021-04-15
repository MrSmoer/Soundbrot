
using System;
using System.Windows.Forms;

namespace Soundbrot
{
    partial class MainWindow1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows MainWindow Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow1));
            this.topbar = new System.Windows.Forms.Panel();
            this.MinimizeToSysTray = new System.Windows.Forms.Label();
            this.Headline = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.outerPanel = new System.Windows.Forms.Panel();
            this.hkeylistpanel = new System.Windows.Forms.Panel();
            this.createSoundBtn = new System.Windows.Forms.Button();
            this.enabledChckBx = new System.Windows.Forms.CheckBox();
            this.headphonesPanel = new System.Windows.Forms.Panel();
            this.selectHeaphones = new System.Windows.Forms.Label();
            this.cmbBxsHeadphones = new System.Windows.Forms.ComboBox();
            this.listenDevicePanel = new System.Windows.Forms.Panel();
            this.selectListenDevice = new System.Windows.Forms.Label();
            this.cmbBxListenDevice = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hkeypanel = new System.Windows.Forms.Panel();
            this.deleteHkey = new System.Windows.Forms.Button();
            this.hkeyTitle = new System.Windows.Forms.Label();
            this.hkeyLabel = new System.Windows.Forms.Label();
            this.soundpthlabel = new System.Windows.Forms.Label();
            this.hkeyTextBox = new System.Windows.Forms.TextBox();
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.Soundlabel = new System.Windows.Forms.Label();
            this.SystemTrayIc = new System.Windows.Forms.NotifyIcon(this.components);
            this.SysTrayConMen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbBxMic = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.topbar.SuspendLayout();
            this.content.SuspendLayout();
            this.outerPanel.SuspendLayout();
            this.headphonesPanel.SuspendLayout();
            this.listenDevicePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.hkeypanel.SuspendLayout();
            this.SysTrayConMen.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.LightCoral;
            this.topbar.Controls.Add(this.MinimizeToSysTray);
            this.topbar.Controls.Add(this.Headline);
            this.topbar.Controls.Add(this.close);
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.Location = new System.Drawing.Point(0, 0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(800, 54);
            this.topbar.TabIndex = 0;
            this.topbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseMove);
            // 
            // MinimizeToSysTray
            // 
            this.MinimizeToSysTray.AutoSize = true;
            this.MinimizeToSysTray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeToSysTray.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.MinimizeToSysTray.Location = new System.Drawing.Point(736, 17);
            this.MinimizeToSysTray.Name = "MinimizeToSysTray";
            this.MinimizeToSysTray.Size = new System.Drawing.Size(18, 26);
            this.MinimizeToSysTray.TabIndex = 4;
            this.MinimizeToSysTray.Text = "-";
            this.MinimizeToSysTray.Click += new System.EventHandler(this.MinimizeToSysTray_Click);
            // 
            // Headline
            // 
            this.Headline.AutoSize = true;
            this.Headline.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Headline.Location = new System.Drawing.Point(12, 12);
            this.Headline.Name = "Headline";
            this.Headline.Size = new System.Drawing.Size(129, 31);
            this.Headline.TabIndex = 3;
            this.Headline.Text = "Soundbrot";
            this.Headline.Click += new System.EventHandler(this.label6_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(755, 13);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(24, 26);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.control_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // content
            // 
            this.content.Controls.Add(this.panel4);
            this.content.Controls.Add(this.vScrollBar1);
            this.content.Controls.Add(this.outerPanel);
            this.content.Controls.Add(this.createSoundBtn);
            this.content.Controls.Add(this.enabledChckBx);
            this.content.Controls.Add(this.headphonesPanel);
            this.content.Controls.Add(this.listenDevicePanel);
            this.content.Dock = System.Windows.Forms.DockStyle.Right;
            this.content.Location = new System.Drawing.Point(0, 54);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(800, 396);
            this.content.TabIndex = 1;
            this.content.Paint += new System.Windows.Forms.PaintEventHandler(this.content_Paint);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = this.outerPanel.Height;
            this.vScrollBar1.Location = new System.Drawing.Point(773, 16);
            this.vScrollBar1.Maximum = this.hkeylistpanel.Height;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(18, 302);
            this.vScrollBar1.SmallChange = 20;
            this.vScrollBar1.TabIndex = 20;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // outerPanel
            // 
            this.outerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outerPanel.Controls.Add(this.hkeylistpanel);
            this.outerPanel.Location = new System.Drawing.Point(18, 16);
            this.outerPanel.Name = "outerPanel";
            this.outerPanel.Size = new System.Drawing.Size(770, 303);
            this.outerPanel.TabIndex = 21;
            this.outerPanel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            this.outerPanel.MouseEnter += new System.EventHandler(this.outerPanel_MouseEnter);
            // 
            // hkeylistpanel
            // 
            this.hkeylistpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hkeylistpanel.AutoSize = true;
            this.hkeylistpanel.Location = new System.Drawing.Point(3, 1);
            this.hkeylistpanel.Name = "hkeylistpanel";
            this.hkeylistpanel.Size = new System.Drawing.Size(757, 289);
            this.hkeylistpanel.TabIndex = 7;
            this.hkeylistpanel.MouseEnter += new System.EventHandler(this.outerPanel_MouseEnter);
            // 
            // createSoundBtn
            // 
            this.createSoundBtn.BackColor = System.Drawing.SystemColors.Window;
            this.createSoundBtn.Location = new System.Drawing.Point(12, 325);
            this.createSoundBtn.Name = "createSoundBtn";
            this.createSoundBtn.Size = new System.Drawing.Size(75, 23);
            this.createSoundBtn.TabIndex = 8;
            this.createSoundBtn.Text = "New Sound";
            this.createSoundBtn.UseVisualStyleBackColor = false;
            this.createSoundBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // enabledChckBx
            // 
            this.enabledChckBx.AutoSize = true;
            this.enabledChckBx.Checked = true;
            this.enabledChckBx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enabledChckBx.Location = new System.Drawing.Point(12, 358);
            this.enabledChckBx.Name = "enabledChckBx";
            this.enabledChckBx.Size = new System.Drawing.Size(65, 17);
            this.enabledChckBx.TabIndex = 5;
            this.enabledChckBx.Text = "Enabled";
            this.enabledChckBx.UseVisualStyleBackColor = true;
            this.enabledChckBx.CheckedChanged += new System.EventHandler(this.checkBox1_Click);
            // 
            // headphonesPanel
            // 
            this.headphonesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.headphonesPanel.Controls.Add(this.selectHeaphones);
            this.headphonesPanel.Controls.Add(this.cmbBxsHeadphones);
            this.headphonesPanel.Location = new System.Drawing.Point(430, 331);
            this.headphonesPanel.Name = "headphonesPanel";
            this.headphonesPanel.Size = new System.Drawing.Size(367, 28);
            this.headphonesPanel.TabIndex = 2;
            // 
            // selectHeaphones
            // 
            this.selectHeaphones.AutoSize = true;
            this.selectHeaphones.Location = new System.Drawing.Point(19, 7);
            this.selectHeaphones.Name = "selectHeaphones";
            this.selectHeaphones.Size = new System.Drawing.Size(151, 13);
            this.selectHeaphones.TabIndex = 5;
            this.selectHeaphones.Text = "Select your Headphones here:";
            // 
            // cmbBxsHeadphones
            // 
            this.cmbBxsHeadphones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBxsHeadphones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxsHeadphones.FormattingEnabled = true;
            this.cmbBxsHeadphones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbBxsHeadphones.Location = new System.Drawing.Point(176, 3);
            this.cmbBxsHeadphones.Name = "cmbBxsHeadphones";
            this.cmbBxsHeadphones.Size = new System.Drawing.Size(182, 21);
            this.cmbBxsHeadphones.TabIndex = 0;
            this.cmbBxsHeadphones.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listenDevicePanel
            // 
            this.listenDevicePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listenDevicePanel.Controls.Add(this.selectListenDevice);
            this.listenDevicePanel.Controls.Add(this.cmbBxListenDevice);
            this.listenDevicePanel.Location = new System.Drawing.Point(430, 365);
            this.listenDevicePanel.Name = "listenDevicePanel";
            this.listenDevicePanel.Size = new System.Drawing.Size(367, 28);
            this.listenDevicePanel.TabIndex = 1;
            // 
            // selectListenDevice
            // 
            this.selectListenDevice.AutoSize = true;
            this.selectListenDevice.Location = new System.Drawing.Point(19, 9);
            this.selectListenDevice.Name = "selectListenDevice";
            this.selectListenDevice.Size = new System.Drawing.Size(146, 13);
            this.selectListenDevice.TabIndex = 6;
            this.selectListenDevice.Text = "Select your Cable input here :";
            // 
            // cmbBxListenDevice
            // 
            this.cmbBxListenDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBxListenDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxListenDevice.FormattingEnabled = true;
            this.cmbBxListenDevice.Location = new System.Drawing.Point(176, 3);
            this.cmbBxListenDevice.Name = "cmbBxListenDevice";
            this.cmbBxListenDevice.Size = new System.Drawing.Size(182, 21);
            this.cmbBxListenDevice.TabIndex = 0;
            this.cmbBxListenDevice.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScrollMargin = new System.Drawing.Size(0, 12);
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.textBox6);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(14, 339);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel3.Size = new System.Drawing.Size(727, 100);
            this.panel3.TabIndex = 19;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(635, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Hotkey:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(342, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Path:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(87, 60);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(201, 23);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "Click here";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(635, 60);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Select File";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(396, 60);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(237, 23);
            this.textBox6.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = this.textBox6.Text;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(14, 230);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(727, 100);
            this.panel2.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(635, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hotkey:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(342, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Path:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(87, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(201, 23);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "Click here";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(635, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Select File";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(396, 60);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(237, 23);
            this.textBox4.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = this.textBox4.Text;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(14, 119);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(727, 100);
            this.panel1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(635, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "label2";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hotkey:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Path:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(87, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 23);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Click here";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(635, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Select File";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(396, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 23);
            this.textBox2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = this.textBox2.Text;
            // 
            // hkeypanel
            // 
            this.hkeypanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hkeypanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hkeypanel.Controls.Add(this.deleteHkey);
            this.hkeypanel.Controls.Add(this.hkeyTitle);
            this.hkeypanel.Controls.Add(this.hkeyLabel);
            this.hkeypanel.Controls.Add(this.soundpthlabel);
            this.hkeypanel.Controls.Add(this.hkeyTextBox);
            this.hkeypanel.Controls.Add(this.selectFileBtn);
            this.hkeypanel.Controls.Add(this.pathTextBox);
            this.hkeypanel.Controls.Add(this.Soundlabel);
            this.hkeypanel.Location = new System.Drawing.Point(14, 13);
            this.hkeypanel.Name = "hkeypanel";
            this.hkeypanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hkeypanel.Size = new System.Drawing.Size(727, 100);
            this.hkeypanel.TabIndex = 7;
            // 
            // deleteHkey
            // 
            this.deleteHkey.Location = new System.Drawing.Point(635, 15);
            this.deleteHkey.Name = "deleteHkey";
            this.deleteHkey.Size = new System.Drawing.Size(85, 23);
            this.deleteHkey.TabIndex = 16;
            this.deleteHkey.Text = "Delete";
            this.deleteHkey.UseVisualStyleBackColor = true;
            this.deleteHkey.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // hkeyTitle
            // 
            this.hkeyTitle.AutoSize = true;
            this.hkeyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hkeyTitle.Location = new System.Drawing.Point(28, 18);
            this.hkeyTitle.Name = "hkeyTitle";
            this.hkeyTitle.Size = new System.Drawing.Size(57, 20);
            this.hkeyTitle.TabIndex = 15;
            this.hkeyTitle.Text = "label1";
            // 
            // hkeyLabel
            // 
            this.hkeyLabel.AutoSize = true;
            this.hkeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hkeyLabel.Location = new System.Drawing.Point(29, 63);
            this.hkeyLabel.Name = "hkeyLabel";
            this.hkeyLabel.Size = new System.Drawing.Size(56, 17);
            this.hkeyLabel.TabIndex = 14;
            this.hkeyLabel.Text = "Hotkey:";
            // 
            // soundpthlabel
            // 
            this.soundpthlabel.AutoSize = true;
            this.soundpthlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundpthlabel.Location = new System.Drawing.Point(342, 63);
            this.soundpthlabel.Name = "soundpthlabel";
            this.soundpthlabel.Size = new System.Drawing.Size(41, 17);
            this.soundpthlabel.TabIndex = 13;
            this.soundpthlabel.Text = "Path:";
            // 
            // hkeyTextBox
            // 
            this.hkeyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hkeyTextBox.Location = new System.Drawing.Point(87, 60);
            this.hkeyTextBox.Name = "hkeyTextBox";
            this.hkeyTextBox.Size = new System.Drawing.Size(201, 23);
            this.hkeyTextBox.TabIndex = 12;
            this.hkeyTextBox.Text = "Click here";
            this.hkeyTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFileBtn.Location = new System.Drawing.Point(635, 60);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(86, 23);
            this.selectFileBtn.TabIndex = 11;
            this.selectFileBtn.Text = "Select File";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathTextBox.Location = new System.Drawing.Point(396, 60);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(237, 23);
            this.pathTextBox.TabIndex = 10;
            this.pathTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Soundlabel
            // 
            this.Soundlabel.AutoSize = true;
            this.Soundlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soundlabel.Location = new System.Drawing.Point(8, 8);
            this.Soundlabel.Name = "Soundlabel";
            this.Soundlabel.Size = new System.Drawing.Size(0, 20);
            this.Soundlabel.TabIndex = 9;
            this.Soundlabel.Text = this.pathTextBox.Text;
            this.Soundlabel.Click += new System.EventHandler(this.Soundlabel_Click);
            // 
            // SystemTrayIc
            // 
            this.SystemTrayIc.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SystemTrayIc.BalloonTipText = "Doubleclick to open Soundbrot";
            this.SystemTrayIc.ContextMenuStrip = this.SysTrayConMen;
            this.SystemTrayIc.Icon = ((System.Drawing.Icon)(resources.GetObject("SystemTrayIc.Icon")));
            this.SystemTrayIc.Text = "Doubleclick to open Soundbrot";
            this.SystemTrayIc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SystemTrayIc_MouseDoubleClick);
            // 
            // SysTrayConMen
            // 
            this.SysTrayConMen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.enabledToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.SysTrayConMen.Name = "SysTrayConMen";
            this.SysTrayConMen.Size = new System.Drawing.Size(117, 70);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // enabledToolStripMenuItem
            // 
            this.enabledToolStripMenuItem.Checked = true;
            this.enabledToolStripMenuItem.CheckOnClick = true;
            this.enabledToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enabledToolStripMenuItem.Name = "enabledToolStripMenuItem";
            this.enabledToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.enabledToolStripMenuItem.Text = "Enabled";
            this.enabledToolStripMenuItem.CheckedChanged += new System.EventHandler(this.enabledToolStripMenuItem_CheckedChanged);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Select mic:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // cmbBxMic
            // 
            this.cmbBxMic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBxMic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxMic.FormattingEnabled = true;
            this.cmbBxMic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbBxMic.Location = new System.Drawing.Point(68, 3);
            this.cmbBxMic.Name = "cmbBxMic";
            this.cmbBxMic.Size = new System.Drawing.Size(172, 21);
            this.cmbBxMic.TabIndex = 0;
            this.cmbBxMic.SelectedIndexChanged += new System.EventHandler(this.cmbBxMic_SelectedIndexChanged_1);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.cmbBxMic);
            this.panel4.Location = new System.Drawing.Point(175, 331);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(249, 28);
            this.panel4.TabIndex = 6;
            // 
            // MainWindow1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.content);
            this.Controls.Add(this.topbar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow1";
            this.Activated += new System.EventHandler(this.MainWindow1_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow1_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += new System.EventHandler(this.MainWindow1_Resize);
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.outerPanel.ResumeLayout(false);
            this.outerPanel.PerformLayout();
            this.headphonesPanel.ResumeLayout(false);
            this.headphonesPanel.PerformLayout();
            this.listenDevicePanel.ResumeLayout(false);
            this.listenDevicePanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.hkeypanel.ResumeLayout(false);
            this.hkeypanel.PerformLayout();
            this.SysTrayConMen.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label Headline;
        private NotifyIcon SystemTrayIc;
        private ContextMenuStrip SysTrayConMen;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem enabledToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Label MinimizeToSysTray;
        private Panel listenDevicePanel;
        private ComboBox cmbBxsHeadphones;
        private Panel headphonesPanel;
        private ComboBox cmbBxListenDevice;
        private Label selectHeaphones;
        private Label selectListenDevice;
        private CheckBox enabledChckBx;
        private Panel hkeylistpanel;
        private Button createSoundBtn;
        private Panel panel1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button2;
        private TextBox textBox2;
        private Label label4;
        private Panel panel3;
        private Button button5;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox5;
        private Button button6;
        private TextBox textBox6;
        private Label label12;
        private Panel panel2;
        private Button button3;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private Button button4;
        private TextBox textBox4;
        private Label label8;
        private VScrollBar vScrollBar1;
        private Panel outerPanel;
        private Panel hkeypanel;
        private Button deleteHkey;
        private Label hkeyTitle;
        private Label hkeyLabel;
        private Label soundpthlabel;
        private TextBox hkeyTextBox;
        private Button selectFileBtn;
        private TextBox pathTextBox;
        private Label Soundlabel;
        private Panel panel4;
        private Label label13;
        private ComboBox cmbBxMic;
    }
}

