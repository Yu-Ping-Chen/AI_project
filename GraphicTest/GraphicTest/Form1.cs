using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicTest
{
    public partial class Form1 : Form
    {
        System.Drawing.Graphics graphics, graphics2;
        Pen skyBluePen = new Pen(Color.DeepSkyBlue, 8.0f);
        public Form1()
        {
            InitializeComponent();
            //初始化建立空白畫布，從Form1 取得Graphics就可以畫圖
            graphics = this.CreateGraphics();
            //初始化建立空白畫布，從panel1取得Graphics畫圖
            graphics2 = panel1.CreateGraphics();
            //建立一支天藍色的筆
            skyBluePen = new Pen(Color.DeepSkyBlue, 2.0f);
            graphics.DrawRectangle(skyBluePen, new Rectangle(20, 20, 150, 200));

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            graphics.DrawRectangle(skyBluePen, new Rectangle(20, 20, 150, 200));
            graphics2.DrawRectangle(skyBluePen, new Rectangle(20, 20, 150, 200));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //只顯示panel2，隱藏panel1
            panel2.Visible = true;
            panel1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //顯示panel2，並移動panel2的位置
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.Left = 10;
            panel2.Top = 10;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //graphics.DrawRectangle(skyBluePen, new Rectangle(20, 20, 150, 200));
            if (e.Button == MouseButtons.Left)
            {
                graphics.DrawRectangle(skyBluePen, e.X - 1, e.Y - 1, 2, 2);
                graphics2.DrawRectangle(skyBluePen, e.X - 1, e.Y - 1, 2, 2);
            }
        }
    }
}
