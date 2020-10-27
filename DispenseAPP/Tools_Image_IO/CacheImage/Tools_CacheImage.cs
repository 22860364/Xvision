using System;
using System.Windows.Forms;
using System.Reflection;
using DispenseAPP.AttributeClass;
using System.Collections.Generic;
using static DispenseAPP.CommonClass;
using HalconDotNet;

namespace DispenseAPP.Tools_Image_IO.CacheImage
{
    public partial class Tools_CacheImage : UserControl, IEvent
    {
        public event ClickCancelDelegate _clickCancelButton;
        public event ClickOKButtonDelegate _clickOKButton;
        private ImageCacheClass _imageCacheClass;
        private ProjectParamClass _projectParamClass;

        public Tools_CacheImage(ImageCacheClass imageCacheClass, ProjectParamClass projectParamClass)
        {
            InitializeComponent();
            _imageCacheClass = imageCacheClass;
            Txt_Name.DataBindings.Add("Text", _imageCacheClass, "BlockName", false, DataSourceUpdateMode.OnPropertyChanged);
            _projectParamClass = projectParamClass;            
        }

        private void InitialReference()//初始化引用
        {
            List<Element> elements = _projectParamClass._flowChartList.FindAll(c => c is NormalBlock);//获得所有的普通算子块
            foreach (Element item in elements)//遍历普通算子块
            {
                NormalBlock normalBlock = item as NormalBlock;
                List<ITools> tools = normalBlock.ToolsList.FindAll(c => c.GetType().IsDefined(typeof(ReferenceImageAttribute)) && c.StepState == true);//查找所有被标记为引用图像的工具
                if (tools.Count > 0)
                {
                    TreeNode treeNode = new TreeNode(normalBlock.Name);
                    Tv_Image.Nodes.Add(treeNode);//添加算子块
                    foreach (ITools items in tools)
                    {
                        foreach (PropertyInfo propertyInfo in items.GetType().GetProperties())
                        {
                            if (propertyInfo.IsDefined(typeof(ReferenceImageAttribute)))
                            {
                                TreeNode toolsNode = new TreeNode(items.BlockName + "." + propertyInfo.Name);
                                treeNode.Nodes.Add(toolsNode);
                            }
                        }
                    }
                }
            }
            if (_imageCacheClass.SelectNode != "")//编辑状态的情况下要突出显示被选中的那个算子
            {
                if (_imageCacheClass.SelectNode.Split('-')[0] == "图像缓存") //如果是图像缓存的时候 应该不会出现异常
                {
                    TreeNode treeNode = FindFirstTreeNode("图像缓存");//先找一级节点
                    treeNode.Expand();
                    Tv_Image.SelectedNode = FindSecondTreeNode(treeNode, _imageCacheClass.SelectNode.Split('-')[1]);
                }
                else
                {
                    TreeNode treeNode = FindFirstTreeNode(_imageCacheClass.SelectNode.Split('-')[0]);//先找负节点
                    if (treeNode != null)
                    {
                        treeNode.Expand();
                        TreeNode tree = FindSecondTreeNode(treeNode, _imageCacheClass.SelectNode.Split('-')[1]);//找子节点
                        if (tree != null)
                        {
                            ITools tools = GetTools(_imageCacheClass.SelectNode.Split('-')[0],_imageCacheClass.SelectNode.Split('-')[1].Split('.')[0]);
                            if(tools.StepState == true)
                            {
                                Tv_Image.SelectedNode = tree;
                                ExecuteDispImage(tools, _imageCacheClass.SelectNode.Split('-')[1].Split('.')[1]);
                            }
                            else
                            {
                                CreateEmptyTreeNode();
                            }
                        }
                        else
                        {
                            CreateEmptyTreeNode();
                        }
                    }
                    else
                    {
                        CreateEmptyTreeNode();
                    }
                }
            }
        }

        private void ExecuteDispImage(ITools tools,string value)
        {
            if (tools.GetType().GetProperty(value).GetValue(tools) is HImage image)
            {
                WindowIndexDic[CurrentWindowIndex].DispImage(image,true);
            }
        }

        private ITools GetTools(string blockName,string toolName)//得到工具
        {
            Element elements = _projectParamClass._flowChartList.Find(c => c.Name == blockName && c is NormalBlock);//获得普通算子块
            NormalBlock normalBlock = elements as NormalBlock;
            foreach (ITools item in normalBlock.ToolsList)
            {
                if (item.BlockName == toolName)
                {
                    return item;
                }
            }
            return default(ITools);
        }


        private void CreateEmptyTreeNode()//创建空的树节点
        {
            TreeNode treeNode = new TreeNode("???");
            Tv_Image.Nodes.Add(treeNode);
            TreeNode tree = new TreeNode("???");
            treeNode.Nodes.Add(tree);
            Tv_Image.SelectedNode = tree;
        }

        private TreeNode FindFirstTreeNode(string value)//查找一级节点
        {
            TreeNode treeNode = null;
            foreach (TreeNode item in Tv_Image.Nodes)
            {
                if (item.Text == value)
                {
                    treeNode = item;
                }
            }
            return treeNode;
        }

        private TreeNode FindSecondTreeNode(TreeNode treeNode, string value)//查找二级节点
        {
            TreeNode _treeNode = null;
            foreach (TreeNode item in treeNode.Nodes)
            {
                if (item.Text == value)
                {
                    _treeNode = item;
                }
            }
            return _treeNode;
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            _imageCacheClass.BlockName = Txt_Name.Text;
            _imageCacheClass.SelectNode = Tv_Image.SelectedNode.Parent.Text + "-" + Tv_Image.SelectedNode.Text;
            _imageCacheClass.ResetDisplay = cb_ImageBackUp.Checked;
            _clickOKButton(_imageCacheClass);
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            _clickCancelButton();
        }

        private void Tv_Image_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            e.DrawDefault = true;
            return;
        }

        private void Tv_Image_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)//鼠标单击节点时发生
        {
            if (e.Node.Level >= 1)
            {
                if(e.Node.Text != "???" && !e.Node.Text.Contains("缓存队列"))
                {
                    ExecuteDispImage(GetTools(e.Node.Parent.Text, e.Node.Text.Split('.')[0]), e.Node.Text.Split('.')[1]);
                }
            }
        }

        private void Tools_CacheImage_Load(object sender, EventArgs e)
        {
            InitialReference();
        }
    }
}
