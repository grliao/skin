using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Skin.Controls.About
{
    public partial class MediaPlayerControl : UserControl
    {
        public MediaPlayerControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (this.DesignMode)
            {
                var playList = axMediaPlayer.playlistCollection.newPlaylist("skin");

                var files = Directory.GetFiles(Path.Combine(Application.StartupPath, "video")).Where(p => p.EndsWith(".avi")
                || p.EndsWith("wmv") || p.EndsWith(".mpeg") || p.EndsWith(".mpg")).ToList();

                // 设置视频目录
                foreach (var eachFile in files)
                {
                    playList.appendItem(axMediaPlayer.newMedia(eachFile));
                }

                axMediaPlayer.currentPlaylist = playList;
            }
        }
        
        public void Play()
        {
            try
            {
                axMediaPlayer.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
            }
            
        }

        public void Stop()
        {
            try
            {
                axMediaPlayer.Ctlcontrols.stop();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
