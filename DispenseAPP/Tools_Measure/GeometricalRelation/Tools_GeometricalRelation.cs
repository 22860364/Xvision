using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace DispenseAPP.Tools_Measure.GeometricalRelation
{
    public partial class Tools_GeometricalRelation : UserControl,IEvent 
    {
        private GeometericalRelationClass _geometericalRelationClass;
        public Tools_GeometricalRelation(GeometericalRelationClass geometericalRelationClass)
        {
            InitializeComponent();
            _geometericalRelationClass = geometericalRelationClass;
            txt_Name.DataBindings.Add("Text", _geometericalRelationClass, "BlockName", false, DataSourceUpdateMode.OnPropertyChanged);
            cmb_GeometricFeature.SelectedItem = _geometericalRelationClass.GeometericalFeature;
            InitialReferencePoint();
        }

        public event ClickOKButtonDelegate _clickOKButton;
        public event ClickCancelDelegate _clickCancelButton;

        private void InitialReferencePoint()
        {
            List<ITools> toolsList = _geometericalRelationClass.SelectedNormalBlock.ToolsList.GetRange(0, FrmEdit._currentRowIndex + 1);
            if(toolsList != null)
            {
                foreach (ITools item in toolsList)
                {
                    if (item.GetType().IsDefined(typeof(ReferencePointAttribute), true))//当前工具类是否被标记为引用点
                    {
                        foreach (PropertyInfo items in item.GetType().GetProperties())//获得该类的所有属性
                        {                       
                            if (items.IsDefined(typeof(ReferencePointAttribute),true))//判断该属性是否被标记为引用点特性
                            {
                                TreeNode parentNode = new TreeNode(item.BlockName + "-" + items.Name);
                                Tv_ReferencePoint.Nodes.Add(parentNode);
                                object objs = items.GetValue(item, null);
                                if(objs is Array)
                                {
                                    PointF[] pointF = objs as PointF[];
                                    for (int i = 0; i < pointF.Length; i++)
                                    {
                                        TreeNode node = new TreeNode("Point[" + i.ToString() + "]");
                                        parentNode.Nodes.Add(node);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if(_geometericalRelationClass.SelectedNormalBlock.ToolsList.Find(c=>c.BlockName == txt_Name.Text) == null)
            {
                _geometericalRelationClass.BlockName = txt_Name.Text;
                _clickOKButton(_geometericalRelationClass);
            }
            else
            {
                MessageBox.Show("该算子名已经被使用！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            _clickCancelButton();
        }
    }
}
