using DispenseAPP.CustomControl;
using DispenseAPP.FlowChart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace DispenseAPP
{
    public partial class FrmIfSwitchPort : FormM
    {
        public FrmIfSwitchPort(IfSwitchJudgeClass ifSwitchJudge, ProjectParamClass projectParm)
        {
            InitializeComponent();//注意：这里的下拉列表要使用数据绑定 手动赋值比较麻烦          
            _projectParam = projectParm;
            _ifSwitchJudgeClass = ifSwitchJudge;
            InitialControl();
        }

        private ProjectParamClass _projectParam;

        private IfSwitchJudgeClass _ifSwitchJudgeClass;

        private Dictionary<string, List<string>> BlockNameMeasureValueDic = new Dictionary<string, List<string>>();//存放算子块和测量值的键值对集合

        private void InitialControl()
        {
            txt_Port.Text = "Port" + _ifSwitchJudgeClass.Port.ToString();
            foreach (Element item in _projectParam._flowChartList)//通过遍历 向键值对集合中添加算子名称和对应的测量值
            {
                if (item is NormalBlock)//如果是普通算子
                {
                    NormalBlock normalBlock = item as NormalBlock;
                    if (normalBlock.ToolsList.Count > 0)
                    {
                        List<string> list = new List<string>();
                        foreach (ITools items in normalBlock.ToolsList)
                        {
                            foreach (PropertyInfo itemss in items.GetType().GetProperties())
                            {
                                if(itemss.IsDefined(typeof(ConditionJudgeAttribute)))
                                {
                                    list.Add(items.BlockName + "-" + itemss.Name);
                                }
                            }                      
                        }
                        BlockNameMeasureValueDic.Add(item.Name, list);
                    }
                }
            }
            foreach (KeyValuePair<string,List<string>> item in BlockNameMeasureValueDic)
            {
                cmb_BlockName.Items.Add(item.Key);//向算子名中添加算子
            }
            if (BlockNameMeasureValueDic.Count > 0 )//如果有键值对
            {
                if(_ifSwitchJudgeClass.BlockName != null && BlockNameMeasureValueDic.Keys.Contains(_ifSwitchJudgeClass.BlockName))//键值对集合中包含算子块名称
                {
                    cmb_BlockName.SelectedItem = _ifSwitchJudgeClass.BlockName;                
                }
                else
                {
                    cmb_BlockName.SelectedIndex = 0;
                }
                cmb_MeasureValue.DataSource = BlockNameMeasureValueDic[cmb_BlockName.SelectedItem.ToString()];
                if(_ifSwitchJudgeClass.MeasureValue != null && BlockNameMeasureValueDic[cmb_BlockName.SelectedItem.ToString()].Contains(_ifSwitchJudgeClass.MeasureValue))
                {
                    cmb_MeasureValue.SelectedItem = _ifSwitchJudgeClass.MeasureValue;
                }
                else
                {
                    cmb_MeasureValue.SelectedIndex = 0;
                }
            }
            switch(_ifSwitchJudgeClass.MeasureResult)
            {
                case "True":
                    rbtn_True.Checked = true;
                    break;
                case "Talse":
                    rbtn_False.Checked = true;
                    break;
                case "Invalid":
                    rbtn_Invalid.Checked = true;
                    break;
            }             
        }

        private void cmb_BlockName_DropDown(object sender, EventArgs e)//显示组合框的下拉部分时发生
        {
            if (cmb_BlockName.Items.Count == 0)
            {
                cmb_BlockName.DropDownHeight = 1;
            }
        }

        private void cmb_MeasureValue_DropDown(object sender, EventArgs e)//显示组合框的下拉部分时发生
        {
            if (cmb_MeasureValue.Items.Count == 0)
            {
                cmb_MeasureValue.DropDownHeight = 1;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if(cmb_BlockName.SelectedItem != null && cmb_MeasureValue.SelectedItem != null)
            {
                _ifSwitchJudgeClass.BlockName = cmb_BlockName.SelectedItem.ToString();
                _ifSwitchJudgeClass.MeasureValue = cmb_MeasureValue.SelectedItem.ToString();
            }
            if(rbtn_True.Checked)
            {
                _ifSwitchJudgeClass.MeasureResult = "True";//为真
            }
            else if(rbtn_False.Checked )
            {
                _ifSwitchJudgeClass.MeasureResult ="False";//为假
            }
            else if(rbtn_Invalid.Checked)
            {
                _ifSwitchJudgeClass.MeasureResult = "Invalid";//为无效
            }
            Close();
        }

        private void cmb_BlockName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_MeasureValue.DataSource = BlockNameMeasureValueDic[cmb_BlockName.SelectedItem.ToString()];
        }
    }
}
