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
            this.SendID = new System.Windows.Forms.TextBox();
            this.ReciveID = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.默认路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.默认发送格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SendMode = new System.Windows.Forms.ToolStripComboBox();
            this.默认接收格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecMode = new System.Windows.Forms.ToolStripComboBox();
            this.默认定时时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TickDefaultBox = new System.Windows.Forms.ToolStripTextBox();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.请点击按钮ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Read_Mold = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RecieveArea = new System.Windows.Forms.TextBox();
            this.SendArea = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.restart = new System.Windows.Forms.Button();
            this.SendBPMBut = new System.Windows.Forms.Button();
            this.directoryTree = new System.Windows.Forms.TreeView();
            this.directoryIcons = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PicW = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.PicL = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.lenth = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.button1 = new System.Windows.Forms.Button();
            this.usbConnect3 = new MyDll.USBConnect();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.STMW = new System.Windows.Forms.TextBox();
            this.STML = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.usbConnect1 = new MyDll.USBConnect();
            this.usbConnect2 = new MyDll.USBConnect();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendID
            // 
            this.SendID.Location = new System.Drawing.Point(491, 59);
            this.SendID.Margin = new System.Windows.Forms.Padding(4);
            this.SendID.Name = "SendID";
            this.SendID.Size = new System.Drawing.Size(215, 25);
            this.SendID.TabIndex = 10;
            // 
            // ReciveID
            // 
            this.ReciveID.Location = new System.Drawing.Point(491, 95);
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
            this.设置ToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(731, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存为ToolStripMenuItem});
            this.新建ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("新建ToolStripMenuItem.Image")));
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.新建ToolStripMenuItem.Text = "文件";
            // 
            // 保存为ToolStripMenuItem
            // 
            this.保存为ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("保存为ToolStripMenuItem.Image")));
            this.保存为ToolStripMenuItem.Name = "保存为ToolStripMenuItem";
            this.保存为ToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.保存为ToolStripMenuItem.Text = "保存为..";
            this.保存为ToolStripMenuItem.Click += new System.EventHandler(this.保存为ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.默认路径ToolStripMenuItem,
            this.默认发送格式ToolStripMenuItem,
            this.默认接收格式ToolStripMenuItem,
            this.默认定时时间ToolStripMenuItem});
            this.设置ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("设置ToolStripMenuItem.Image")));
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 默认路径ToolStripMenuItem
            // 
            this.默认路径ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("默认路径ToolStripMenuItem.Image")));
            this.默认路径ToolStripMenuItem.Name = "默认路径ToolStripMenuItem";
            this.默认路径ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.默认路径ToolStripMenuItem.Text = "默认路径";
            this.默认路径ToolStripMenuItem.Click += new System.EventHandler(this.默认路径ToolStripMenuItem_Click);
            // 
            // 默认发送格式ToolStripMenuItem
            // 
            this.默认发送格式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SendMode});
            this.默认发送格式ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("默认发送格式ToolStripMenuItem.Image")));
            this.默认发送格式ToolStripMenuItem.Name = "默认发送格式ToolStripMenuItem";
            this.默认发送格式ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
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
            this.默认接收格式ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("默认接收格式ToolStripMenuItem.Image")));
            this.默认接收格式ToolStripMenuItem.Name = "默认接收格式ToolStripMenuItem";
            this.默认接收格式ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.默认接收格式ToolStripMenuItem.Text = "默认接收格式";
            // 
            // RecMode
            // 
            this.RecMode.Name = "RecMode";
            this.RecMode.Size = new System.Drawing.Size(121, 28);
            // 
            // 默认定时时间ToolStripMenuItem
            // 
            this.默认定时时间ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TickDefaultBox});
            this.默认定时时间ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("默认定时时间ToolStripMenuItem.Image")));
            this.默认定时时间ToolStripMenuItem.Name = "默认定时时间ToolStripMenuItem";
            this.默认定时时间ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.默认定时时间ToolStripMenuItem.Text = "默认定时时间";
            // 
            // TickDefaultBox
            // 
            this.TickDefaultBox.Name = "TickDefaultBox";
            this.TickDefaultBox.Size = new System.Drawing.Size(100, 27);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.请点击按钮ToolStripMenuItem});
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.helpToolStripMenuItem.Text = "帮助";
            // 
            // 请点击按钮ToolStripMenuItem
            // 
            this.请点击按钮ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("请点击按钮ToolStripMenuItem.Image")));
            this.请点击按钮ToolStripMenuItem.Name = "请点击按钮ToolStripMenuItem";
            this.请点击按钮ToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.请点击按钮ToolStripMenuItem.Text = "请点击？按钮然后点击控件";
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
            this.button2.Location = new System.Drawing.Point(120, 256);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "发送";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SendBut_Click_1);
            // 
            // Read_Mold
            // 
            this.Read_Mold.AutoSize = true;
            this.Read_Mold.Location = new System.Drawing.Point(359, 28);
            this.Read_Mold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Read_Mold.Name = "Read_Mold";
            this.Read_Mold.Size = new System.Drawing.Size(0, 15);
            this.Read_Mold.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(477, 256);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "清空";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "请选择图片：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.RecieveArea);
            this.tabPage2.Controls.Add(this.SendArea);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(681, 277);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "发送数据";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(1, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "发送数据区";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(377, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "接收数据区";
            // 
            // RecieveArea
            // 
            this.RecieveArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RecieveArea.Location = new System.Drawing.Point(354, -2);
            this.RecieveArea.Multiline = true;
            this.RecieveArea.Name = "RecieveArea";
            this.RecieveArea.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RecieveArea.Size = new System.Drawing.Size(329, 285);
            this.RecieveArea.TabIndex = 1;
            this.RecieveArea.TextChanged += new System.EventHandler(this.RecieveArea_TextChanged);
            // 
            // SendArea
            // 
            this.SendArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SendArea.Location = new System.Drawing.Point(-2, 1);
            this.SendArea.Multiline = true;
            this.SendArea.Name = "SendArea";
            this.SendArea.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SendArea.Size = new System.Drawing.Size(350, 282);
            this.SendArea.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.restart);
            this.tabPage1.Controls.Add(this.SendBPMBut);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.directoryTree);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.PicW);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.PicL);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(681, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "发送图片";
            // 
            // restart
            // 
            this.helpProvider1.SetHelpString(this.restart, "强制停止发送图片");
            this.restart.Location = new System.Drawing.Point(479, 243);
            this.restart.Name = "restart";
            this.helpProvider1.SetShowHelp(this.restart, true);
            this.restart.Size = new System.Drawing.Size(63, 23);
            this.restart.TabIndex = 46;
            this.restart.Text = "清屏";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // SendBPMBut
            // 
            this.SendBPMBut.Location = new System.Drawing.Point(152, 246);
            this.SendBPMBut.Name = "SendBPMBut";
            this.SendBPMBut.Size = new System.Drawing.Size(75, 23);
            this.SendBPMBut.TabIndex = 45;
            this.SendBPMBut.Text = "开始发送";
            this.SendBPMBut.UseVisualStyleBackColor = true;
            this.SendBPMBut.Click += new System.EventHandler(this.SendBPMBut_Click);
            // 
            // directoryTree
            // 
            this.directoryTree.Enabled = false;
            this.helpProvider1.SetHelpKeyword(this.directoryTree, "F2");
            this.helpProvider1.SetHelpString(this.directoryTree, "若无显示，请在设置中设置默认路径，下次也默认从改路径打开文件.如果卡死请选择文件夹比较小的路径，路径可在DebugINI配置文件里面修改");
            this.directoryTree.ImageIndex = 0;
            this.directoryTree.ImageList = this.directoryIcons;
            this.directoryTree.Location = new System.Drawing.Point(6, 34);
            this.directoryTree.Name = "directoryTree";
            this.directoryTree.SelectedImageIndex = 0;
            this.helpProvider1.SetShowHelp(this.directoryTree, true);
            this.directoryTree.Size = new System.Drawing.Size(273, 203);
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
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.helpProvider1.SetHelpString(this.pictureBox1, "显示的图片区，若不是图片格式则显示X");
            this.pictureBox1.Location = new System.Drawing.Point(286, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.helpProvider1.SetShowHelp(this.pictureBox1, true);
            this.pictureBox1.Size = new System.Drawing.Size(319, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            // 
            // PicW
            // 
            this.PicW.Location = new System.Drawing.Point(612, 100);
            this.PicW.Margin = new System.Windows.Forms.Padding(4);
            this.PicW.Name = "PicW";
            this.PicW.ReadOnly = true;
            this.PicW.Size = new System.Drawing.Size(58, 25);
            this.PicW.TabIndex = 38;
            // 
            // button5
            // 
            this.helpProvider1.SetHelpString(this.button5, "强制停止发送图片");
            this.button5.Location = new System.Drawing.Point(365, 243);
            this.button5.Name = "button5";
            this.helpProvider1.SetShowHelp(this.button5, true);
            this.button5.Size = new System.Drawing.Size(63, 23);
            this.button5.TabIndex = 44;
            this.button5.Text = "stop";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(610, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 40;
            this.label10.Text = "图片宽度";
            // 
            // PicL
            // 
            this.PicL.Location = new System.Drawing.Point(425, 2);
            this.PicL.Margin = new System.Windows.Forms.Padding(4);
            this.PicL.Name = "PicL";
            this.PicL.ReadOnly = true;
            this.PicL.Size = new System.Drawing.Size(57, 25);
            this.PicL.TabIndex = 37;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(47, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 34;
            this.button4.Text = "刷新";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "图片长度:";
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(17, 173);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(689, 306);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 42;
            this.label9.Text = "发送数据长度:";
            // 
            // lenth
            // 
            this.lenth.Location = new System.Drawing.Point(491, 145);
            this.lenth.Margin = new System.Windows.Forms.Padding(4);
            this.lenth.Name = "lenth";
            this.lenth.Size = new System.Drawing.Size(55, 25);
            this.lenth.TabIndex = 41;
            // 
            // button1
            // 
            this.helpProvider1.SetHelpKeyword(this.button1, "F1");
            this.helpProvider1.SetHelpString(this.button1, "读ID成功后可发送图片");
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(324, 64);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.helpProvider1.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(92, 52);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usbConnect3
            // 
            this.usbConnect3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.helpProvider1.SetHelpKeyword(this.usbConnect3, "F3");
            this.helpProvider1.SetHelpString(this.usbConnect3, "可以自动识别计算机内所有串口");
            this.usbConnect3.Location = new System.Drawing.Point(13, 33);
            this.usbConnect3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usbConnect3.Name = "usbConnect3";
            this.helpProvider1.SetShowHelp(this.usbConnect3, true);
            this.usbConnect3.Size = new System.Drawing.Size(279, 166);
            this.usbConnect3.TabIndex = 25;
            this.usbConnect3.Load += new System.EventHandler(this.usbConnect3_Load_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(656, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 15);
            this.label11.TabIndex = 49;
            this.label11.Text = "Lenth";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(578, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 15);
            this.label12.TabIndex = 48;
            this.label12.Text = "Width";
            // 
            // STMW
            // 
            this.STMW.Location = new System.Drawing.Point(571, 145);
            this.STMW.Margin = new System.Windows.Forms.Padding(4);
            this.STMW.Name = "STMW";
            this.STMW.ReadOnly = true;
            this.STMW.Size = new System.Drawing.Size(57, 25);
            this.STMW.TabIndex = 46;
            // 
            // STML
            // 
            this.STML.Location = new System.Drawing.Point(652, 145);
            this.STML.Margin = new System.Windows.Forms.Padding(4);
            this.STML.Name = "STML";
            this.STML.ReadOnly = true;
            this.STML.Size = new System.Drawing.Size(54, 25);
            this.STML.TabIndex = 47;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(539, 16);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(223, 15);
            this.linkLabel1.TabIndex = 50;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "yancy\'s Firstproject for c#";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(538, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 15);
            this.label13.TabIndex = 51;
            this.label13.Text = "若有疑问请点击:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(194, 504);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(352, 15);
            this.progressBar1.TabIndex = 43;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 20);
            this.toolStripStatusLabel1.Text = "发送图片->stm32";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 494);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(731, 25);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // usbConnect1
            // 
            this.usbConnect1.Location = new System.Drawing.Point(0, 0);
            this.usbConnect1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usbConnect1.Name = "usbConnect1";
            this.usbConnect1.Size = new System.Drawing.Size(280, 168);
            this.usbConnect1.TabIndex = 0;
            // 
            // usbConnect2
            // 
            this.usbConnect2.Location = new System.Drawing.Point(0, 0);
            this.usbConnect2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usbConnect2.Name = "usbConnect2";
            this.usbConnect2.Size = new System.Drawing.Size(280, 168);
            this.usbConnect2.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(731, 519);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.STMW);
            this.Controls.Add(this.STML);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lenth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.usbConnect3);
            this.Controls.Add(this.Read_Mold);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReciveID);
            this.Controls.Add(this.SendID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(800, 300);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LCD-TOOL";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SendID;
        private System.Windows.Forms.TextBox ReciveID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
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
 
        private System.Windows.Forms.Label label4;
        private MyDll.USBConnect usbConnect2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox SendArea;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FolderBrowserDialog dialog;
        private System.Windows.Forms.TreeView directoryTree;
        private System.Windows.Forms.ImageList directoryIcons;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private MyDll.USBConnect usbConnect3;
        private System.Windows.Forms.TextBox PicW;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lenth;
        private System.Windows.Forms.ToolStripMenuItem 默认发送格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox SendMode;
        private System.Windows.Forms.ToolStripMenuItem 默认接收格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox RecMode;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 请点击按钮ToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox STMW;
        private System.Windows.Forms.TextBox STML;
        private System.Windows.Forms.TextBox PicL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox RecieveArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button SendBPMBut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 默认定时时间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox TickDefaultBox;
        private System.Windows.Forms.Button restart;
    }
}

