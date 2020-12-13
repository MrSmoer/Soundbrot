
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
            this.Menuic = new System.Windows.Forms.Panel();
            this.content = new System.Windows.Forms.Panel();
            this.foldoutmenu = new System.Windows.Forms.Panel();
            this.SetsPanel = new System.Windows.Forms.Panel();
            this.setsgear = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FoldP1 = new System.Windows.Forms.Panel();
            this.foldl1 = new System.Windows.Forms.Label();
            this.FoldP2 = new System.Windows.Forms.Panel();
            this.foldl2 = new System.Windows.Forms.Label();
            this.FoldP3 = new System.Windows.Forms.Panel();
            this.foldl3 = new System.Windows.Forms.Label();
            this.FoldP4 = new System.Windows.Forms.Panel();
            this.foldl4 = new System.Windows.Forms.Label();
            this.FoldP5 = new System.Windows.Forms.Panel();
            this.foldl5 = new System.Windows.Forms.Label();
            this.SystemTrayIc = new System.Windows.Forms.NotifyIcon(this.components);
            this.SysTrayConMen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topbar.SuspendLayout();
            this.foldoutmenu.SuspendLayout();
            this.SetsPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.FoldP1.SuspendLayout();
            this.FoldP2.SuspendLayout();
            this.FoldP3.SuspendLayout();
            this.FoldP4.SuspendLayout();
            this.FoldP5.SuspendLayout();
            this.SysTrayConMen.SuspendLayout();
            this.SuspendLayout();
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.LightCoral;
            this.topbar.Controls.Add(this.MinimizeToSysTray);
            this.topbar.Controls.Add(this.Headline);
            this.topbar.Controls.Add(this.close);
            this.topbar.Controls.Add(this.Menuic);
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
            this.Headline.Location = new System.Drawing.Point(55, 13);
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
            // Menuic
            // 
            this.Menuic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Menuic.BackgroundImage")));
            this.Menuic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menuic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menuic.Location = new System.Drawing.Point(12, 6);
            this.Menuic.Name = "Menuic";
            this.Menuic.Size = new System.Drawing.Size(35, 41);
            this.Menuic.TabIndex = 0;
            this.Menuic.Click += new System.EventHandler(this.settingsic_Click);
            this.Menuic.Paint += new System.Windows.Forms.PaintEventHandler(this.settingsic_Paint);
            this.Menuic.MouseEnter += new System.EventHandler(this.control_MouseEnter);
            this.Menuic.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // content
            // 
            this.content.Dock = System.Windows.Forms.DockStyle.Right;
            this.content.Location = new System.Drawing.Point(0, 54);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(800, 396);
            this.content.TabIndex = 1;
            // 
            // foldoutmenu
            // 
            this.foldoutmenu.BackColor = System.Drawing.Color.LightCoral;
            this.foldoutmenu.Controls.Add(this.SetsPanel);
            this.foldoutmenu.Controls.Add(this.tableLayoutPanel1);
            this.foldoutmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.foldoutmenu.Location = new System.Drawing.Point(0, 54);
            this.foldoutmenu.Name = "foldoutmenu";
            this.foldoutmenu.Size = new System.Drawing.Size(182, 396);
            this.foldoutmenu.TabIndex = 2;
            // 
            // SetsPanel
            // 
            this.SetsPanel.Controls.Add(this.setsgear);
            this.SetsPanel.Controls.Add(this.label7);
            this.SetsPanel.Controls.Add(this.label6);
            this.SetsPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetsPanel.Location = new System.Drawing.Point(3, 332);
            this.SetsPanel.Name = "SetsPanel";
            this.SetsPanel.Size = new System.Drawing.Size(176, 61);
            this.SetsPanel.TabIndex = 1;
            this.SetsPanel.MouseEnter += new System.EventHandler(this.control_MouseEnter);
            this.SetsPanel.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // setsgear
            // 
            this.setsgear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("setsgear.BackgroundImage")));
            this.setsgear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.setsgear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setsgear.Location = new System.Drawing.Point(24, 16);
            this.setsgear.Name = "setsgear";
            this.setsgear.Size = new System.Drawing.Size(30, 30);
            this.setsgear.TabIndex = 2;
            this.setsgear.MouseEnter += new System.EventHandler(this.control_MouseEnter);
            this.setsgear.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Calibri", 16.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(54, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 27);
            this.label7.TabIndex = 1;
            this.label7.Text = "Settings";
            this.label7.MouseEnter += new System.EventHandler(this.control_MouseEnter);
            this.label7.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "kgkgkllkg";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.FoldP1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FoldP2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.FoldP3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.FoldP4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.FoldP5, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(182, 276);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FoldP1
            // 
            this.FoldP1.Controls.Add(this.foldl1);
            this.FoldP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FoldP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FoldP1.Location = new System.Drawing.Point(3, 3);
            this.FoldP1.Name = "FoldP1";
            this.FoldP1.Size = new System.Drawing.Size(176, 49);
            this.FoldP1.TabIndex = 0;
            this.FoldP1.MouseEnter += new System.EventHandler(this.control_MouseEnter);
            this.FoldP1.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // foldl1
            // 
            this.foldl1.AutoSize = true;
            this.foldl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foldl1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foldl1.Location = new System.Drawing.Point(47, 13);
            this.foldl1.Name = "foldl1";
            this.foldl1.Size = new System.Drawing.Size(82, 23);
            this.foldl1.TabIndex = 0;
            this.foldl1.Text = "Profile X:";
            this.foldl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.foldl1.Click += new System.EventHandler(this.label1_Click);
            this.foldl1.MouseEnter += new System.EventHandler(this.control_MouseEnter);
            this.foldl1.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // FoldP2
            // 
            this.FoldP2.Controls.Add(this.foldl2);
            this.FoldP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FoldP2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FoldP2.Location = new System.Drawing.Point(3, 58);
            this.FoldP2.Name = "FoldP2";
            this.FoldP2.Size = new System.Drawing.Size(176, 49);
            this.FoldP2.TabIndex = 1;
            this.FoldP2.MouseEnter += new System.EventHandler(this.control_MouseEnter);
            this.FoldP2.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // foldl2
            // 
            this.foldl2.AutoSize = true;
            this.foldl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foldl2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foldl2.Location = new System.Drawing.Point(47, 13);
            this.foldl2.Name = "foldl2";
            this.foldl2.Size = new System.Drawing.Size(82, 23);
            this.foldl2.TabIndex = 1;
            this.foldl2.Text = "Profile X:";
            this.foldl2.MouseEnter += new System.EventHandler(this.control_MouseEnter);
            this.foldl2.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // FoldP3
            // 
            this.FoldP3.Controls.Add(this.foldl3);
            this.FoldP3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FoldP3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FoldP3.Location = new System.Drawing.Point(3, 113);
            this.FoldP3.Name = "FoldP3";
            this.FoldP3.Size = new System.Drawing.Size(176, 49);
            this.FoldP3.TabIndex = 2;
            this.FoldP3.MouseEnter += new System.EventHandler(this.control_MouseEnter);
            this.FoldP3.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // foldl3
            // 
            this.foldl3.AutoSize = true;
            this.foldl3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foldl3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foldl3.Location = new System.Drawing.Point(47, 13);
            this.foldl3.Name = "foldl3";
            this.foldl3.Size = new System.Drawing.Size(82, 23);
            this.foldl3.TabIndex = 1;
            this.foldl3.Text = "Profile X:";
            this.foldl3.MouseEnter += new System.EventHandler(this.control_MouseEnter);
            this.foldl3.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // FoldP4
            // 
            this.FoldP4.Controls.Add(this.foldl4);
            this.FoldP4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FoldP4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FoldP4.Location = new System.Drawing.Point(3, 168);
            this.FoldP4.Name = "FoldP4";
            this.FoldP4.Size = new System.Drawing.Size(176, 49);
            this.FoldP4.TabIndex = 3;
            this.FoldP4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            this.FoldP4.MouseEnter += new System.EventHandler(this.control_MouseEnter);
            this.FoldP4.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // foldl4
            // 
            this.foldl4.AutoSize = true;
            this.foldl4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foldl4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foldl4.Location = new System.Drawing.Point(47, 13);
            this.foldl4.Name = "foldl4";
            this.foldl4.Size = new System.Drawing.Size(82, 23);
            this.foldl4.TabIndex = 1;
            this.foldl4.Text = "Profile X:";
            this.foldl4.MouseEnter += new System.EventHandler(this.control_MouseEnter);
            this.foldl4.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // FoldP5
            // 
            this.FoldP5.Controls.Add(this.foldl5);
            this.FoldP5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FoldP5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FoldP5.Location = new System.Drawing.Point(3, 223);
            this.FoldP5.Name = "FoldP5";
            this.FoldP5.Size = new System.Drawing.Size(176, 50);
            this.FoldP5.TabIndex = 4;
            this.FoldP5.MouseEnter += new System.EventHandler(this.control_MouseEnter);
            this.FoldP5.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // foldl5
            // 
            this.foldl5.AutoSize = true;
            this.foldl5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foldl5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foldl5.Location = new System.Drawing.Point(47, 14);
            this.foldl5.Name = "foldl5";
            this.foldl5.Size = new System.Drawing.Size(82, 23);
            this.foldl5.TabIndex = 1;
            this.foldl5.Text = "Profile X:";
            this.foldl5.MouseEnter += new System.EventHandler(this.control_MouseEnter);
            this.foldl5.MouseLeave += new System.EventHandler(this.control_MouseLeave);
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
            // MainWindow1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.foldoutmenu);
            this.Controls.Add(this.content);
            this.Controls.Add(this.topbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow1";
            this.Resize += new System.EventHandler(this.MainWindow1_Resize);
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            this.foldoutmenu.ResumeLayout(false);
            this.SetsPanel.ResumeLayout(false);
            this.SetsPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.FoldP1.ResumeLayout(false);
            this.FoldP1.PerformLayout();
            this.FoldP2.ResumeLayout(false);
            this.FoldP2.PerformLayout();
            this.FoldP3.ResumeLayout(false);
            this.FoldP3.PerformLayout();
            this.FoldP4.ResumeLayout(false);
            this.FoldP4.PerformLayout();
            this.FoldP5.ResumeLayout(false);
            this.FoldP5.PerformLayout();
            this.SysTrayConMen.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Panel foldoutmenu;
        private System.Windows.Forms.Panel Menuic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel FoldP1;
        private System.Windows.Forms.Panel FoldP2;
        private System.Windows.Forms.Panel FoldP3;
        private System.Windows.Forms.Panel FoldP4;
        private System.Windows.Forms.Panel FoldP5;
        private System.Windows.Forms.Label foldl1;
        private System.Windows.Forms.Label foldl2;
        private System.Windows.Forms.Label foldl3;
        private System.Windows.Forms.Label foldl4;
        private System.Windows.Forms.Label foldl5;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label Headline;
        private System.Windows.Forms.Panel SetsPanel;
        private System.Windows.Forms.Panel setsgear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private NotifyIcon SystemTrayIc;
        private ContextMenuStrip SysTrayConMen;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem enabledToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Label MinimizeToSysTray;
    }
}

