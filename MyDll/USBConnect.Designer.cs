namespace MyDll
{
    partial class USBConnect
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BoundBox = new System.Windows.Forms.ComboBox();
            this.FindS = new System.Windows.Forms.Label();
            this.OpenBut = new System.Windows.Forms.Button();
            this.ComStause = new System.Windows.Forms.Label();
            this.USBConBox = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ComPort = new System.IO.Ports.SerialPort(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BoundBox);
            this.panel1.Controls.Add(this.FindS);
            this.panel1.Controls.Add(this.OpenBut);
            this.panel1.Controls.Add(this.ComStause);
            this.panel1.Controls.Add(this.USBConBox);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 160);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "波特率;";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "端口号:";
            // 
            // BoundBox
            // 
            this.BoundBox.FormattingEnabled = true;
            this.BoundBox.Location = new System.Drawing.Point(75, 105);
            this.BoundBox.Margin = new System.Windows.Forms.Padding(4);
            this.BoundBox.Name = "BoundBox";
            this.BoundBox.Size = new System.Drawing.Size(175, 23);
            this.BoundBox.TabIndex = 3;
            // 
            // FindS
            // 
            this.FindS.AutoSize = true;
            this.FindS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FindS.Location = new System.Drawing.Point(160, 16);
            this.FindS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FindS.Name = "FindS";
            this.FindS.Size = new System.Drawing.Size(0, 22);
            this.FindS.TabIndex = 2;
            // 
            // OpenBut
            // 
            this.OpenBut.Location = new System.Drawing.Point(111, 69);
            this.OpenBut.Margin = new System.Windows.Forms.Padding(4);
            this.OpenBut.Name = "OpenBut";
            this.OpenBut.Size = new System.Drawing.Size(100, 29);
            this.OpenBut.TabIndex = 1;
            this.OpenBut.Text = "打开串口";
            this.OpenBut.UseVisualStyleBackColor = true;
            this.OpenBut.Click += new System.EventHandler(this.OpenBut_Click);
            // 
            // ComStause
            // 
            this.ComStause.AutoSize = true;
            this.ComStause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComStause.Location = new System.Drawing.Point(43, 18);
            this.ComStause.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ComStause.Name = "ComStause";
            this.ComStause.Size = new System.Drawing.Size(0, 18);
            this.ComStause.TabIndex = 1;
            // 
            // USBConBox
            // 
            this.USBConBox.FormattingEnabled = true;
            this.USBConBox.Location = new System.Drawing.Point(75, 38);
            this.USBConBox.Margin = new System.Windows.Forms.Padding(4);
            this.USBConBox.Name = "USBConBox";
            this.USBConBox.Size = new System.Drawing.Size(175, 23);
            this.USBConBox.TabIndex = 0;
            this.USBConBox.SelectedIndexChanged += new System.EventHandler(this.USBConBox_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ComPort
            // 
            this.ComPort.BaudRate = 19200;
            this.ComPort.ReadBufferSize = 65536;
            this.ComPort.WriteBufferSize = 65536;
            // 
            // USBConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "USBConnect";
            this.Size = new System.Drawing.Size(280, 168);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        public System.IO.Ports.SerialPort ComPort;
        private System.Windows.Forms.ComboBox USBConBox;
        private System.Windows.Forms.Label ComStause;
        private System.Windows.Forms.Button OpenBut;
        private System.Windows.Forms.Label FindS;
        private System.Windows.Forms.ComboBox BoundBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
