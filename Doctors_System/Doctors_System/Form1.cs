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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void Logo_Click(object sender, EventArgs e)
        {
            if (panel1.Width==223)
            {
                panel1.Visible = false;
                //panel hidde
                panel1.Width = 60;
                Logo.Visible = false;
                panelanimation.ShowSync(panel1);
                logomenu.ShowSync(Logo);
                
            }
            else 
                    {
                
                panel1.Visible = false;
                panel1.Width = 223;
                Logo.Visible = true;
                panelanimation.ShowSync(panel1);

            }

        }
    }
}
