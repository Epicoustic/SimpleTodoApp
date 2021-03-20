using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using LiteDB;
using System.Linq;
using System.Media;
using WMPLib;

namespace AppTimer
{
    public partial class Form1 : Form
    {
        private int hours = 4;
        private TimeSpan countDownTime;
        private List<string> localTodoArr;
        static WMPLib.WindowsMediaPlayer Player;
        private string songPath;
        private string databasePath;
        // Create your POCO class entity
        public class Settings
        {
            public int Id { get; set; }
            public string[] todoItems { get; set; }
            public string imageURL { get; set; }
            public string musicPath { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            Player = new WMPLib.WindowsMediaPlayer();
            localTodoArr = new List<String>();
            initDatabase();
        }


        private void initDatabase()
        {        
            // Open database (or create if doesn't exist)
            try
            {
                databasePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\MyData.db";
                using (var db = new LiteDatabase(@databasePath))
                {
                    // Get a collection (or create, if doesn't exist)
                    var col = db.GetCollection<Settings>("settings");
                    var settingsObjects = col.FindAll();
                    var result = col.Find(x => x.Id == 1).FirstOrDefault();

                    if (result == null)
                    {
                        col.Insert(new Settings
                        {
                            todoItems = new string[] { "" },
                            imageURL = "",
                            musicPath = "",
                        });
                    }

                    // Get a collection (or create, if doesn't exist)
                    var settingsObject = col.FindAll().First();

                    // Update image
                    if (settingsObject.imageURL != null)
                    {
                        ImageLabel.Visible = false;
                        loadImage(settingsObject.imageURL);
                    }
                    // Update todolist items
                    if (settingsObject.todoItems.Count() != 0)
                    {
                        loadTodoItems(settingsObject.todoItems);
                    }
                    if (settingsObject.musicPath != null)
                    {
                        songPath = settingsObject.musicPath;
                        string[] fileNames = songPath.Split('\\');
                        songname.Text = fileNames.Last();
                    }
                }
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("Couldn't establish connection");
            }
        }

        private void AppTimer_Load(object sender, EventArgs e)
        {
            hours_label.Text = hours.ToString();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Settings_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.BringToFront();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.WindowState = FormWindowState.Minimized;
        }


        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (hours != 9)
            {
                hours++;
                hours_label.Text = hours.ToString();
            }
        }

        private void decrease_button_Click(object sender, EventArgs e)
        {
            if (hours != 1)
            {
                hours--;
                hours_label.Text = hours.ToString();
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            if (start_button.Text == "Start")
            {
                startTimer();
            }
            else if (start_button.Text == "Stop") {
                stopTimer();
            }
        }

        private void stopPlayingMusic()
        {
            Player.controls.stop();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateTimerLabel();
        }

        private void startTimer() 
        {
            hours_label.ForeColor = System.Drawing.Color.Maroon;
            start_button.BackColor = System.Drawing.Color.Tomato;
            timer1.Enabled = true;
            countDownTime = new TimeSpan(hours, 0, 0);
            start_button.Text = "Stop";
            add_button.Visible = false;
            decrease_button.Visible = false;
            playMusicFile(songPath);
            mediabutton.Visible = false;
        }

        private void stopTimer()
        {
            hours_label.ForeColor = System.Drawing.Color.Black;
            timer1.Enabled = false;
            start_button.BackColor = System.Drawing.Color.YellowGreen;
            start_button.Text = "Start";
            add_button.Visible = true;
            decrease_button.Visible = true;
            hours_label.Text = hours.ToString();
            stopPlayingMusic();
            mediabutton.Visible = true;
        }

        private void updateTimerLabel()
        {
            countDownTime -= TimeSpan.FromSeconds(1);
            hours_label.Text = countDownTime.ToString(@"hh\:mm\:ss");
            if (countDownTime == TimeSpan.Zero) {
                trayIcon.ShowBalloonTip(1000, "Done", "Your work session is over!", ToolTipIcon.Info);
                stopTimer();
            }
        }

        private bool timerIsDone(TimeSpan t){
            return countDownTime - t == TimeSpan.Zero;
        }

        private void keepOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (this.TopMost == false)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void hideControls()
        {
            if (this.FindForm().ControlBox == true)
            {
                this.FindForm().ControlBox = false;
                this.FindForm().Text = "";
                trayIcon.Visible = true;
            }
        }


        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            System.Drawing.Image backgroundImage = System.Drawing.Image.FromFile(fileList[0]);
            if (checkImageDimensions(backgroundImage)) {
                // Open database (or create if doesn't exist)
                ImageLabel.Visible = false;
                using (var db = new LiteDatabase(@databasePath))
                {
                    // Get a collection (or create, if doesn't exist)
                    var col = db.GetCollection<Settings>("settings");
                    var setting = col.FindAll().First();
                    setting.imageURL = fileList[0];
                    col.Update(setting);
                    loadImage(fileList[0]);
                }
            }
            else
            {
                MessageBox.Show("Invalid image dimensions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void loadImage(string path)
        {
            if(path != null)
            {
                try
                {
                    this.pictureBox1.Image = System.Drawing.Image.FromFile(path);
                }
                catch
                {
                    System.Diagnostics.Debug.WriteLine("Could not fetch image");
                    ImageLabel.Visible = true;
                }
            }
        }

        private void loadTodoItems(string[] items)
        {
            if (items[0] != null)
            {
                foreach (string item in items)
                {
                    checkedListBox1.Items.Add(item);
                }
            }
        }

        private bool checkImageDimensions(System.Drawing.Image i)
        {
            return i.Size.Width <= 112 && i.Size.Height <= 112;
        }

        private void contextMenuStrip1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.ClearSelected();
        }

        private void topleftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var screen = Screen.FromControl(this);
            hideControls();
            int y = screen.WorkingArea.Top;
            int x = screen.WorkingArea.Left;
            this.Location = new Point(x, y);
        }

        private bool checkForEmptyString(string text)
        {
            return text.Length == 0 && text == "";
        }

        private void toprightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var screen = Screen.FromControl(this);
            hideControls();
            int y = screen.WorkingArea.Top;
            int x = screen.WorkingArea.Right - this.Width;
            this.Location = new Point(x, y);
        }

        private void bottomleftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var screen = Screen.FromControl(this);
            hideControls();
            int y = screen.WorkingArea.Bottom - this.Height;
            int x = screen.WorkingArea.Left;
            this.Location = new Point(x, y);
        }

        private void bottomrightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var screen = Screen.FromControl(this);
            hideControls();
            int y = screen.WorkingArea.Bottom - this.Height;
            int x = screen.WorkingArea.Right - this.Width;
            this.Location = new Point(x, y);
        }

        private void unlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FindForm().ControlBox = true;
            this.FindForm().Text = "Work Tracker";
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && checkedListBox1.Items.Count < 3)
            {
                e.Handled = true;
                if (checkForEmptyString(textBox1.Text)) 
                    return;

                using (var db = new LiteDatabase(@databasePath))
                {
                    // Get a collection (or create, if doesn't exist)
                    var col = db.GetCollection<Settings>("settings");
                    var settings = col.FindAll().First();
                    
                    if(settings.todoItems.Count() < 3)
                    {
                        localTodoArr.Add(textBox1.Text);
                        checkedListBox1.Items.Add(textBox1.Text);
                        settings.todoItems = localTodoArr.ToArray();
                        col.Update(settings);
                        textBox1.Clear();
                    }
                }
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            using (var db = new LiteDatabase(@databasePath))
            {
                checkedListBox1.Items.Clear();
                // Get a collection (or create, if doesn't exist)
                var col = db.GetCollection<Settings>("settings");
                var settings = col.FindAll().First();
                localTodoArr.Clear();
                settings.todoItems = localTodoArr.ToArray();
                col.Update(settings);
            }
        }

        private void playMusicFile(String url)
        {
            Player.PlayStateChange +=
                new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
            Player.MediaError +=
                new WMPLib._WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);
            Player.URL = url;
            Player.settings.setMode("loop", true);
            Player.controls.play();
            Player.settings.volume = 20;
        }

        private void Player_PlayStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
            {

            }
        }

        private void Player_MediaError(object pMediaObject)
        {
            MessageBox.Show("Cannot play media file.");
            this.Close();
        }

        private void mediabutton_Click(object sender, EventArgs e)
        {
            //Find file through file system first
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                if (validFile(ofd.SafeFileName))
                {
                    using (var db = new LiteDatabase(@databasePath))
                    {
                        var col = db.GetCollection<Settings>("settings");
                        var setting = col.FindAll().First();
                        songname.Text = ofd.SafeFileName;
                        setting.musicPath = ofd.FileName;
                        songPath = setting.musicPath;
                        col.Update(setting);
                    }
                }
                else
                {
                    MessageBox.Show("Only .mp3, .wav, .m4a, .flac, .m3u audio file formats supported.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool validFile(string musicFileName)
        {
            return musicFileName.Contains(".mp3") || musicFileName.Contains(".wav") || musicFileName.Contains(".m4a") 
                || musicFileName.Contains(".flac") || musicFileName.Contains(".m3u");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Player.settings.volume = 100;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Player.settings.volume = 75;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Player.settings.volume = 50;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Player.settings.volume = 25;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Player.settings.volume = 10;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Player.settings.volume = 5;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Player.settings.volume = 2;
        }
    }
}
