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
    public partial class FormLogin : Form
    {
        #region Atribut
        Admin admin = new Admin();
        private bool mousedown;
        private Point offset;
        Antrean antrean = new Antrean();
        #endregion

        #region Constructor
        public FormLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region Event
        public void resetTb()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            resetTb();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                try
                {
                    if (admin.CekBerdasarkan(textBox1.Text, textBox2.Text))
                    {
                        MessageBox.Show("Login Berhasil!");
                        antrean.Reset();
                        this.Hide();
                        FormMenu menu = new FormMenu();
                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username atau password salah!!");
                    }
                }
                catch (Exception err) { MessageBox.Show(err.Message); }
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Username dan password belum diisi");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Password belum diisi");
            }
            else
            {
                MessageBox.Show("Username belum diisi");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(this.WindowState != FormWindowState.Minimized)
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
        #endregion
    }
}
