using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RoCar01
{
    public partial class Form1 : Form
    {
        //沒有接實體車(vRobots) 有：iRobot
        vRobots.RoCar01 RC = new vRobots.RoCar01();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //控制車子向前
        private void button1_Click(object sender, EventArgs e)
        {
            RC.MoveC('F');
        }
        //控制車子向後
        private void button2_Click(object sender, EventArgs e)
        {
            RC.MoveC('B');
        }
        //控制車子向左
        private void button3_Click(object sender, EventArgs e)
        {
            RC.MoveC('L');
        }
        //控制車子向右
        private void button4_Click(object sender, EventArgs e)
        {
            RC.MoveC('R');
        }
        //控制車子停止
        private void button5_Click(object sender, EventArgs e)
        {
            RC.MoveC('X');
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //控制車子無限轉方圈
            while (1 == 1)
            {
                RC.MoveC('F');
                RC.WaitN(2000);
                RC.MoveC('R');
                RC.WaitN(400);
                RC.MoveC('F');
                RC.WaitN(2000);

                RC.MoveC('R');
                RC.WaitN(400);
                RC.MoveC('F');
                RC.WaitN(2000);

                RC.MoveC('R');
                RC.WaitN(550);
                RC.MoveC('F');
                RC.WaitN(2000);

                RC.MoveC('R');
                RC.WaitN(500);
                RC.MoveC('F');
                RC.WaitN(2000);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //跑馬燈目前無法運作
            for (int i = 0; i < 3; i++)
            {   //正
                RC.LEDsOut(1, 1);
                RC.WaitN(500);
                RC.LEDsOut(1, 2);
                RC.WaitN(500);
                RC.LEDsOut(1, 4);
                RC.WaitN(500);
                RC.LEDsOut(1, 8);
                RC.WaitN(500);
                RC.LEDsOut(1, 16);
                RC.WaitN(500);
                RC.LEDsOut(1, 32);
                RC.WaitN(500);
                RC.LEDsOut(1, 64);
                RC.WaitN(500);
                RC.LEDsOut(1, 128);
                RC.WaitN(500);
                //負
                RC.LEDsOut(1, 128);
                RC.WaitN(500);
                RC.LEDsOut(1, 64);
                RC.WaitN(500);
                RC.LEDsOut(1, 32);
                RC.WaitN(500);
                RC.LEDsOut(1, 16);
                RC.WaitN(500);
                RC.LEDsOut(1, 8);
                RC.WaitN(500);
                RC.LEDsOut(1, 4);
                RC.WaitN(500);
                RC.LEDsOut(1, 2);
                RC.WaitN(500);
                RC.LEDsOut(1, 1);
                RC.WaitN(500);
            }
            
            /*
            for(int i=0; i<3; i++)
            {
                for(int j =0; j<=7;j++)
                {
                    RC.LEDsOut(1, (byte)Math.Pow(2, j));
                    RC.WaitN(500);
                    //y = (Math.Pow(2, x));
                    //RC.LEDsOut(1, Convert.ToByte(y));
                    //x++;
                }
                for (int j = 7; j >= 0; j--)
                {
                    RC.LEDsOut(1, (byte)Math.Pow(2, j));
                    RC.WaitN(500);
                    //y = Convert.ToInt32(Math.Pow(2, x));
                    //RC.LEDsOut(1, Convert.ToByte(y));
                    // x--;
                }

            } 
            */
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int MaxLen = 128;
            //宣告三維陣列A(高低音、音符、音長)
            int[,] A = {{0,5,4},{0,6,1},{1,1,3},{0,5,4},{0,6,1},{1,1,3},{1,1,4},{1,2,2},{1,1,1},{1,3,1},{1,3,4},{0,0,4},{0,6,4},{1,1,2},
                       {1,2,2},{0,5,4},{1,4,2},{1,3,2},{1,2,1},{0,6,3},{1,1,1},{1,2,3},{1,2,8},{0,5,4},{0,6,1},{1,1,3},{0,5,4},{0,6,1},
                       {1,1,3},{1,1,1},{1,1,3},{1,2,2},{1,1,1},{1,3,1},{1,3,4},{0,0,4},{0,6,4},{1,1,1},{1,2,3},{0,5,4},{1,4,3},{1,3,1},
                       {1,2,1},{0,6,3},{0,7,2},{1,1,2},{1,1,8},

                       {0,0,2},{1,3,2},{1,5,2},{1,3,2},{1,5,6},{1,3,2},{1,5,4},{1,6,2},{1,5,2},{1,5,2},{1,1,2},{1,2,1},{1,3,3},{1,3,8},
                       {0,0,2},{1,2,2},{1,2,2},{1,3,2},{1,5,1},{1,5,3},{1,3,2},{1,3,2},{1,2,8},{0,0,2},{1,3,2},{1,5,2},{1,3,2},{1,5,6},
                       {1,3,2},{1,3,4},{1,6,2},{1,5,2},{1,5,2},{1,1,2},{1,2,3},{1,3,1},{1,3,8},{1,1,4},{1,2,1},{1,3,3},{1,1,8},{1,1,4},
                       {1,2,1},{1,3,3},{1,3,8},{1,1,4},{1,2,1},{1,3,3},{0,5,2},{0,5,2},{1,4,2},{1,3,2},{1,2,1},{0,6,3},{0,7,2},{1,1,2},
                       {1,1,8},

                       {1,1,16},{1,1,1},{1,1,3},{1,2,1},{1,3,3},{1,1,8},{1,1,1},{1,1,3},
                       {1,2,1},{1,3,3},{1,3,8},{1,1,4},{1,2,2},{1,3,2},{0,5,2},{0,5,2},{1,4,2},{1,3,2},{1,2,1},{0,6,3},{0,7,2},{1,1,2},
                       {1,1,8},{1,1,16} };
            for (int i = 0; i < MaxLen; i++)
            {
                if (A[i, 1] > 0) { A[i, 0] = A[i, 0] + 1; }
                RC.LEDsOut(1, (byte)Math.Pow(2, A[i, 0]));
                RC.MusicOut(A[i,0] * 100+A[i,1] * 10, 2 * A[i,2]);
                //每發一個音停頓一下
                RC.WaitN(1);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //測量溫度 (如果為實體車子則監測環境溫度)
            //以二進制控制燈亮，(1 or 2(控制燈為第一組或第二組),溫度轉byte)
            RC.LEDsOut(1, (byte)RC.TempIn());
        }
    }
}
