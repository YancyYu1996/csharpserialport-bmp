namespace Upper_LCD_STM32
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SendID = new System.Windows.Forms.TextBox();
            this.ReciveID = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.默认路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ReseveStr = new System.Windows.Forms.RadioButton();
            this.ReseveHex = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SendHex = new System.Windows.Forms.RadioButton();
            this.SendStr = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.Read_Mold = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RecieveArea = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SendArea = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.usbConnect3 = new MyDll.USBConnect();
            this.viewFile3 = new MyDll.ViewFile();
            this.viewFile1 = new MyDll.ViewFile();
            this.usbConnect1 = new MyDll.USBConnect();
            this.usbConnect2 = new MyDll.USBConnect();
            this.viewFile2 = new MyDll.ViewFile();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(743, 6);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 25);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // SendID
            // 
            this.SendID.Location = new System.Drawing.Point(511, 52);
            this.SendID.Margin = new System.Windows.Forms.Padding(4);
            this.SendID.Name = "SendID";
            this.SendID.Size = new System.Drawing.Size(215, 25);
            this.SendID.TabIndex = 10;
            // 
            // ReciveID
            // 
            this.ReciveID.Location = new System.Drawing.Point(511, 86);
            this.ReciveID.Margin = new System.Windows.Forms.Padding(4);
            this.ReciveID.Name = "ReciveID";
            this.ReciveID.Size = new System.Drawing.Size(215, 25);
            this.ReciveID.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.设置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1021, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存ToolStripMenuItem,
            this.保存为ToolStripMenuItem});
            this.新建ToolStripMenuItem.Image = global::Upper_LCD.Properties.Resources._21;
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.新建ToolStripMenuItem.Text = "文件";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Image = global::Upper_LCD.Properties.Resources._2;
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.保存ToolStripMenuItem.Text = "保存";
            // 
            // 保存为ToolStripMenuItem
            // 
            this.保存为ToolStripMenuItem.Image = global::Upper_LCD.Properties.Resources._3;
            this.保存为ToolStripMenuItem.Name = "保存为ToolStripMenuItem";
            this.保存为ToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.保存为ToolStripMenuItem.Text = "保存为..";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.默认路径ToolStripMenuItem});
            this.设置ToolStripMenuItem.Image = global::Upper_LCD.Properties.Resources._360截图18430701415560;
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 默认路径ToolStripMenuItem
            // 
            this.默认路径ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("默认路径ToolStripMenuItem.Image")));
            this.默认路径ToolStripMenuItem.Name = "默认路径ToolStripMenuItem";
            this.默认路径ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.默认路径ToolStripMenuItem.Text = "默认路径";
            this.默认路径ToolStripMenuItem.Click += new System.EventHandler(this.默认路径ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "发送数据:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "接收数据:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 15;
            // 
            // ReseveStr
            // 
            this.ReseveStr.AutoSize = true;
            this.ReseveStr.Location = new System.Drawing.Point(8, 20);
            this.ReseveStr.Margin = new System.Windows.Forms.Padding(4);
            this.ReseveStr.Name = "ReseveStr";
            this.ReseveStr.Size = new System.Drawing.Size(73, 19);
            this.ReseveStr.TabIndex = 16;
            this.ReseveStr.TabStop = true;
            this.ReseveStr.Text = "字符串";
            this.ReseveStr.UseVisualStyleBackColor = true;
            // 
            // ReseveHex
            // 
            this.ReseveHex.AutoSize = true;
            this.ReseveHex.Location = new System.Drawing.Point(89, 20);
            this.ReseveHex.Margin = new System.Windows.Forms.Padding(4);
            this.ReseveHex.Name = "ReseveHex";
            this.ReseveHex.Size = new System.Drawing.Size(88, 19);
            this.ReseveHex.TabIndex = 17;
            this.ReseveHex.TabStop = true;
            this.ReseveHex.Text = "十六进制";
            this.ReseveHex.UseVisualStyleBackColor = true;
            this.ReseveHex.CheckedChanged += new System.EventHandler(this.ReseveHex_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ReseveHex);
            this.groupBox3.Controls.Add(this.ReseveStr);
            this.groupBox3.Location = new System.Drawing.Point(16, 639);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(186, 47);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "接收数据格式";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SendHex);
            this.groupBox4.Controls.Add(this.SendStr);
            this.groupBox4.Location = new System.Drawing.Point(16, 685);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(186, 46);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "发送数据格式";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // SendHex
            // 
            this.SendHex.AutoSize = true;
            this.SendHex.Location = new System.Drawing.Point(89, 21);
            this.SendHex.Margin = new System.Windows.Forms.Padding(4);
            this.SendHex.Name = "SendHex";
            this.SendHex.Size = new System.Drawing.Size(88, 19);
            this.SendHex.TabIndex = 17;
            this.SendHex.TabStop = true;
            this.SendHex.Text = "十六进制";
            this.SendHex.UseVisualStyleBackColor = true;
            // 
            // SendStr
            // 
            this.SendStr.AutoSize = true;
            this.SendStr.Location = new System.Drawing.Point(8, 19);
            this.SendStr.Margin = new System.Windows.Forms.Padding(4);
            this.SendStr.Name = "SendStr";
            this.SendStr.Size = new System.Drawing.Size(73, 19);
            this.SendStr.TabIndex = 16;
            this.SendStr.TabStop = true;
            this.SendStr.Text = "字符串";
            this.SendStr.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 649);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 18;
            this.button2.Text = "发送";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SendBut_Click_1);
            // 
            // Read_Mold
            // 
            this.Read_Mold.AutoSize = true;
            this.Read_Mold.Location = new System.Drawing.Point(656, 16);
            this.Read_Mold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Read_Mold.Name = "Read_Mold";
            this.Read_Mold.Size = new System.Drawing.Size(0, 15);
            this.Read_Mold.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(602, 617);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 29);
            this.button3.TabIndex = 13;
            this.button3.Text = "清空";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "请选择图片：";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 758);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1021, 22);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(13, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "(可直接在设置中设置默认路径)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(346, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "读ID";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(324, 64);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 52);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.RecieveArea);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(649, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "接收数据区";
            // 
            // RecieveArea
            // 
            this.RecieveArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RecieveArea.Location = new System.Drawing.Point(-2, -4);
            this.RecieveArea.Multiline = true;
            this.RecieveArea.Name = "RecieveArea";
            this.RecieveArea.Size = new System.Drawing.Size(649, 410);
            this.RecieveArea.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.SendArea);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(649, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "发送数据区";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // SendArea
            // 
            this.SendArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SendArea.Location = new System.Drawing.Point(-2, 0);
            this.SendArea.Multiline = true;
            this.SendArea.Name = "SendArea";
            this.SendArea.Size = new System.Drawing.Size(649, 410);
            this.SendArea.TabIndex = 0;
            this.SendArea.TextChanged += new System.EventHandler(this.SendArea_TextChanged_1);
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(324, 173);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(657, 437);
            this.tabControl1.TabIndex = 27;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.png");
            this.imageList1.Images.SetKeyName(1, "2.png");
            this.imageList1.Images.SetKeyName(2, "3.png");
            this.imageList1.Images.SetKeyName(3, "4.png");
            this.imageList1.Images.SetKeyName(4, "5.png");
            this.imageList1.Images.SetKeyName(5, "6.png");
            this.imageList1.Images.SetKeyName(6, "360截图18430701415560.png");
            // 
            // usbConnect3
            // 
            this.usbConnect3.Location = new System.Drawing.Point(13, 33);
            this.usbConnect3.Margin = new System.Windows.Forms.Padding(4);
            this.usbConnect3.Name = "usbConnect3";
            this.usbConnect3.Size = new System.Drawing.Size(279, 166);
            this.usbConnect3.TabIndex = 25;
            // 
            // viewFile3
            // 
            this.viewFile3.Location = new System.Drawing.Point(0, 223);
            this.viewFile3.Name = "viewFile3";
            this.viewFile3.Size = new System.Drawing.Size(311, 409);
            this.viewFile3.TabIndex = 26;
            this.viewFile3.Load += new System.EventHandler(this.viewFile3_Load);
            // 
            // viewFile1
            // 
            this.viewFile1.Location = new System.Drawing.Point(0, 211);
            this.viewFile1.Name = "viewFile1";
            this.viewFile1.Size = new System.Drawing.Size(289, 202);
            this.viewFile1.TabIndex = 23;
            this.viewFile1.Load += new System.EventHandler(this.viewFile1_Load);
            // 
            // usbConnect1
            // 
            this.usbConnect1.Location = new System.Drawing.Point(16, 35);
            this.usbConnect1.Margin = new System.Windows.Forms.Padding(5);
            this.usbConnect1.Name = "usbConnect1";
            this.usbConnect1.Size = new System.Drawing.Size(267, 168);
            this.usbConnect1.TabIndex = 21;
            // 
            // usbConnect2
            // 
            this.usbConnect2.Location = new System.Drawing.Point(31, 32);
            this.usbConnect2.Margin = new System.Windows.Forms.Padding(4);
            this.usbConnect2.Name = "usbConnect2";
            this.usbConnect2.Size = new System.Drawing.Size(280, 168);
            this.usbConnect2.TabIndex = 25;
            // 
            // viewFile2
            // 
            this.viewFile2.Location = new System.Drawing.Point(16, 226);
            this.viewFile2.Name = "viewFile2";
            this.viewFile2.Size = new System.Drawing.Size(299, 212);
            this.viewFile2.TabIndex = 26;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1021, 780);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.usbConnect3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Read_Mold);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReciveID);
            this.Controls.Add(this.SendID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.viewFile3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(800, 300);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LCD-TOOL";
            this.TransparencyKey = System.Drawing.SystemColors.AppWorkspace;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SendID;
        private System.Windows.Forms.TextBox ReciveID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 默认路径ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton ReseveStr;
        private System.Windows.Forms.RadioButton ReseveHex;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton SendHex;
        private System.Windows.Forms.RadioButton SendStr;
        private System.Windows.Forms.Button button2;
        private MyDll.USBConnect usbConnect1;
        private System.Windows.Forms.Label Read_Mold;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MyDll.ViewFile viewFile1;
        private System.Windows.Forms.Label label4;
        private MyDll.USBConnect usbConnect2;
        private MyDll.ViewFile viewFile2;
        private MyDll.USBConnect usbConnect3;
        private MyDll.ViewFile viewFile3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox RecieveArea;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox SendArea;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
    }
}

