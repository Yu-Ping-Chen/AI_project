
namespace PictureBox
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(84, 79);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 282);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1-1.png");
            this.imageList1.Images.SetKeyName(1, "1-2.png");
            this.imageList1.Images.SetKeyName(2, "1-3.png");
            this.imageList1.Images.SetKeyName(3, "1-4.png");
            this.imageList1.Images.SetKeyName(4, "1-5.png");
            this.imageList1.Images.SetKeyName(5, "1-6.png");
            this.imageList1.Images.SetKeyName(6, "1-7.png");
            this.imageList1.Images.SetKeyName(7, "1-8.png");
            this.imageList1.Images.SetKeyName(8, "2-1.png");
            this.imageList1.Images.SetKeyName(9, "2-2.png");
            this.imageList1.Images.SetKeyName(10, "2-3.png");
            this.imageList1.Images.SetKeyName(11, "2-4.png");
            this.imageList1.Images.SetKeyName(12, "2-5.png");
            this.imageList1.Images.SetKeyName(13, "2-6.png");
            this.imageList1.Images.SetKeyName(14, "2-7.png");
            this.imageList1.Images.SetKeyName(15, "2-8.png");
            this.imageList1.Images.SetKeyName(16, "3-1.png");
            this.imageList1.Images.SetKeyName(17, "3-2.png");
            this.imageList1.Images.SetKeyName(18, "3-3.png");
            this.imageList1.Images.SetKeyName(19, "3-4.png");
            this.imageList1.Images.SetKeyName(20, "3-5.png");
            this.imageList1.Images.SetKeyName(21, "3-6.png");
            this.imageList1.Images.SetKeyName(22, "3-7.png");
            this.imageList1.Images.SetKeyName(23, "3-8.png");
            this.imageList1.Images.SetKeyName(24, "4-1.png");
            this.imageList1.Images.SetKeyName(25, "4-2.png");
            this.imageList1.Images.SetKeyName(26, "4-3.png");
            this.imageList1.Images.SetKeyName(27, "4-4.png");
            this.imageList1.Images.SetKeyName(28, "4-5.png");
            this.imageList1.Images.SetKeyName(29, "4-6.png");
            this.imageList1.Images.SetKeyName(30, "4-7.png");
            this.imageList1.Images.SetKeyName(31, "4-8.png");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
    }
}

