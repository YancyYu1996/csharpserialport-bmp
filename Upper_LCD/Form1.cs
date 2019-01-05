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

namespace Upper_LCD_STM32
{
    public partial class Form1 : Form
    {
        public delegate void Displaydelegate(byte[] InputBuf);
        //Byte[] OutputBuf = new Byte[128];
        public Displaydelegate disp_delegate;
        public String ReadMold = "";
        public static int RecevieCounter = 0;
        
        public Form1()
        {

            InitializeComponent();
      
            this.usbConnect1.ComPort.DataReceived += new SerialDataReceivedEventHandler(Comm_DataReceived);
            ReseveHex.Checked = true;
            SendHex.Checked = true;
            


        }
        private void Comm_DataReceived(object sender, EventArgs e)
        {

            this.usbConnect1.Invoke(new EventHandler(delegate

            {
                if (this.usbConnect1.ComPort.IsOpen)     //此处可能没有必要判断是否打开串口
                {  
                    Byte[] receivedData = new Byte[this.usbConnect1.ComPort.BytesToRead];        //创建接收字节数组
                    this.usbConnect1.ComPort.Read(receivedData, 0, receivedData.Length);         //读取数据                    

                    this.usbConnect1.ComPort.DiscardInBuffer();//清空SerialPort控件的Buffer

                    if (receivedData.Length == 10)
                    {
                        ReadMold = "Read_ID";   
                    }
                    else
                    {
                        ReadMold = "Read_BPM";
                    }
                    Read_Mold.Text = ReadMold;
                    //System.Text.Encoding.ASCII.GetString(receivedData);
                    try
                        {
                      
                            //这是用以显示字符串
                        string strRcv = null;
                                foreach (byte d in receivedData)
                                {
                                if (ReseveStr.Checked)     //若字符串接收
                                strRcv += d;
                                else
                                strRcv += Convert.ToString(d, 16); ;
                        }
                        RecieveArea.Text += strRcv;                 //显示信息
                        //strRcv + "\r\n";             //显示信息
                            
                            
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






        private void Form1_Load(object sender, EventArgs e)
        {
           
            tabPage1.ImageIndex = 4;
            tabPage2.ImageIndex = 2;
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
            for (byte i = 0;i< ID.Length; i++)
            {
                SendID.Text +=Convert.ToString(ID[i],16);
            }      
            if (usbConnect1.ComPort.IsOpen)
            {
                this.usbConnect1.ComPort.Write(ID,0, ID.Length);
               
            }
        }

        private void usbConnect1_Load(object sender, EventArgs e)
        {

        }

  

        private void SendBut_Click_1(object sender, EventArgs e)
        {
            
            if (!this.usbConnect1.ComPort.IsOpen) //如果没打开
            {
                MessageBox.Show("请先打开串口！", "Error");
                return;
            }

            String strSend = SendArea.Text;
            if (SendHex.Checked == true)	//“HEX发送” 按钮 
            {
                //处理数字转换
                string sendBuf = strSend;
                string sendnoNull = sendBuf.Trim();
                string sendNOComma = sendnoNull.Replace(',', ' ');    //去掉英文逗号
                string sendNOComma1 = sendNOComma.Replace('，', ' '); //去掉中文逗号
                string strSendNoComma2 = sendNOComma1.Replace("0x", "");   //去掉0x
                strSendNoComma2.Replace("0X", "");   //去掉0X
                string[] strArray = strSendNoComma2.Split(' ');

                int byteBufferLength = strArray.Length;
                int decNum = 0;
                // int temp = 0;
                byte[] byteBuffer = new byte[byteBufferLength];
                int ii = 0;
                foreach(string str in strArray)  //对获取的字符做相加运算
                {

                    Byte[] bytesOfStr = Encoding.Default.GetBytes(str);


                    try
                    {
                         decNum = Convert.ToInt32(str, 16); //atrArray[i] == 12时，temp == 18 
                    }
                    catch(ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("请输入发送的数据");

                    }




                    try    //防止输错，使其只能输入一个字节的字符
                    {
                        byteBuffer[ii] = Convert.ToByte(decNum);
                        SendArea.Text += byteBuffer[ii];
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("字节越界，请逐个字节输入！", "Error");
                       
                        return;
                    }

                    ii++;
                }
                this.usbConnect1.ComPort.Write(byteBuffer, 0, byteBuffer.Length);
                 
            }
            else		//以字符串形式发送时 
            {
                this.usbConnect1.ComPort.WriteLine(SendArea.Text);    //写入数据
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void viewFile4_Load(object sender, EventArgs e)
        {

        }

        private void viewFile1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void SendArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReseveHex_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //这个是按钮的事件
       

        private void DataSendView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void SendArea_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewFile3_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SendArea.Text != ViewFile.data)
            {
                SendArea.Text = ViewFile.data;

            }
                
        }
    }
    }

    

