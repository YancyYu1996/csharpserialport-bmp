using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyDll
{
    public partial class ViewFile : UserControl
    {

        /// <summary>

        /// IconIndexs类 对应ImageList中5张图片的序列

        /// </summary>

        private class IconIndexes

        {


            public const int OpenFolder = 0;      //文件夹打开


            public const int MyDocuments = 1;     //我的文档

            public const int MyFileTXT = 2;     //我的txt文档

            public const int MyFilePng = 3;     //我的图片

        }

        public ViewFile()
        {
            InitializeComponent();
        }
        /// <summary>

        /// 窗体加载Load事件 初始化

        /// </summary>

        private void ViewFile_Load(object sender, EventArgs e)
        {
            TreeNode tn = new TreeNode();

            tn.Text = VitualUSB.defaultPath;

            getDirectories(VitualUSB.defaultPath, tn);

            directoryTree.Nodes.Add(tn);
            tn.Expand();
           

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
       
                //先遍历这个目录下的文件夹
                foreach (string dir in directories)
                {

                    TreeNode subtn = new TreeNode();

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
                    if (file == "(*.txt)")
                    {
                        subtn.SelectedImageIndex = IconIndexes.MyFileTXT; //选择节点显示图片
                    }
                    else if (file == "(*.jpg | *.bmp)")
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


      
        /// <summary>
        /// 遍历所有节点
        /// </summary>
        /// <param name="tv">TreeView</param>
        /// <param name="tnc">tc=tv.Nodes</param>
        /// <param name="nds">node.Text</param>
        public void FindEvery()
        {
           
        }
  
        
        private void directoryTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string refPath = Win32API.INIGetStringValue(VitualUSB.path1 + "INI.ini", "INI", "defaultPath", null);
            directoryTree.Nodes.Clear();
            TreeNode tn = new TreeNode();

            tn.Text = refPath;

            getDirectories(refPath, tn);

            directoryTree.Nodes.Add(tn);
            tn.Expand();
        }
    }
    }

    
