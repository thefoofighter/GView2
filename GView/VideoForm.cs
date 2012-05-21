/***********************************
 * GView
 * Ver: 2.0a
 * Developed by Cathal McNally
 * mcnallycathal@yahoo.ie
 * 14/05/2012
 * 
 * ********************************* 
 * VideoForm()
 * Displays the Video Player Form 
 * for playing Game Trailers
 * currently only *.mp4
 * TODO: Add other formats!
 *
 * *********************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GView
{
    public partial class VideoForm : Form
    {
        public string path;
        public VideoForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;   
        }

        private void axVLCPlugin21_Enter(object sender, EventArgs e)
        {
            // If a video is avaiable hide the hint labels. 
            if (path != "")
            {
                label3.Hide();
                label4.Hide();
            }
            // Create a new playlist and add the video file
            axVLCPlugin21.playlist.add("file:///"+path, null, null);  
            // Play whatever is currently on the playlist.
            axVLCPlugin21.playlist.play();              
        }

        private void vidExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
