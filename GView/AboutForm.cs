/***********************************
 * GView
 * Ver: 2.0a
 * Developed by Cathal McNally
 * mcnallycathal@yahoo.ie
 * 14/05/2012
 * 
 * ********************************* 
 * AboutForm()
 * Displays the About Information 
 * for the Program
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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
