using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO.Ports;
namespace MyDll
{
    public partial class USBConnect : UserControl
    {

    
        static int beforeS;
        public USBConnect()
        {
            InitializeComponent();
            timer1.Tick += new EventHandler(timer1_Tick); //给timer挂起事件

            timer1.Enabled = true;//使timer可用

            timer1.Interval = 100; //设置时间间隔，以毫秒为单位
            string[] bounds = { "2400", "4800", "9600", "14400", "19200", "38400", "56000", "57600", "115200" };
            foreach (string bound in bounds)
            {
                BoundBox.Items.Add(bound);
            }
            BoundBox.SelectedIndex = 8;

            string[] t = SerialPort.GetPortNames();
   
                foreach (string com in t)
                {

                    USBConBox.Items.Add(com);

                }

            try
            {
                USBConBox.SelectedIndex = 0;
            }
            catch
            { }

        }
      

        public void USBConBox_TextChanged(object sender, EventArgs e)
        {

        }
        public void Check_USB_Connect()
        {
            
            string[] t = SerialPort.GetPortNames();

           

            if ((USBConBox.Items.Count != t.Length) && (!ComPort.IsOpen))
            {
                USBConBox.Items.Clear();
                foreach (string com in t)
                {

                    USBConBox.Items.Add(com);
                              
                }
                try
                {
                    USBConBox.Text = t[0];
                }
                catch
                {
                    USBConBox.Items.Clear();
                }
            }
            beforeS = t.Length;

            if (beforeS == 0)    //判断是否找到串口
            {
                USBConBox.Text = "";
                OpenBut.Enabled = false;
                OpenBut.ForeColor = Color.Gray;
                FindS.Text = "无串口";
                FindS.ForeColor = Color.Red;

            }
            else
            {
              
                OpenBut.Enabled = true;
                OpenBut.ForeColor = Color.Black;
                FindS.Text = "找到串口";
                FindS.ForeColor = Color.Green;
                if (ComPort.IsOpen)  //判断是否连接
                {
                    OpenBut.Text = "关闭串口";
                    ComStause.Text = "串口已经连接";
                    ComStause.ForeColor = Color.Green;
                }
                else
                {

                    OpenBut.Text = "打开串口";
                    ComStause.Text = "串口未连接";
                    ComStause.ForeColor = Color.Red;
                }
            }

            



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Check_USB_Connect();
        }

        private void OpenBut_Click(object sender, EventArgs e)
        {
            if (ComPort.IsOpen)
            {
                ComPort.Close();
                
            }
            else
            {
                ComPort.PortName = USBConBox.Text;
                while (!ComPort.IsOpen)
                {
                   
                    ComPort.BaudRate =Convert.ToInt32(BoundBox.Text);
                    try
                    {
                        ComPort.Open();
                    }
                    catch
                    {
                        MessageBox.Show("设备没有正常连接");
                        break;
                    }
                    
                    
                }
               
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void USBConBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
}
