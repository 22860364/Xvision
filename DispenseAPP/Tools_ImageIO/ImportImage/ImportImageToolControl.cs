using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DispenseAPP.MyStyleControl;

namespace DispenseAPP.Tools_ImageIO.ImportImage
{
    public partial class ImportImageToolControl : UserControlTool
    {
        /// <summary>
        /// 导入图像工具对象
        /// </summary>
        ImportImageToolEntity ImportImageEntity { get; set; } = null;

        public ImportImageToolControl(ImportImageToolEntity importImageEntity)
        {
            InitializeComponent();
            ImportImageEntity = importImageEntity;
            txtName.Text = ImportImageEntity.StepCustomName;
            txtPath.Text = ImportImageEntity.ImagePath;
            chkCycleLoad.Checked = ImportImageEntity.CycleLoad;
        }

        /// <summary>
        /// 选择路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.InitialDirectory = Application.StartupPath + "\\Image\\";
                openFile.Filter = "图像文件|*.bmp;";
                openFile.FilterIndex = 1;
                openFile.RestoreDirectory = false;
                openFile.CheckFileExists = true;
                openFile.Multiselect = false;
                openFile.Title = "打开图像";
                if (openFile.ShowDialog(null) == DialogResult.OK)
                {
                    txtPath.Text = openFile.FileName;
                }
            }
        }

        protected override bool ClickOKCheck(string stepName, List<IToolable> toolableList)
        {
            if(!base.ClickOKCheck(stepName, toolableList))
            {
                return false;
            }
            if(string.IsNullOrWhiteSpace(txtPath.Text))
            {
                MessageBox.Show("图像路径不能为空！");
                return false;
            }
            return true;
        }

        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            if(!ClickOKCheck(ImportImageEntity.StepCustomName, ImportImageEntity.SelectedOperatorBlock.ToolList))
            {
                return;
            }
            ImportImageEntity.StepCustomName = txtName.Text.Trim();
            ImportImageEntity.ImagePath = txtPath.Text.Trim();
            ImportImageEntity.CycleLoad = chkCycleLoad.Checked;
            ExecuteClickOkEvent(ImportImageEntity);
        }       
    }
}
