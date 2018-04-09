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

        private void Father_Container(object FatherConainer)
        {
            /*El if es para saber si existe algun control en el panel principa y eliminar lo si es True */
            if(this.Container.Controls.Count>0)
            {
                this.Container.Controls.RemoveAt(0);
                Form Fc = FatherConainer as Form;
                Fc.TopLevel = false;
                Fc.Dock = DockStyle.Fill;
                this.Container.Controls.Add(Fc);
                this.Container.Tag = Fc;
                Fc.Show();
            }
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

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

           this.WindowState = FormWindowState.Minimized;
        }
    }
}
