
namespace AppTimer
{
    partial class MainWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topleftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toprightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomleftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomrightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keepOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clear_button = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.hours_label = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.decrease_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.songname = new System.Windows.Forms.Label();
            this.mediabutton = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.lockPositionToolStripMenuItem,
            this.keepOnTopToolStripMenuItem,
            this.volumeChangeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 114);
            this.contextMenuStrip1.DoubleClick += new System.EventHandler(this.contextMenuStrip1_DoubleClick);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // lockPositionToolStripMenuItem
            // 
            this.lockPositionToolStripMenuItem.CheckOnClick = true;
            this.lockPositionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topleftToolStripMenuItem,
            this.toprightToolStripMenuItem,
            this.bottomleftToolStripMenuItem,
            this.bottomrightToolStripMenuItem,
            this.unlockToolStripMenuItem});
            this.lockPositionToolStripMenuItem.Name = "lockPositionToolStripMenuItem";
            this.lockPositionToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.lockPositionToolStripMenuItem.Text = "Lock position";
            // 
            // topleftToolStripMenuItem
            // 
            this.topleftToolStripMenuItem.Name = "topleftToolStripMenuItem";
            this.topleftToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.topleftToolStripMenuItem.Text = "top-left";
            this.topleftToolStripMenuItem.Click += new System.EventHandler(this.topleftToolStripMenuItem_Click);
            // 
            // toprightToolStripMenuItem
            // 
            this.toprightToolStripMenuItem.Name = "toprightToolStripMenuItem";
            this.toprightToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.toprightToolStripMenuItem.Text = "top-right";
            this.toprightToolStripMenuItem.Click += new System.EventHandler(this.toprightToolStripMenuItem_Click);
            // 
            // bottomleftToolStripMenuItem
            // 
            this.bottomleftToolStripMenuItem.Name = "bottomleftToolStripMenuItem";
            this.bottomleftToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.bottomleftToolStripMenuItem.Text = "bottom-left";
            this.bottomleftToolStripMenuItem.Click += new System.EventHandler(this.bottomleftToolStripMenuItem_Click);
            // 
            // bottomrightToolStripMenuItem
            // 
            this.bottomrightToolStripMenuItem.Name = "bottomrightToolStripMenuItem";
            this.bottomrightToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.bottomrightToolStripMenuItem.Text = "bottom-right";
            this.bottomrightToolStripMenuItem.Click += new System.EventHandler(this.bottomrightToolStripMenuItem_Click);
            // 
            // unlockToolStripMenuItem
            // 
            this.unlockToolStripMenuItem.Name = "unlockToolStripMenuItem";
            this.unlockToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.unlockToolStripMenuItem.Text = "unlock";
            this.unlockToolStripMenuItem.Click += new System.EventHandler(this.unlockToolStripMenuItem_Click);
            // 
            // keepOnTopToolStripMenuItem
            // 
            this.keepOnTopToolStripMenuItem.CheckOnClick = true;
            this.keepOnTopToolStripMenuItem.Name = "keepOnTopToolStripMenuItem";
            this.keepOnTopToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.keepOnTopToolStripMenuItem.Text = "Keep on top";
            this.keepOnTopToolStripMenuItem.Click += new System.EventHandler(this.keepOnTopToolStripMenuItem_Click);
            // 
            // volumeChangeToolStripMenuItem
            // 
            this.volumeChangeToolStripMenuItem.Name = "volumeChangeToolStripMenuItem";
            this.volumeChangeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.volumeChangeToolStripMenuItem.Text = "VolumeChange";
            this.volumeChangeToolStripMenuItem.Click += new System.EventHandler(this.volumeChangeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(32, 19);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "AppTimer";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Lucida Console", 11F);
            this.clear_button.Location = new System.Drawing.Point(313, 94);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 23);
            this.clear_button.TabIndex = 4;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Calibri", 13F);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(376, 76);
            this.checkedListBox1.TabIndex = 6;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // hours_label
            // 
            this.hours_label.AutoSize = true;
            this.hours_label.Font = new System.Drawing.Font("Lucida Console", 32F, System.Drawing.FontStyle.Bold);
            this.hours_label.Location = new System.Drawing.Point(130, 172);
            this.hours_label.Name = "hours_label";
            this.hours_label.Size = new System.Drawing.Size(46, 43);
            this.hours_label.TabIndex = 8;
            this.hours_label.Text = "0";
            this.hours_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(138, 146);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(23, 23);
            this.add_button.TabIndex = 9;
            this.add_button.Text = "+";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // decrease_button
            // 
            this.decrease_button.Location = new System.Drawing.Point(138, 218);
            this.decrease_button.Name = "decrease_button";
            this.decrease_button.Size = new System.Drawing.Size(23, 23);
            this.decrease_button.TabIndex = 10;
            this.decrease_button.Text = "-";
            this.decrease_button.UseVisualStyleBackColor = true;
            this.decrease_button.Click += new System.EventHandler(this.decrease_button_Click);
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.YellowGreen;
            this.start_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.start_button.Location = new System.Drawing.Point(284, 230);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(108, 43);
            this.start_button.TabIndex = 11;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(12, 146);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(128, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.ImageLabel.Location = new System.Drawing.Point(28, 184);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(79, 42);
            this.ImageLabel.TabIndex = 13;
            this.ImageLabel.Text = "Drag any \r\n112 x 112\r\nimage";
            this.ImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // songname
            // 
            this.songname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.songname.Location = new System.Drawing.Point(12, 121);
            this.songname.Name = "songname";
            this.songname.Size = new System.Drawing.Size(376, 22);
            this.songname.TabIndex = 14;
            this.songname.Text = "No song selected";
            // 
            // mediabutton
            // 
            this.mediabutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mediabutton.Location = new System.Drawing.Point(170, 230);
            this.mediabutton.Name = "mediabutton";
            this.mediabutton.Size = new System.Drawing.Size(108, 43);
            this.mediabutton.TabIndex = 15;
            this.mediabutton.Text = "Browse music";
            this.mediabutton.UseVisualStyleBackColor = true;
            this.mediabutton.Click += new System.EventHandler(this.mediabutton_Click);
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 278);
            this.Controls.Add(this.mediabutton);
            this.Controls.Add(this.songname);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.decrease_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.hours_label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.clear_button);
            this.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Work Tracker";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.AppTimer_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label hours_label;
        private System.Windows.Forms.Button decrease_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.ToolStripMenuItem keepOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lockPositionToolStripMenuItem;
        private System.Windows.Forms.Label ImageLabel;
        private System.Windows.Forms.ToolStripMenuItem topleftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toprightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomleftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomrightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unlockToolStripMenuItem;
        private System.Windows.Forms.Label songname;
        private System.Windows.Forms.Button mediabutton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem volumeChangeToolStripMenuItem;
    }
}

