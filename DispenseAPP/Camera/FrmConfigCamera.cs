using DispenseAPP.AboutData;
using DispenseAPP.CustomControl;
using System;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    public partial class FrmConfigCamera : FormM
    {
        public FrmConfigCamera()
        {
            InitializeComponent();
            Initialdgv();
        }

        private void Initialdgv()
        {
            foreach (string item in CameraIDObjectDict.Keys)
            {
                int index = dgvCamera.Rows.Add();
                CameraDataItem cameraData = StaticPublicData.CameraDataItems[item];
                if (cameraData == null)//如果本地存储的相机数据中不包含当前相机
                {
                    dgvCamera.Rows[index].Cells[0].Value = item;
                    dgvCamera.Rows[index].Cells[1].Value = item.Split(':')[1];
                    dgvCamera.Rows[index].Cells[2].Value = true;
                }
                else
                {
                    dgvCamera.Rows[index].Cells[0].Value = cameraData.SystemName;
                    dgvCamera.Rows[index].Cells[1].Value = cameraData.CustomName;
                    dgvCamera.Rows[index].Cells[2].Value = cameraData.AutoConnect;
                }
            }
            foreach (CameraDataItem item in StaticPublicData.CameraDataItems)
            {

            }
        }

        private void DG_Camera_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)//行级绘制时发生
        {
            Draw_DGV_LineNumber(sender, e);
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            CameraDataItem camera = null;
            for (int i = 0; i < dgvCamera.Rows.Count; i++)//遍历行
            {
                camera = StaticPublicData.CameraDataItems[dgvCamera.Rows[i].Cells[0].EditedFormattedValue.ToString()];
                camera.CustomName = dgvCamera.Rows[i].Cells[1].EditedFormattedValue.ToString();
                camera.AutoConnect = Convert.ToBoolean(dgvCamera.Rows[i].Cells[2].EditedFormattedValue.ToString());
            }
            ProjectIsChange = true;
            Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
