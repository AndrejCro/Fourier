using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dsktp
{
    public partial class soundtempt : Form
    {
             
        private void soundtempt_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer();
            string path = "Skirt_track.wav";
            string fullPath = System.IO.Path.GetFullPath(@"res\sound\" + path);
            myPlayer.SoundLocation = fullPath;
            myPlayer.PlayLooping();
        }

    }
}
