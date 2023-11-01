using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_1_714220070
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vbbutton_Click(object sender, EventArgs e)
        {

        }

        private void vbbutton_MouseMove(object sender, MouseEventArgs e)
        {
            vbbutton.Top -= e.Y;
            vbbutton.Left += e.X;
            if (vbbutton.Top < -16 || vbbutton.Top > 160)
                vbbutton.Top = 73;
            if (vbbutton.Left < -64 || vbbutton.Left > 384)
                vbbutton.Left = 160;
        }

        private void csbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct!");
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
