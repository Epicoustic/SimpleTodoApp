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
        private int volume;
        public VolumeControl(WMPLib.WindowsMediaPlayer p,int _volume)
        {
            InitializeComponent();
            VolumeControl.mediaPlayer = p;
            this.Width = 69;
            this.Visible = false;
            volume = _volume;
            volumeTrackBar.Value = volume / 5;
        }

        public int getVolume()
        {
            return volume;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (VolumeControl.mediaPlayer != null && volumeTrackBar != null)
            {
                volume = volumeTrackBar.Value * 5;
                VolumeControl.mediaPlayer.settings.volume = volume;
            }
                
        }

        private void volumeTrackBar_MouseLeave(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
