
namespace AntreanPasien
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbDataAdmin = new System.Windows.Forms.PictureBox();
            this.pbDataPasien = new System.Windows.Forms.PictureBox();
            this.pbDataAntrean = new System.Windows.Forms.PictureBox();
            this.pbInfoApp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDataAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDataPasien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDataAntrean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfoApp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 34);
            this.panel1.TabIndex = 15;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(711, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(741, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(769, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbDataAdmin
            // 
            this.pbDataAdmin.BackColor = System.Drawing.Color.Transparent;
            this.pbDataAdmin.Location = new System.Drawing.Point(158, 169);
            this.pbDataAdmin.Name = "pbDataAdmin";
            this.pbDataAdmin.Size = new System.Drawing.Size(129, 69);
            this.pbDataAdmin.TabIndex = 16;
            this.pbDataAdmin.TabStop = false;
            this.pbDataAdmin.Click += new System.EventHandler(this.pbDataAdmin_Click);
            // 
            // pbDataPasien
            // 
            this.pbDataPasien.BackColor = System.Drawing.Color.Transparent;
            this.pbDataPasien.Location = new System.Drawing.Point(512, 169);
            this.pbDataPasien.Name = "pbDataPasien";
            this.pbDataPasien.Size = new System.Drawing.Size(129, 69);
            this.pbDataPasien.TabIndex = 17;
            this.pbDataPasien.TabStop = false;
            this.pbDataPasien.Click += new System.EventHandler(this.pbDataPasien_Click);
            // 
            // pbDataAntrean
            // 
            this.pbDataAntrean.BackColor = System.Drawing.Color.Transparent;
            this.pbDataAntrean.Location = new System.Drawing.Point(158, 298);
            this.pbDataAntrean.Name = "pbDataAntrean";
            this.pbDataAntrean.Size = new System.Drawing.Size(129, 69);
            this.pbDataAntrean.TabIndex = 18;
            this.pbDataAntrean.TabStop = false;
            this.pbDataAntrean.Click += new System.EventHandler(this.pbDataAntrean_Click);
            // 
            // pbInfoApp
            // 
            this.pbInfoApp.BackColor = System.Drawing.Color.Transparent;
            this.pbInfoApp.Location = new System.Drawing.Point(512, 298);
            this.pbInfoApp.Name = "pbInfoApp";
            this.pbInfoApp.Size = new System.Drawing.Size(129, 69);
            this.pbInfoApp.TabIndex = 19;
            this.pbInfoApp.TabStop = false;
            this.pbInfoApp.Click += new System.EventHandler(this.pbInfoApp_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbInfoApp);
            this.Controls.Add(this.pbDataAntrean);
            this.Controls.Add(this.pbDataPasien);
            this.Controls.Add(this.pbDataAdmin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDataAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDataPasien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDataAntrean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfoApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbDataAdmin;
        private System.Windows.Forms.PictureBox pbDataPasien;
        private System.Windows.Forms.PictureBox pbDataAntrean;
        private System.Windows.Forms.PictureBox pbInfoApp;
    }
}