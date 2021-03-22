using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTimer
{
    public partial class VolumeControl : Form
    {
        static WMPLib.WindowsMediaPlayer mediaPlayer;
        public VolumeControl(WMPLib.WindowsMediaPlayer p)
        {
            InitializeComponent();
            VolumeControl.mediaPlayer = p;
            this.Width = 69;
            this.Visible = false;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (VolumeControl.mediaPlayer != null && volumeTrackBar != null)
                VolumeControl.mediaPlayer.settings.volume = volumeTrackBar.Value * 5;
        }

        private void volumeTrackBar_MouseLeave(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
