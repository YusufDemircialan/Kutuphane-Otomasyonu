using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane
{
    public partial class HakkımdaPanel : Form
    {
        public HakkımdaPanel()
        {
            InitializeComponent();
            timer1.Interval = 10;
            timer2 .Interval = 10;
            timer3 .Interval = 10;
            timer4 .Interval = 10;
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();

        }
        
        
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Programdan Çıkmak İstediğinize Emin Misiniz ?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Hide();
            AnaSayfa anasyf = new AnaSayfa();
            anasyf.Show();
        }

        private void HakkımdaPanel_Load(object sender, EventArgs e)
        {
            timer1.Enabled=true; 
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100005694169425");
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/yusuf_demircialan/");
        
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/yusuf_dmrcln");
        
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/yusuf-demircialan-5b5b72220/");
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            panel1.Location = new Point(panel1.Location.X, panel1.Location.Y-5);
            if (panel1.Location.Y == 85 && panel1.Location.X == 453)
            {

                panel1.Visible = false;
                panel1.Location = new Point(453, 355);
                panel1.Visible = true;

            }



        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            panel2.Location = new Point(panel2.Location.X+5, panel2.Location.Y);
            if (panel2.Location.Y == 85 && panel2.Location.X == 723)
            {

                panel2.Visible = false;
                panel2.Location = new Point(453, 85);
                panel2.Visible = true;

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            panel3.Location = new Point(panel3.Location.X, panel3.Location.Y+5);
            if (panel3.Location.Y == 355 && panel3.Location.X == 743)
            {

                panel3.Visible = false;
                panel3.Location = new Point(743, 85);
                panel3.Visible = true;

            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            panel4.Location = new Point(panel4.Location.X-5, panel4.Location.Y);
            if (panel4.Location.Y == 375 && panel4.Location.X == 453)
            {

                panel4.Visible = false;
                panel4.Location = new Point(723, 375);
                panel4.Visible = true;

            }
        }

        private void guna2ImageButton6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/drive/u/0/folders/1RfeN2-ta63cN-DlCD_CSoMS_oNsd7acX");
        
        }
    }
}
