using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (0.5 * button1.Width > e.X)
            { button1.Left++; }
            else
            { button1.Left--; }

            if (0.5 * button1.Height > e.Y)
            { button1.Top++; }
            else
            { button1.Top--; }

            //超過左邊界，從右邊出現
            if (button1.Left < -0.5*button1.Width)
            { button1.Left = this.Width - button1.Width - 20; }

            //超過右邊界，從左邊出現
            if (button1.Left > this.Width - button1.Width)
            { button1.Left = 10; }

            //超過上邊界，從下方出現
            if (button1.Top < -button1.Height + 10)
            { button1.Top = this.Height - button1.Height - 50; }

            //超過下邊界，從上方出現
            if (button1.Top > this.Height - 50)
            { button1.Top = 10; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
