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
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            




        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
           

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            string cuenta, contra, correo = "ChayanneSuazo34@gmail.com";

            cuenta = "Chayannesuazo";
            contra = "1234";
            if (bunifuMetroTextbox3.Text == cuenta || bunifuMetroTextbox3.Text == correo && bunifuMetroTextbox4.Text == contra)
            {
                Form1 mp = new Form1();
                mp.Show();
                this.Hide();
            }
            if (bunifuMetroTextbox3.Text != cuenta || bunifuMetroTextbox3.Text != correo && bunifuMetroTextbox4.Text != contra)
            {
                MessageBox.Show("El usuario, Correo o contraseña son incorrectos");
            }
           if (bunifuMetroTextbox3.Text == "" || bunifuMetroTextbox3.Text == "" && bunifuMetroTextbox4.Text == "")


                    {


                MessageBox.Show("Debe rellenar las casillas anteriores");
            }

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
