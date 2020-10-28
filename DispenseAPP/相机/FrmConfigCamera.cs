using DispenseAPP.AboutData;
using DispenseAPP.CustomControl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    public partial class FrmConfigCamera : FormM
    {
        public FrmConfigCamera(List<CameraDataClass> cameraDataList)
        {
            InitializeComponent();
            _cameraDataList = cameraDataList;
            Initial_DG_Camera();
        }

        private List<CameraDataClass> _cameraDataList;

        private void Initial_DG_Camera()
        {
            foreach (string item in CameraIDObjectDict.Keys)
            {
                int index = DG_Camera.Rows.Add();
                CameraDataClass cameraData = _cameraDataList.Find(c => c.CameraID == item);
                if (cameraData == null)//如果本地存储的相机数据中不包含当前相机
                {
                    DG_Camera.Rows[index].Cells[0].Value = item;
                    DG_Camera.Rows[index].Cells[1].Value = item.Split(':')[1];
                    DG_Camera.Rows[index].Cells[2].Value = true;
                }
                else
                {
                    DG_Camera.Rows[index].Cells[0].Value = cameraData.CameraID;
                    DG_Camera.Rows[index].Cells[1].Value = cameraData.CustomName;
                    DG_Camera.Rows[index].Cells[2].Value = cameraData.AutoConnect;
                }
            }
        }

        private void DG_Camera_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)//行级绘制时发生
        {
            Rectangle rct = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, DG_Camera.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), DG_Camera.RowHeadersDefaultCellStyle.Font, rct, DG_Camera.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DG_Camera.Rows.Count; i++)//遍历行
            {
                _cameraDataList[i].CustomName = DG_Camera.Rows[i].Cells[1].EditedFormattedValue.ToString();
                _cameraDataList[i].AutoConnect = Convert.ToBoolean(DG_Camera.Rows[i].Cells[2].EditedFormattedValue.ToString());
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
