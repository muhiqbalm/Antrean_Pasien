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
    public partial class FormMenu : Form
    {
        private bool mousedown;
        private Point offset;
        public FormMenu()
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
            FormLogin menu = new FormLogin();
            menu.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mousedown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown == true)
            {
                Point currentSceenPos = PointToScreen(e.Location);
                Location = new Point(currentSceenPos.X - offset.X, currentSceenPos.Y - offset.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void pbDataAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDataAdmin data = new FormDataAdmin();
            data.Show();
        }

        private void pbDataPasien_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDataPasien data = new FormDataPasien();
            data.Show();
        }

        private void pbDataAntrean_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDataAntrean data = new FormDataAntrean();
            data.Show();
        }

        private void pbInfoApp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInfoApp data = new FormInfoApp();
            data.Show();
        }
    }
}
