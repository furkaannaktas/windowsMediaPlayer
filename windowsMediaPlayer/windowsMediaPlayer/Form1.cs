using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace windowsMediaPlayer
{
    public partial class Form1 : Form
    {
        private List<string> songs = new List<string>
        {
            "C:\\Users\\Msi\\source\\repos\\windowsMediaPlayer\\windowsMediaPlayer\\Videos\\Dedublüman x Aleyna Tilki - Sana Güvenmiyorum (Dedub Sessions with Aleyna Tilki).mp4",
            "C:\\Users\\Msi\\source\\repos\\windowsMediaPlayer\\windowsMediaPlayer\\Videos\\Derya Bedavacı - Seni Seven Kimdi.mp4",
            "C:\\Users\\Msi\\source\\repos\\windowsMediaPlayer\\windowsMediaPlayer\\Videos\\Kubilay Karça - Celladına Aşık.mp4",
            "C:\\Users\\Msi\\source\\repos\\windowsMediaPlayer\\windowsMediaPlayer\\Videos\\Semicenk - Gözlerinden Gözlerine.mp4",
            "C:\\Users\\Msi\\source\\repos\\windowsMediaPlayer\\windowsMediaPlayer\\Videos\\Aleyna Tilki - Sır.mp4",
            "C:\\Users\\Msi\\source\\repos\\windowsMediaPlayer\\windowsMediaPlayer\\Videos\\Murda ft. Hadise - Sen Dönene Kadar (prod. Spanker).mp4",
            "C:\\Users\\Msi\\source\\repos\\windowsMediaPlayer\\windowsMediaPlayer\\Videos\\Simge - Önümüz Yaz.mp4",
            "C:\\Users\\Msi\\source\\repos\\windowsMediaPlayer\\windowsMediaPlayer\\Videos\\Hadise - Feryat (Official Video).mp4",
            "C:\\Users\\Msi\\source\\repos\\windowsMediaPlayer\\windowsMediaPlayer\\Videos\\Derya Uluğ - Yakıyorlar.mp4",
            "C:\\Users\\Msi\\source\\repos\\windowsMediaPlayer\\windowsMediaPlayer\\Videos\\Ozan Doğulu feat. Simge - Ne Zamandır.mp4"
        };

        private int currentSongIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PlaySong(currentSongIndex);

            trackBarVolume.Minimum = 0;
            trackBarVolume.Maximum = 100;
            windowsMediaPlayer.settings.volume = 50;
            trackBarVolume.Value = 50;
        }
        private void PlaySong(int index)
        {
            windowsMediaPlayer.URL = songs[index];
            windowsMediaPlayer.Ctlcontrols.play();
        }

        private void windowsMediaPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (windowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                windowsMediaPlayer.Ctlcontrols.pause();
                btnPause.Text = "▶️";
            }
            else
            {
                windowsMediaPlayer.Ctlcontrols.play();
                btnPause.Text = "⏸";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            windowsMediaPlayer.Ctlcontrols.stop();
            btnStop.Text = "⏹️"; 
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            windowsMediaPlayer.settings.volume = trackBarVolume.Value;
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            if (windowsMediaPlayer.settings.volume > 0)
            {
                windowsMediaPlayer.settings.volume = 0;
                btnMute.Text = "🔇"; 
            }
            else
            {
                windowsMediaPlayer.settings.volume = 50;
                btnMute.Text = "🔊"; 
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentSongIndex = (currentSongIndex + 1) % songs.Count;
            PlaySong(currentSongIndex);
            btnNext.Text = "⏩"; 
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentSongIndex = (currentSongIndex - 1 + songs.Count) % songs.Count;
            PlaySong(currentSongIndex);
            btnPrevious.Text = "⏪"; 
        }
    }
}
