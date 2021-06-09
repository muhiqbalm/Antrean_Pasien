using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AntreanPasien
{
    public partial class FormDataAntrean : Form
    {
        Antrean antrean = new Antrean();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;Pooling=False");
        private bool mousedown;
        private Point offset;
        private readonly DataModel dbo = Akses.Tabel();

        public FormDataAntrean()
        {
            InitializeComponent();
        }
        private void DisplayData()
        {
            try
            {
                var items = (from i in dbo.Antreans
                             select new { i.Nama }).ToList();
                dataGridView1.DataSource = items;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void resetTb()
        {
            textBox4.Text = "";
        }

        private void check()
        {
            if (antrean.Kosong())
            {
                buttonMaju.Enabled = false;
                buttonReset.Enabled = false;
            }
        }

        private void FormDataAntrean_Load(object sender, EventArgs e)
        {
            resetTb();
            DisplayData();
            check();
                        
        }

        private void buttonMaju_Click(object sender, EventArgs e)
        {
            using (con)
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete top (1) from Antrean";
                    cmd.ExecuteNonQuery();

                    con.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message + "\n" + ex.StackTrace); }
            }
            resetTb();
            DisplayData();
            check();
            MessageBox.Show("Nomor antrean paling depan sudah keluar\nAntrean bergerak maju!");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            try
            {
                antrean.Reset();

                resetTb();
                DisplayData();
                check();
                MessageBox.Show("Antrean telah direset!!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + "\n" + ex.StackTrace); }
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Akses.Tabel().Antreans.Where(y => y.Nama.Contains(textBox4.Text)).ToList();
        }
    }
}
