using HalconDotNet;
using System;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;
using System.IO;

namespace DispenseAPP.Tools_Image_IO.ImportImage
{
    public partial class Tools_ImportImage : UserControl,IEvent 
    {
        public Tools_ImportImage(ImportImageClass importImageClass)
        {
            InitializeComponent();
            _importImageClass = importImageClass;
            Txt_Name.Text = _importImageClass.BlockName;
            txt_Path.Text = _importImageClass.imagePath;
            Cb_CycleLoad.Checked = _importImageClass.CycleLoading;
            Cb_ImageBackup.Checked = _importImageClass.ImageBackup;
        }

        private ImportImageClass _importImageClass;
        public event ClickCancelDelegate _clickCancelButton;
        public event ClickOKButtonDelegate _clickOKButton;

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (Txt_Name.Text == "")
            {
                MessageBox.Show("请输入算子名", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            if(! (_importImageClass.BlockName != "" && _importImageClass.BlockName == Txt_Name.Text))
            {
                if (_importImageClass.SelectedNormalBlock.ToolsList.Find(c => c.BlockName == Txt_Name.Text) != null)
                {
                    MessageBox.Show("该算子名已经被使用！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
            }          
            if(txt_Path.Text == "")
            {
                MessageBox.Show("请选择图像路径，路径不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            _importImageClass.BlockName = Txt_Name.Text;
            _importImageClass.imagePath = txt_Path.Text;
            _importImageClass.CycleLoading = Cb_CycleLoad.Checked;
            _importImageClass.ImageBackup = Cb_ImageBackup.Checked;
            _clickOKButton(_importImageClass);
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            _clickCancelButton();
        }

        private void Btn_Path_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.InitialDirectory = Application.StartupPath + "\\Image\\";
                openFile.Filter = "图像文件|*.png;*.bmp;*.jpg;*.tif";
                openFile.FilterIndex = 1;
                openFile.RestoreDirectory = false;
                openFile.CheckFileExists = true;
                openFile.Multiselect = false;
                openFile.Title = "打开图像";
                if(openFile.ShowDialog(null) == DialogResult.OK)
                {
                    txt_Path.Text = openFile.FileName;
                    HImage image = new HImage();
                    image.ReadImage(txt_Path.Text);
                    WindowIndexDic[CurrentWindowIndex].hobjectList.Clear();
                    WindowIndexDic[CurrentWindowIndex].DispImage(image,true);
                    image.Dispose();
                }
            }
        }
    }
}
