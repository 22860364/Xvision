using DispenseAPP.AboutData;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;
using DispenseAPP.Tools_CommonClass;
using System;
using System.Drawing;
using DispenseAPP.MyStyleControl;

namespace DispenseAPP.Tools_Other.ReadWriteVar
{
    public partial class Tools_ReadWriteVar : MyUserControl
    {
        ReadWriteVarToolEntity _tools_ReadWriteVarClass;

        public Tools_ReadWriteVar(ReadWriteVarToolEntity tools_ReadWriteVarClass)
        {
            InitializeComponent();
            _tools_ReadWriteVarClass = tools_ReadWriteVarClass;
            InitialVarName();
            DG_VarName.TopLeftHeaderCell.Value = "行号";
            Txt_Name.Text = _tools_ReadWriteVarClass.StepCustomName;
            if (_tools_ReadWriteVarClass.FilePath != null)
            {
                Txt_Path.Text = _tools_ReadWriteVarClass.FilePath;
            }
            if (_tools_ReadWriteVarClass.Read)
            {
                Rbtn_Read.Checked = true;
            }
            if (_tools_ReadWriteVarClass.Write)
            {
                Rbtn_Write.Checked = true;
            }
        }

        void InitialVarName()//初始化表格 这个有个问题：项目文件中存在的变量但是该工具中可能不存在  
        {
            foreach (VarCollectionClass item in StaticPublicData.VariableData.varList)
            {
                if (_tools_ReadWriteVarClass.VarNameList.Contains(item.VarName))
                {
                    DG_VarName.Rows.Add(item.VarName, "true");
                }
                else
                {
                    DG_VarName.Rows.Add(item.VarName, "false");
                }
            }
        }

        void Btn_OK_Click(object sender, EventArgs e)
        {
            if (Tools_ClickOKButton.CheckBlockName(Txt_Name.Text.Trim(), _tools_ReadWriteVarClass.StepCustomName, _tools_ReadWriteVarClass.SelectedOperatorBlock.ToolList) == false)
            {
                return;
            }
            if (Txt_Path.Text == "")
            {
                MessageBox.Show("文件路径不能为空");
                return;
            }
            _tools_ReadWriteVarClass.StepCustomName = Txt_Name.Text;
            _tools_ReadWriteVarClass.Read = Rbtn_Read.Checked;
            _tools_ReadWriteVarClass.Write = Rbtn_Write.Checked;
            _tools_ReadWriteVarClass.FilePath = Txt_Path.Text;
            _tools_ReadWriteVarClass.VarNameList.Clear();
            foreach (DataGridViewRow item in DG_VarName.Rows)
            {
                if(Convert.ToBoolean(item.Cells[1].EditedFormattedValue.ToString()) == true)//如果选中则添加到变量名称的集合中
                {
                    _tools_ReadWriteVarClass.VarNameList.Add(item.Cells[0].EditedFormattedValue.ToString());
                }
            }
           base.ClickOk(_tools_ReadWriteVarClass);
        }

        void Btn_Cancel_Click(object sender, EventArgs e)
        {
            base.ClickCancel();
        }

        void Btn_Path_Click(object sender, EventArgs e)//选择路径
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.InitialDirectory = Application.StartupPath + "\\";
                openFile.Filter = "INI文件|*.ini";
                openFile.FilterIndex = 1;
                openFile.RestoreDirectory = false;
                openFile.CheckFileExists = false;
                openFile.Multiselect = false;
                openFile.Title = "选择文件";
                if (openFile.ShowDialog(null) == DialogResult.OK)
                {
                    Txt_Path.Text = openFile.FileName;
                }
            }
        }

        private void DG_VarName_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Draw_DGV_LineNumber(sender, e);
        }
    }
}
