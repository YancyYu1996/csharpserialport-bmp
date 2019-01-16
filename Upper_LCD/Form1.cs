using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using MyDll;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Documents;
using System.IO;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System.Text.RegularExpressions;
using System.Threading;

namespace Upper_LCD_STM32
{
    public partial class Form1 : Form
    {
        public delegate void Displaydelegate(byte[] InputBuf);
        //Byte[] OutputBuf = new Byte[128];
        public Displaydelegate disp_delegate;
        public String ReadMold = "";
        public static int RecevieCounter = 0;
       
       
        int width;   //定义图片的长
        int height;  //定义图片的宽
        byte red;
        byte green;
        byte blue;
        

        static int y = 0;
        static int x = 0;
        private class IconIndexes

        {


            public const int OpenFolder = 0;      //文件夹打开


            public const int MyDocuments = 1;     //我的文档

            public const int MyFileTXT = 2;     //我的txt文档

            public const int MyFilePng = 3;     //我的图片

        }
        /// <summary>
        /// Form1的创建
        /// </summary>
        /// <param name="sender">基类</param>
        /// <param name="e">中断事件</param>
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += new EventHandler(timer1_Tick); //给timer挂起事件
            usbConnect3.ComPort.DataReceived += new SerialDataReceivedEventHandler(Comm_DataReceived);
         

        }

        /// <summary>
        /// COM口数据的接收
        /// </summary>
        /// <param name="sender">基类</param>
        /// <param name="e">中断事件</param>
        private void Comm_DataReceived(object sender, EventArgs e)
        {
            
            this.usbConnect3.Invoke(new EventHandler(delegate

            {
                if (this.usbConnect3.ComPort.IsOpen)     //此处可能没有必要判断是否打开串口
                {
                    Byte[] receivedData = new Byte[this.usbConnect3.ComPort.BytesToRead];        //创建接收字节数组
                    this.usbConnect3.ComPort.Read(receivedData, 0, receivedData.Length);         //读取数据                    

                    this.usbConnect3.ComPort.DiscardInBuffer();//清空SerialPort控件的Buffer

                    if (receivedData.Length == 10)
                    {
                        ReadMold = "Read_ID";
                        Read_Mold.Text = ReadMold;
                        Read_Mold.ForeColor = Color.Green;
                    }
                    else
                    {
                        ReadMold = "Read_BPM";
                        Read_Mold.Text = ReadMold;
                        Read_Mold.ForeColor = Color.Red;
                    }

                    //System.Text.Encoding.ASCII.GetString(receivedData);
                    try
                    {

                        //这是用以显示字符串
                        string strRcv = null;
                        foreach (byte d in receivedData)
                        {
                            if (RecMode.Text == "字符串")     //若字符串接收
                                strRcv += d;
                            else
                                strRcv += " " + Convert.ToString(d, 16); ;
                        }
                        if (receivedData.Length != 10)
                            RecieveArea.Text += strRcv;                 //显示信息
                                                                        //strRcv + "\r\n";             //显示信息
                        else
                        {
                            ReciveID.Text = strRcv;
                        }


                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message, "出错提示");
                        SendArea.Text = "";
                    }             //清空SerialPort控件的Buffer

                }


                else
                {
                    MessageBox.Show("请打开某个串口", "错误提示");
                }


            }));



        }
        /// <summary>
        /// 主窗体的加载
        /// </summary>
        /// <param name="sender">基类</param>
        /// <param name="e">终端事件</param>
        private void Form1_Load(object sender, EventArgs e)
        {

            tabPage1.ImageIndex = 4;
            tabPage2.ImageIndex = 2;
            TreeNode tn = new TreeNode();

            tn.Text = VitualUSB.defaultPath;

            getDirectories(VitualUSB.defaultPath, tn);

            directoryTree.Nodes.Add(tn);
            tn.Expand();

            TickTime.Text = "1";  //初始化定时器时间
            string[] geshis = { "十六进制", "字符串" };   //设置默认的发送文件的格式
            toolStripStatusLabel1.Text = "";
            foreach (string geshi in geshis)  
            {
                SendMode.Items.Add(geshi);  
                RecMode.Items.Add(geshi);
            }
            SendMode.SelectedIndex = 0;
            RecMode.SelectedIndex = 0;
        }
        /// <summary>


        /// 循环遍历获得某一目录下的所有文件信息


        /// </summary>


        /// <param name="path">目录名</param>


        /// <param name="tn">树节点</param>


        public void getDirectories(string path, TreeNode tn)
        {

            try
            {
                string[] fileNames = Directory.GetFiles(path);
                string[] directories = Directory.GetDirectories(path);
                DirectoryInfo folder = new DirectoryInfo(path);
                tn.Text = folder.Name;
                tn.Tag = folder.FullName;

                //先遍历这个目录下的文件夹
                foreach (string dir in directories)
                {

                    TreeNode subtn = new TreeNode();

                    subtn.Tag = dir;

                    subtn.Text = GetShorterFileName(dir);

                    getDirectories(dir, subtn);
                    subtn.SelectedImageIndex = IconIndexes.OpenFolder; //选择节点显示图片
                    tn.Nodes.Add(subtn);

                }


                //再遍历这个目录下的文件
                foreach (string file in fileNames)
                {

                    TreeNode subtn = new TreeNode();

                    subtn.Text = GetShorterFileName(file);
                    subtn.Tag = file;
                    if (file == "(*.txt)")
                    {

                        subtn.SelectedImageIndex = IconIndexes.MyFileTXT; //选择节点显示图片
                    }
                    else if (file == "(*.jpg)" | file == "(*.bmp)")
                    {

                        subtn.SelectedImageIndex = IconIndexes.MyFilePng;//选择节点显示图片
                    }
                    else
                    {
                        subtn.SelectedImageIndex = IconIndexes.MyDocuments;//选择节点显示图片
                    }

                    tn.Nodes.Add(subtn);

                }


            }
            catch (Exception msg)
            { }

        }


        /// <summary>
                /// 滤去文件名前面的路径
               /// </summary>
                /// <param name="filename"></param>
                /// <returns></returns>
        public string GetShorterFileName(string filename)
        {

            return filename.Substring(filename.LastIndexOf("\\") + 1);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            SendID.Clear();
            byte[] ID = new byte[12];
            ID[0] = 0x95;  //前两代表个字节型号
            ID[1] = 0x00;
            ID[2] = 0x03;
            ID[3] = 0x00;
            ID[4] = 0x00;
            ID[5] = 0x00;
            ID[6] = 0x00;
            ID[7] = 0x00;
            ID[8] = 0x00;
            ID[9] = 0xBB;// 结束的标志位
            ID[10] = 0x0D; //后两个字节必须为0x0d，0x0a；
            ID[11] = 0x0A;
            for (byte i = 0; i < ID.Length; i++)
            {
                SendID.Text += Convert.ToString(ID[i], 16);
            }
            if (usbConnect3.ComPort.IsOpen)
            {
                this.usbConnect3.ComPort.Write(ID, 0, ID.Length);

            }
            else
            {
                MessageBox.Show("串口没有打开");
            }

        }

        private void usbConnect3_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 发送按钮
        /// </summary>
        /// <param name="sender"> </param>
        /// <param name="e">中断事件</param>

        private void SendBut_Click_1(object sender, EventArgs e)
        {

            if (!this.usbConnect3.ComPort.IsOpen) //如果没打开
            {
                MessageBox.Show("请先打开串口！", "Error");
                return;
            }
            if (timer1.Enabled == false)  //发送，使能定时器
            {
                y = 0;      //先将行列清零
                x = 0;
                timer1.Enabled = true;
            }
            else
            {
                MessageBox.Show("定时器正在发送,请稍后！");

            }
            String strSend = SendArea.Text;
            if (SendMode.Text == "十六进制")	//“HEX发送” 按钮 
            {
             
                
                string[] strArray = strSend.Split(' ');
               
                byte[] value = new byte[strArray.Length+2];

                string ChangeFlag;
                ChangeFlag = HEX2ASCII(strSend,ref value);
                    
          //      if(ChangeFlag != "")
          //      {
                    value[strArray.Length] = 0x0D;
                    value[strArray.Length+1] = 0x0A;
                //     }


                if (usbConnect3.ComPort.IsOpen)
                {
                    this.usbConnect3.ComPort.Write(value, 0, value.Length);

                }
                   


            }
            else		//以字符串形式发送时 
            {
                this.usbConnect3.ComPort.WriteLine(SendArea.Text);    //写入数据
            }

        }
        /// <summary>
        /// 16进制字符串专为ASCII码字符串
        /// </summary>
        /// <param name="sender"> </param>
        /// <param name="e">中断事件</param>
        public string HEX2ASCII(string hexstring,ref byte[] value)
        {
            try
            {
                if (hexstring == "")
                    return "";
                string[] str = hexstring.Split(' ');
                
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == "")
                        break;
                    if ((str[i] == "\r") || (str[i] == "\n"))
                        continue;
                    value[i] = Convert.ToByte(str[i], 16);

                }
         
                return Encoding.Default.GetString(value);
                //return value;

            }
            catch
            {
               return "";
            }

        }

        private void RecevieArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                SendArea.Clear();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                this.RecieveArea.Clear();
            }

        }

       

        private void 默认路径ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoosePath choosePath = new ChoosePath();
            choosePath.textBox1.Text = VitualUSB.defaultPath;
            
            choosePath.ShowDialog();
                  

        }



        private void button4_Click(object sender, EventArgs e)
        {
            string refPath = Win32API.INIGetStringValue(VitualUSB.path1 + "INI.ini", "INI", "defaultPath", null);
            directoryTree.Nodes.Clear();
            TreeNode tn = new TreeNode();

            tn.Text = refPath;

            getDirectories(refPath, tn);

            directoryTree.Nodes.Add(tn);
            tn.Expand();
        }

        private void directoryTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Thread.Sleep(100);
     
            y = 0;
            x = 0;
            lenth.Text = "0";
            FilePathBox.Text = Convert.ToString(e.Node.Tag);
           //ScriptEngine pyEngine = Python.CreateEngine();//创建Python解释器对象
           //dynamic py = pyEngine.ExecuteFile(@"OpenPng.py");//读取脚本文件
            SendArea.Clear();
            try
            {
                using (FileStream fs = new FileStream(FilePathBox.Text, FileMode.Open, FileAccess.Read)) //图片数据流
                {
                    System.Drawing.Image image = System.Drawing.Image.FromStream(fs);
                    width = image.Width;
                    height = image.Height;
                    PicL.Text = width.ToString();
                    PicW.Text = height.ToString();
                    progressBar1.Maximum = width * height;  //记录像素点的最大个数
                    lenth.Text = "0";
                    timer1.Interval = Convert.ToInt16(TickTime.Text);       //设置定时器时间
                    timer1.Enabled = true;                                  //定时器开始工作  
                }
               
            }
            catch
            {

            }

            try
            {
                pictureBox1.Image = Image.FromFile(FilePathBox.Text);
            }
            catch
            {
                pictureBox1.Image = pictureBox1.ErrorImage;
            }

          









        }

 

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (usbConnect3.ComPort.IsOpen)
                sendpng();

        }

        public string sendpng()
        {
            byte[] BytesRGB = new byte[5];

            BytesRGB[3] = 0x0D;
            BytesRGB[4] = 0x0A;
          
            try
            {
                Bitmap bmp = new Bitmap(FilePathBox.Text);
                if ((x < width) && (y < height))
                {              
                            Color pixelColor = bmp.GetPixel(x, y);
                            //颜色的 RED 分量值
                            red = pixelColor.R;
                            //颜色的 GREEN 分量值
                            green = pixelColor.G;
                            //颜色的 BLUE 分量值
                            blue = pixelColor.B;
                            BytesRGB[0] = Convert.ToByte(red);

                            BytesRGB[1] = Convert.ToByte(green);
                            BytesRGB[2] = Convert.ToByte(blue);
                            //   SendArea.Text += red.ToString("X2") + " " + green.ToString("X2") + " " + blue.ToString("X2") + " ";

                            if (usbConnect3.ComPort.IsOpen)    //如果检测到COM连接，再发送读取到的像素数据
                            {
                                toolStripStatusLabel1.Text = "发送图片数据->sSTM32";
                                toolStripStatusLabel1.ForeColor = Color.Red;
                                usbConnect3.ComPort.Write(BytesRGB, 0, 5);
                            }
                            lenth.Text = (width * y + x+1).ToString();  //求出此时发送的数据个数
                            progressBar1.Value = width * y + x+1;
                    x += 1;
                    if(x == width)
                    {
                    x = 0;
                    y += 1;
                    }
                }

                else
                {
                    toolStripStatusLabel1.Text = "发送完成";
                    toolStripStatusLabel1.ForeColor = Color.Green;
                    timer1.Enabled = false;

                }
                return "true";
            }
            catch
            {
                return "false";

            }


        }

        private void 默认发送格式ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

       
    }
    
    }

    

