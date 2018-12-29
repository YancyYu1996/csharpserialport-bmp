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

            public const int MyComputer = 0;      //我的电脑

            public const int ClosedFolder = 1;    //文件夹关闭

            public const int OpenFolder = 2;      //文件夹打开

            public const int FixedDrive = 3;      //磁盘盘符

            public const int MyDocuments = 4;     //我的文档

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

            
 

                //实例化TreeNode类 TreeNode(string text,int imageIndex,int selectImageIndex)            

                TreeNode rootNode = new TreeNode("我的电脑",

                    IconIndexes.MyComputer, IconIndexes.MyComputer);  //载入显示 选择显示

                rootNode.Tag = "我的电脑";                            //树节点数据

                rootNode.Text = "我的电脑";                           //树节点标签内容

                this.directoryTree.Nodes.Add(rootNode);               //树中添加根目录



                //显示MyDocuments(我的文档)结点

                var myDocuments = Environment.GetFolderPath           //获取计算机我的文档文件夹

                    (Environment.SpecialFolder.MyDocuments);

                TreeNode DocNode = new TreeNode(myDocuments);

                DocNode.Tag = "我的文档";                            //设置结点名称

                DocNode.Text = "我的文档";

                DocNode.ImageIndex = IconIndexes.MyDocuments;         //设置获取结点显示图片

                DocNode.SelectedImageIndex = IconIndexes.MyDocuments; //设置选择显示图片

                rootNode.Nodes.Add(DocNode);                          //rootNode目录下加载节点

                DocNode.Nodes.Add("");



                //循环遍历计算机所有逻辑驱动器名称(盘符)

                foreach (string drive in Environment.GetLogicalDrives())

                {

                    //实例化DriveInfo对象 命名空间System.IO

                    var dir = new DriveInfo(drive);

                    switch (dir.DriveType)           //判断驱动器类型

                    {

                        case DriveType.Fixed:        //仅取固定磁盘盘符 Removable-U盘 

                            {

                                //Split仅获取盘符字母

                                TreeNode tNode = new TreeNode(dir.Name.Split(':')[0]);

                                tNode.Name = dir.Name;

                                tNode.Tag = tNode.Name;

                                tNode.ImageIndex = IconIndexes.FixedDrive;         //获取结点显示图片

                                tNode.SelectedImageIndex = IconIndexes.FixedDrive; //选择显示图片

                                directoryTree.Nodes.Add(tNode);                    //加载驱动节点

                                tNode.Nodes.Add("");

                            }

                            break;

                    }

                }

                rootNode.Expand();                  //展开树状视图
                                                    // directoryTree.Nodes[3].Expand();
       
          //  FindEvery();
        }

        /// <summary>

        /// 在结点展开后发生 展开子结点

        /// </summary>

        private void directoryTree_AfterExpand(object sender, TreeViewEventArgs e)

        {

            e.Node.Expand();

        }



        /// <summary>

        /// 在将要展开结点时发生 加载子结点

        /// </summary>

        private void directoryTree_BeforeExpand(object sender, TreeViewCancelEventArgs e)

        {

            TreeViewItems.Add(e.Node);

        }



        /// <summary>

        /// 自定义类TreeViewItems 调用其Add(TreeNode e)方法加载子目录

        /// </summary>

        public static class TreeViewItems

        {

            public static void Add(TreeNode e)

            {

                //try..catch异常处理

                try

                {

                    //判断"我的电脑"Tag 上面加载的该结点没指定其路径

                    if (e.Tag.ToString() != "我的电脑")

                    {

                        e.Nodes.Clear();                               //清除空节点再加载子节点

                        TreeNode tNode = e;                            //获取选中\展开\折叠结点

                        string path = tNode.Name;                      //路径  



                        //获取"我的文档"路径

                        if (e.Tag.ToString() == "我的文档")

                        {

                            path = Environment.GetFolderPath           //获取计算机我的文档文件夹

                                (Environment.SpecialFolder.MyDocuments);

                        }



                        //获取指定目录中的子目录名称并加载结点
                        

                        string[] dics = Directory.GetDirectories(path);

                        foreach (string dic in dics)

                        {

                            TreeNode subNode = new TreeNode(new DirectoryInfo(dic).Name); //实例化

                            subNode.Name = new DirectoryInfo(dic).FullName;               //完整目录

                            subNode.Tag = subNode.Name;

                            subNode.ImageIndex = IconIndexes.ClosedFolder;       //获取节点显示图片

                            subNode.SelectedImageIndex = IconIndexes.OpenFolder; //选择节点显示图片

                            tNode.Nodes.Add(subNode);

                            subNode.Nodes.Add("");                               //加载空节点 实现+号

                        }

                    }

                }

                catch (Exception msg)

                {

                    MessageBox.Show(msg.Message);                   //异常处理

                }

            }

        }
        /// <summary>
        /// 遍历所有节点
        /// </summary>
        /// <param name="tv">TreeView</param>
        /// <param name="tnc">tc=tv.Nodes</param>
        /// <param name="nds">node.Text</param>
        public void FindEvery()
        {
            try

            {


                //  directoryTree.Nodes.Clear();                               //清除空节点再加载子节点

                 string path = MyDll.VitualUSB.defaultPath;                      //路径  
               

                //获取指定目录中的子目录名称并加载结点


                string[] dics = Directory.GetDirectories(path);

                foreach (string dic in dics)

                {

                    TreeNode subNode = new TreeNode(new DirectoryInfo(dic).Name); //实例化

                    subNode.Name = new DirectoryInfo(dic).FullName;               //完整目录

                    subNode.Tag = subNode.Name;

                    subNode.ImageIndex = IconIndexes.ClosedFolder;       //获取节点显示图片

                    subNode.SelectedImageIndex = IconIndexes.OpenFolder; //选择节点显示图片
                    subNode.Expand();


                    subNode.Nodes.Add("");                               //加载空节点 实现+号

                }

            }



            catch (Exception msg)

            {

                MessageBox.Show(msg.Message);                   //异常处理

            }
        }

            private void directoryTree_AfterSelect(object sender, TreeViewEventArgs e)
            {

            }

        }
    }

    
