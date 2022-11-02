using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Form1 : Form     
    {
        public int Frame = 0;
        //前後左右的方向
        public int Direct = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Timer的enable要開成True才會啟動Timer
            Frame++;
            //將Frame控制在0~7 (八張圖)
            if (Frame > 7)
            {
                Frame = 0;
            }
            //imagelist已讀到記憶體(會比較快)，在記憶體中copy (0+0 -> 0+1-> 0+2)
            pictureBox1.Image = imageList1.Images[(Direct * 4) + Frame];

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //控制上下左右鍵
            //如果鍵盤按下N或是下
            if ((e.KeyCode == Keys.N) || (e.KeyCode == Keys.Down))
            {
                Direct = 0;
            }
            if ((e.KeyCode == Keys.U) || (e.KeyCode == Keys.Up))
            {
                Direct = 2;
            }
            if ((e.KeyCode == Keys.J) || (e.KeyCode == Keys.Right))
            {
                Direct = 4;
            }
            if ((e.KeyCode == Keys.H) || (e.KeyCode == Keys.Left))
            {
                Direct = 6;
            }
            else if (e.KeyCode == Keys.PageUp)
            {
                //強迫型態轉換，並控制變快
                timer1.Interval = (int)(timer1.Interval * 0.95);
            }
            else if (e.KeyCode == Keys.PageDown)
            {
                //強迫型態轉換，並控制變慢
                timer1.Interval = (int)(timer1.Interval * 1.05);
            }
        }
    }
}
