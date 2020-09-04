using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elmagd
{
    public partial class Splach_screen : Form
    {
        int move, x;
        public Splach_screen()
        {
            InitializeComponent();
        }

        private void Splach_screen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x == 30)
            {
                timer1.Enabled = false;
                new Main_Login().Show();
                this.Hide();
                timer1.Stop();
            }
            else
            {
                panelSlide.Width += 10;
                if (panelSlide.Width > 250)
                {
                    panelSlide.Width = 0;
                }
                if (panelSlide.Width < 0)
                {
                    move = 10;

                }
                x++;
            }
        }
    }
}
