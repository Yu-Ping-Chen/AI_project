using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace project_1102
{
    public partial class Form1 : Form
    {
        //宣告全域變數
        public System.Drawing.Graphics BaseGraphics;
        //宣告一隻筆並指定為紅色
        Pen RedPen = new Pen(Color.Red);

        public Form1()
        {
            //初始化
            InitializeComponent();
            //pictureBox1 取得 Graohics(從image去取得)，image一定要有東西不然就會是null->沒辦法畫圖
            BaseGraphics = Graphics.FromImage(pictureBox1.Image);
            //RedPen.Color= Color.顏色 RGBA(Alpha為透明度，預設為255(不透明))
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
