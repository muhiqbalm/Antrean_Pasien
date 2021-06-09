using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntreanPasien
{
    public partial class FormInfoApp : Form
    {
        private bool mousedown;
        private Point offset;
        public FormInfoApp()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu menu = new FormMenu();
            menu.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mousedown = true;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown == true)
            {
                Point currentSceenPos = PointToScreen(e.Location);
                Location = new Point(currentSceenPos.X - offset.X, currentSceenPos.Y - offset.Y);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }
    }
}
