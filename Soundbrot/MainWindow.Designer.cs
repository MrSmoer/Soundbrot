
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
            this.StopBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SystemTrayIc = new System.Windows.Forms.NotifyIcon(this.components);
            this.SysTrayConMen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.topbar.SuspendLayout();
            this.content.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SysTrayConMen.SuspendLayout();
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
            this.content.Controls.Add(this.StopBtn);
            this.content.Controls.Add(this.StartBtn);
            this.content.Controls.Add(this.panel2);
            this.content.Controls.Add(this.panel1);
            this.content.Dock = System.Windows.Forms.DockStyle.Right;
            this.content.Location = new System.Drawing.Point(0, 54);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(800, 396);
            this.content.TabIndex = 1;
            this.content.Paint += new System.Windows.Forms.PaintEventHandler(this.content_Paint);
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(288, 108);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(75, 23);
            this.StopBtn.TabIndex = 4;
            this.StopBtn.Text = "button2";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(158, 109);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "button1";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(430, 331);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 28);
            this.panel2.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(176, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 21);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Location = new System.Drawing.Point(430, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 28);
            this.panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Location = new System.Drawing.Point(176, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.profileToolStripMenuItem,
            this.enabledToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.SysTrayConMen.Name = "SysTrayConMen";
            this.SysTrayConMen.Size = new System.Drawing.Size(117, 92);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // enabledToolStripMenuItem
            // 
            this.enabledToolStripMenuItem.Checked = true;
            this.enabledToolStripMenuItem.CheckOnClick = true;
            this.enabledToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enabledToolStripMenuItem.Name = "enabledToolStripMenuItem";
            this.enabledToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.enabledToolStripMenuItem.Text = "Enabled";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select your Headphones here:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select your Cable input here :";
            // 
            // MainWindow1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.content);
            this.Controls.Add(this.topbar);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SysTrayConMen.ResumeLayout(false);
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
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem enabledToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Label MinimizeToSysTray;
        private Panel panel1;
        private ComboBox comboBox1;
        private Panel panel2;
        private ComboBox comboBox2;
        private Button StopBtn;
        private Button StartBtn;
        private Label label1;
        private Label label2;
    }
}

