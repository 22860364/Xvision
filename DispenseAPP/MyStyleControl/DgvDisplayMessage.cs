using System;
using System.Drawing;
using System.Windows.Forms;
using log4net;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.MyStyleControl
{
    public partial class DgvDisplayMessage : UserControl
    {

        private ILog _log = LogManager.GetLogger("运行信息");

        public DgvDisplayMessage()
        {
            InitializeComponent();
            dgvMessage.TopLeftHeaderCell.Value = "行号";
            dgvMessage.Columns[4].DefaultCellStyle.ForeColor = Color.Red;
            foreach (DataGridViewColumn item in dgvMessage.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public int Count => dgvMessage.Rows.Count;

        public void ClearMessage()//清除消息
        {
            dgvMessage.Rows.Clear();
        }

        public void AddMessage(Message message)
        {
            try
            {
                if (message != null)
                {
                    if (dgvMessage.Rows.Count >= 100)
                    {
                        dgvMessage.Rows.Clear();
                    }
                    Invoke(new Action(() =>
                    {
                        int rows = dgvMessage.Rows.Add(new string[] { message.Time, message.StepName, message.ToolName, message.RunMessage, message.ExceptionMessage });
                        dgvMessage.CurrentCell = dgvMessage[0, rows];
                    }), null);
                    _log.Info("算子块[" + message.StepName + "] 工具名[" + message.ToolName + "] 运行消息:" + message.RunMessage + "  " + "异常消息[" + message.ExceptionMessage + "]");
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// 显示行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvMessage_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Draw_DGV_LineNumber(sender, e);
        }
    }
}
