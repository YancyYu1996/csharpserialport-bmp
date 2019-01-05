using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MyDll;
namespace Upper_LCD_STM32
{
    public partial class ChoosePath : Form
    {
       
        public ChoosePath()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           //获取当前程序运行的路径
        string path1 = System.Environment.CurrentDirectory;

        Win32API.INIWriteValue(path1 + "INI.ini", "INI", "defaultPath", textBox1.Text);
       
            this.Close();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dialog.Description = "请选择一个文件夹";
            //是否显示对话框左下角 新建文件夹 按钮，默认为 true
            dialog.ShowNewFolderButton = false;
            //首次defaultPath为空，按FolderBrowserDialog默认设置（即桌面）选择

            if (VitualUSB.defaultPath != "")
            {
                //设置此次默认目录为上一次选中目录
                dialog.SelectedPath = VitualUSB.defaultPath;
            }
            //按下确定选择的按钮
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //记录选中的目录
                VitualUSB.defaultPath = dialog.SelectedPath;
                textBox1.Text = VitualUSB.defaultPath;

            }
        }

        private void ChoosePath_Load(object sender, EventArgs e)
        {

        }
    }
}
