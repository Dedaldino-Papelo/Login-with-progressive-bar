using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Designing
{
    public partial class Form1 : Form
    {
        int StartPos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StartPos = StartPos + 1;
            ProgressiveBar.Value = StartPos;
            lblPercentagem.Text = StartPos + "%";
            if (ProgressiveBar.Value == 100)
            {
                ProgressiveBar.Value = 0;
                timer1.Stop();
                Login L = new Login();
                L.Show();
                this.Hide();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void lblPercentagem_Click(object sender, EventArgs e)
        {

        }

    }
}
