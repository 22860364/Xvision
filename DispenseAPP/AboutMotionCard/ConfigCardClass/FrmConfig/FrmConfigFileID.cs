using DispenseAPP.CustomControl;
using System.Windows.Forms;

namespace DispenseAPP.AboutMotionCard.ConfigCardClass.GTS
{
    public partial class FrmConfigFileAndID : FormM
    {
        private ConfigFileIDClass _configGTSCardClass;
        private string configExtension;//配置文件扩展名

        public FrmConfigFileAndID(ConfigFileIDClass configGTSCardClass,string extension)
        {
            InitializeComponent();
            if(configGTSCardClass != null)
            {
                Num_CardNum.Value = configGTSCardClass.CardID;
                txt_Path.Text = configGTSCardClass.ConfigFilePath;
            }
            configExtension = extension;
            _configGTSCardClass = configGTSCardClass;
        }

        private void Btn_Load_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.InitialDirectory = Application.StartupPath;
                openFile.Filter = configExtension;
                openFile.CheckFileExists = true;
                openFile.Multiselect = false;//不允许多选
                openFile.RestoreDirectory = false;
                if(openFile.ShowDialog(null) == DialogResult.OK)
                {
                    txt_Path.Text = openFile.FileName;
                }
            }
        }

        private void Btn_OK_Click(object sender, System.EventArgs e)
        {
            if(txt_Path.Text != null && txt_Path.Text != "")
            {
                _configGTSCardClass.CardID = (short)Num_CardNum.Value;
                _configGTSCardClass.ConfigFilePath = txt_Path.Text;
                Close();
            }
            else
            {
                MessageBox.Show("配置文件路径不能为空！");
            }
        }

        private void Btn_Cancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
