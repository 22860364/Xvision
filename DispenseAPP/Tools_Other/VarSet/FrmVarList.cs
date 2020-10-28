using DispenseAPP.AboutData;
using DispenseAPP.CustomControl;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DispenseAPP.OtherTools.VariableSetTools
{
    public partial class FrmVarList : FormM
    {
        public event ClickOKDelegate ClickOkEvent;
        public static bool EditState { get; set; }

        private ProjectParamClass _projectParam;

        int row_Index = -1;

        public FrmVarList(ProjectParamClass projectParam)
        {
            InitializeComponent();
            _projectParam = projectParam;
            BindingDG_VarList();
        }

        private void BindingDG_VarList()//进入该界面时  绑定List<T>
        {
            DG_VarList.DataSource = new BindingList<VarCollectionClass>(_projectParam.Vars.varList);
            if (_projectParam.Vars.varList.Count > 0)
            {
                DG_VarList.CurrentCell = DG_VarList[0, 0];
                row_Index = 0;
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)//添加变量
        {
            VarCollectionClass varCollection = new VarCollectionClass();
            for (int i = 1; i < int.MaxValue; i++)
            {
                if (!_projectParam.Vars.ContainsProperty("var_" + i.ToString()))//如果包含
                {
                    varCollection.VarName = "var_" + i.ToString();
                    break;
                }
            }
            varCollection.VarType = "N";
            varCollection.VarValue = 0;
            OperationVar(varCollection);
        }

        private void OperationVar(VarCollectionClass varCollectionClass)//操作变量
        {
            FrmAddEditVar frmAdd_EditVariable = new FrmAddEditVar(varCollectionClass);
            if (EditState == true)
            {
                frmAdd_EditVariable.Text = "编辑变量";
            }
            else
            {
                frmAdd_EditVariable.Text = "添加变量";
            }
            frmAdd_EditVariable._clickOKEvent += FrmAdd_EditVariable__clickOKEvent;
            frmAdd_EditVariable.ShowDialog();
        }

        private void FrmAdd_EditVariable__clickOKEvent(object anyType)
        {
            if (EditState == false)
            {
                VarCollectionClass varCollection = (VarCollectionClass)(anyType as VarCollectionClass).Clone();
                _projectParam.Vars.Property = varCollection;
            }
            DG_VarList.DataSource = new BindingList<VarCollectionClass>(_projectParam.Vars.varList);
            if (EditState == true)
            {
                EditState = false;
                DG_VarList.CurrentCell = DG_VarList.Rows[row_Index].Cells[0];
            }
            else
            {
                DG_VarList.CurrentCell = DG_VarList.Rows[DG_VarList.Rows.Count - 1].Cells[0];
            }
        }


        private void Btn_Delete_Click(object sender, EventArgs e)//删除变量
        {
            if (row_Index >= 0)
            {
                _projectParam.Vars.DeleteProperty(_projectParam.Vars.varList[row_Index].VarName);
            }
        }


        private void Btn_OK_Click(object sender, EventArgs e)//确定 点击确定后要通知VarSet窗体重新绑定
        {
            ClickOkEvent();
            Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)//取消
        {
            Close();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            EditState = true;
            if (row_Index >= 0)
            {
                OperationVar(_projectParam.Vars.varList[row_Index]);
            }
        }

        private void DG_VarList_CellClick(object sender, DataGridViewCellEventArgs e)//单击单元格的任意部分时发生
        {
            row_Index = e.RowIndex;
        }


        private void DG_VarList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//双击单元格的任意部分时发生 编辑
        {
            EditState = true;
            if (e.RowIndex >= 0)
            {
                OperationVar(_projectParam.Vars.varList[e.RowIndex]);
            }
        }
    }
}
