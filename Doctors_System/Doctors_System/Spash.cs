using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctors_System
{
    public partial class Spash : Form
    {
        
        public Spash()
        {

            InitializeComponent();
        }

        int g = 65;
        int r = 244;
        int b = 65;
        private void Spash_Load(object sender, EventArgs e)
          
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (b <= 244)
            {
                r -= 1;
                this.BackColor = Color.FromArgb(r, g, b);

                if (r<=65)
                {
                    timerR.Stop();
                    timerG.Start();
                }

            }

            if (b<=65)
            {
                r += 1;
                this.BackColor = Color.FromArgb(r, g, b);
                if (r>=244)
                {
                    timerR.Stop();
                    timerG.Start();
                }

            }
        }

        private void timerB_Tick(object sender, EventArgs e)
        {
            if (g<=65)
            {
                b += 1;
                this.BackColor = Color.FromArgb(r, g, b);
                if (b>=244)
                {
                    timerB.Stop();
                    timerR.Start();
                }
            }

            if (g>=244)
            {
                b -= 1;
                this.BackColor = Color.FromArgb(r, g, b);
                if (b<=64)
                {
                    timerB.Stop();
                    timerR.Start();

                }
            }
        }

        private void timerG_Tick(object sender, EventArgs e)
        {
            if (r<=65)
            {
                g += 1;
                this.BackColor = Color.FromArgb(r, g, b);
                if (g>=244)
                {
                    timerG.Stop();
                    timerB.Start();
                }
            }

            if (r>=244)
            {
                g -= 1;
                this.BackColor = Color.FromArgb(r, g, b);
                if (g<=65)
                {
                    timerG.Stop();
                    timerB.Start();
                }
            }
        }
    }
}
