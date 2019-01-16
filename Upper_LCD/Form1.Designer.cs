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
            this.默认发送格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SendMode = new System.Windows.Forms.ToolStripComboBox();
            this.默认接收格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecMode = new System.Windows.Forms.ToolStripComboBox();
            this.定时器默认时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TickTime = new System.Windows.Forms.ToolStripTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Read_Mold = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RecieveArea = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SendArea = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.directoryTree = new System.Windows.Forms.TreeView();
            this.directoryIcons = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FilePathBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PicL = new System.Windows.Forms.TextBox();
            this.PicW = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lenth = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.usbConnect3 = new MyDll.USBConnect();
            this.usbConnect1 = new MyDll.USBConnect();
            this.usbConnect2 = new MyDll.USBConnect();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(743, 6);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 25);
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
            this.默认路径ToolStripMenuItem,
            this.默认发送格式ToolStripMenuItem,
            this.默认接收格式ToolStripMenuItem,
            this.定时器默认时间ToolStripMenuItem});
            this.设置ToolStripMenuItem.Image = global::Upper_LCD.Properties.Resources._360截图18430701415560;
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 默认路径ToolStripMenuItem
            // 
            this.默认路径ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("默认路径ToolStripMenuItem.Image")));
            this.默认路径ToolStripMenuItem.Name = "默认路径ToolStripMenuItem";
            this.默认路径ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.默认路径ToolStripMenuItem.Text = "默认路径";
            this.默认路径ToolStripMenuItem.Click += new System.EventHandler(this.默认路径ToolStripMenuItem_Click);
            // 
            // 默认发送格式ToolStripMenuItem
            // 
            this.默认发送格式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SendMode});
            this.默认发送格式ToolStripMenuItem.Name = "默认发送格式ToolStripMenuItem";
            this.默认发送格式ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.默认发送格式ToolStripMenuItem.Text = "默认发送格式";
            this.默认发送格式ToolStripMenuItem.Click += new System.EventHandler(this.默认发送格式ToolStripMenuItem_Click);
            // 
            // SendMode
            // 
            this.SendMode.Name = "SendMode";
            this.SendMode.Size = new System.Drawing.Size(121, 28);
            // 
            // 默认接收格式ToolStripMenuItem
            // 
            this.默认接收格式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RecMode});
            this.默认接收格式ToolStripMenuItem.Name = "默认接收格式ToolStripMenuItem";
            this.默认接收格式ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.默认接收格式ToolStripMenuItem.Text = "默认接收格式";
            // 
            // RecMode
            // 
            this.RecMode.Name = "RecMode";
            this.RecMode.Size = new System.Drawing.Size(121, 28);
            // 
            // 定时器默认时间ToolStripMenuItem
            // 
            this.定时器默认时间ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TickTime});
            this.定时器默认时间ToolStripMenuItem.Name = "定时器默认时间ToolStripMenuItem";
            this.定时器默认时间ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.定时器默认时间ToolStripMenuItem.Text = "定时器默认时间";
            // 
            // TickTime
            // 
            this.TickTime.Name = "TickTime";
            this.TickTime.Size = new System.Drawing.Size(100, 27);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(788, 659);
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
            this.button3.Location = new System.Drawing.Point(612, 659);
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
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 650);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(1021, 25);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 20);
            this.toolStripStatusLabel1.Text = "发送图片->stm32";
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
            this.tabPage2.Size = new System.Drawing.Size(649, 440);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "接收数据区";
            // 
            // RecieveArea
            // 
            this.RecieveArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RecieveArea.Location = new System.Drawing.Point(-2, -4);
            this.RecieveArea.Multiline = true;
            this.RecieveArea.Name = "RecieveArea";
            this.RecieveArea.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RecieveArea.Size = new System.Drawing.Size(649, 442);
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
            this.tabPage1.Size = new System.Drawing.Size(649, 440);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "发送数据区";
            // 
            // SendArea
            // 
            this.SendArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SendArea.Location = new System.Drawing.Point(-2, 0);
            this.SendArea.Multiline = true;
            this.SendArea.Name = "SendArea";
            this.SendArea.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SendArea.Size = new System.Drawing.Size(649, 435);
            this.SendArea.TabIndex = 0;
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
            this.tabControl1.Size = new System.Drawing.Size(657, 469);
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
            // directoryTree
            // 
            this.directoryTree.ImageIndex = 0;
            this.directoryTree.ImageList = this.directoryIcons;
            this.directoryTree.Location = new System.Drawing.Point(17, 245);
            this.directoryTree.Name = "directoryTree";
            this.directoryTree.SelectedImageIndex = 0;
            this.directoryTree.Size = new System.Drawing.Size(273, 134);
            this.directoryTree.StateImageList = this.directoryIcons;
            this.directoryTree.TabIndex = 33;
            this.directoryTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.directoryTree_AfterSelect);
            // 
            // directoryIcons
            // 
            this.directoryIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("directoryIcons.ImageStream")));
            this.directoryIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.directoryIcons.Images.SetKeyName(0, "favicon-20181227073740130.ico");
            this.directoryIcons.Images.SetKeyName(1, "favicon-20181227073740630.ico");
            this.directoryIcons.Images.SetKeyName(2, "cf21ae978489c2bf6c984f91a543958.png");
            this.directoryIcons.Images.SetKeyName(3, "2399eecfc7d95fcbb2d8776ccd529ae.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 487);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            // 
            // FilePathBox
            // 
            this.FilePathBox.Location = new System.Drawing.Point(16, 415);
            this.FilePathBox.Multiline = true;
            this.FilePathBox.Name = "FilePathBox";
            this.FilePathBox.Size = new System.Drawing.Size(274, 60);
            this.FilePathBox.TabIndex = 35;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(105, 385);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 26);
            this.button4.TabIndex = 34;
            this.button4.Text = "刷新";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PicL
            // 
            this.PicL.Location = new System.Drawing.Point(547, 129);
            this.PicL.Margin = new System.Windows.Forms.Padding(4);
            this.PicL.Name = "PicL";
            this.PicL.Size = new System.Drawing.Size(65, 25);
            this.PicL.TabIndex = 37;
            // 
            // PicW
            // 
            this.PicW.Location = new System.Drawing.Point(751, 129);
            this.PicW.Margin = new System.Windows.Forms.Padding(4);
            this.PicW.Name = "PicW";
            this.PicW.Size = new System.Drawing.Size(60, 25);
            this.PicW.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "图片长度:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(669, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 40;
            this.label8.Text = "图片宽度:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(749, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 42;
            this.label9.Text = "发送数据长度:";
            // 
            // lenth
            // 
            this.lenth.Location = new System.Drawing.Point(861, 52);
            this.lenth.Margin = new System.Windows.Forms.Padding(4);
            this.lenth.Name = "lenth";
            this.lenth.Size = new System.Drawing.Size(65, 25);
            this.lenth.TabIndex = 41;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(190, 729);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 13);
            this.progressBar1.TabIndex = 43;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // usbConnect3
            // 
            this.usbConnect3.Location = new System.Drawing.Point(13, 33);
            this.usbConnect3.Margin = new System.Windows.Forms.Padding(4);
            this.usbConnect3.Name = "usbConnect3";
            this.usbConnect3.Size = new System.Drawing.Size(279, 166);
            this.usbConnect3.TabIndex = 25;
            // 
            // usbConnect1
            // 
            this.usbConnect1.Location = new System.Drawing.Point(0, 0);
            this.usbConnect1.Margin = new System.Windows.Forms.Padding(4);
            this.usbConnect1.Name = "usbConnect1";
            this.usbConnect1.Size = new System.Drawing.Size(280, 168);
            this.usbConnect1.TabIndex = 0;
            // 
            // usbConnect2
            // 
            this.usbConnect2.Location = new System.Drawing.Point(0, 0);
            this.usbConnect2.Margin = new System.Windows.Forms.Padding(4);
            this.usbConnect2.Name = "usbConnect2";
            this.usbConnect2.Size = new System.Drawing.Size(280, 168);
            this.usbConnect2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1021, 675);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lenth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PicW);
            this.Controls.Add(this.PicL);
            this.Controls.Add(this.directoryTree);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FilePathBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.usbConnect3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Read_Mold);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReciveID);
            this.Controls.Add(this.SendID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button button2;
        private MyDll.USBConnect usbConnect1;
        private System.Windows.Forms.Label Read_Mold;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
 
        private System.Windows.Forms.Label label4;
        private MyDll.USBConnect usbConnect2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox RecieveArea;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox SendArea;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FolderBrowserDialog dialog;
        private System.Windows.Forms.TreeView directoryTree;
        private System.Windows.Forms.ImageList directoryIcons;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox FilePathBox;
        private System.Windows.Forms.Button button4;
        private MyDll.USBConnect usbConnect3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox PicL;
        private System.Windows.Forms.TextBox PicW;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lenth;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem 默认发送格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox SendMode;
        private System.Windows.Forms.ToolStripMenuItem 默认接收格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox RecMode;
        private System.Windows.Forms.ToolStripMenuItem 定时器默认时间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox TickTime;
    }
}

