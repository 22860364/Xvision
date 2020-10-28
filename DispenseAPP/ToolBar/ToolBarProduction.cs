using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;
using DispenseAPP.FlowChart.BlockClass;
using System.Threading;
using DispenseAPP.UserManagement;
using DispenseAPP.MyStyleControl;
using System.Collections.Generic;
using CameraLibrary;
using System.Threading.Tasks;

namespace DispenseAPP.ToolBar
{
    public partial class ToolBarProduction : UserControl
    {
        FrmPrimary _frmPrimary = null;

        public ToolBarProduction(FrmPrimary frmPrimary)
        {
            InitializeComponent();
            _frmPrimary = frmPrimary;
            Tscb_AutoPhoto.HasChecked = StaticPublicData.SystemData.EnableAutoPhoto;//自动拍照
            Tscb_CCDObserveMode.HasChecked = StaticPublicData.SystemData.EnableCCDObserveMode;//CCD观察模式
            Tscb_EnableRubble.HasChecked = StaticPublicData.SystemData.EnableRubble;//启用胶阀
        }

        #region Button（Start Stop Reset）
        private void Tsbtn_Reset_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                _frmPrimary.SetControlEnableInRunMode(false);
                BlockItem element = StaticPublicData.BlockItems[NameType.CustomName, "回零"];
                while (true)
                {
                    if (element != null)
                    {
                        element = element.Execute();
                    }
                    else
                    {
                        break;
                    }
                }
                _frmPrimary.SetControlEnableInRunMode(true);
            });
        }

        public void SetControlCheckBox()
        {
            Tscb_AutoPhoto.HasChecked = StaticPublicData.SystemData.EnableAutoPhoto;
            Tscb_CCDObserveMode.HasChecked = StaticPublicData.SystemData.EnableCCDObserveMode;
            Tscb_EnableRubble.HasChecked = StaticPublicData.SystemData.EnableRubble;
        }

        /// <summary>
        /// 点击启动按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tbtn_Start_Click(object sender, EventArgs e)
        {
            if (ExecuteToolAgoCheck() && !isExpried)
            {
                _frmPrimary.SetControlEnableInRunMode(false);
                IsRunState = true;//代表自动运行
                foreach (KeyValuePair<int, DgvDisplayMessage> item in MessageWindowIndexDic)
                {
                    item.Value.ClearMessage();
                }
                BlockItem element = StaticPublicData.LineItems.Find(c => c.StartBlock is StartBlock startBlock && c.StartArrow == startBlock.ArrowList[0]).EndBlock;
                ThreadExecute threadExecute = new ThreadExecute();
                Thread thread = new Thread(threadExecute.Execute);
                FrmPrimary.BThreadList.Add(thread);
                threadExecute.CurrentThread = thread;
                thread.IsBackground = true;
                thread.Start(element);
            }
        }

        //1.正在执行手动流程 也就是BGW_Manual在运行 点击停止会发生什么 需要测试 
        //2.正在执行自动流程 停止自动线程
        private void Tsbtn_Stop_Click(object sender, EventArgs e)
        {
            Tsbtn_Stop.Enabled = false;
            foreach (Thread item in FrmPrimary.BThreadList)
            {
                item.Abort();
            }
            foreach (ICamerable item in CameraIDObjectDict.Values)
            {
                if (item.ConnectState)
                {
                    item.StopAcquisition();
                }
            }
            FrmPrimary.BThreadList.Clear();
            if (IsRunState)
            {
                IsRunState = false;
            }
            _frmPrimary.SetControlEnableInRunMode(true);
            Tsbtn_Stop.Enabled = true;
        }
        #endregion

        /// <summary>
        /// 产量清零
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtn_SetZero_Click(object sender, EventArgs e)
        {
            StaticPublicData.SystemData.Yield = 0;
        }

        /// <summary>
        /// 运行前检查
        /// </summary>
        /// <returns></returns>
        public bool ExecuteToolAgoCheck()
        {
            MessageWindowIndexDic[0].ClearMessage();
            foreach (BlockItem item in StaticPublicData.BlockItems)
            {
                if (item is OperatorBlock operatorBlock)
                {
                    foreach (IToolable items in operatorBlock.ToolList)
                    {
                        items.RunAgoCheck();
                        foreach (string itemss in items.ErrorList)
                        {
                            MessageWindowIndexDic[0].AddMessage(new Message(DateTime.Now.ToLongTimeString().ToString(), items.SelectedOperatorBlock.CustomName, items.StepCustomName, "", itemss));
                        }
                    }
                }
            }
            return MessageWindowIndexDic[0].Count == 0 ? true : false;
        }

        #region about switch form
        private void Tsbtn_Frm_Run_Click(object sender, EventArgs e)//运行界面
        {
            _frmPrimary.SwitchToRun();
            Tsbtn_Frm_FlowChart.Visible = true;
            Tsbtn_Frm_Run.Visible = false;
        }

        private void Tsbtn_Frm_FlowChart_Click(object sender, EventArgs e)//流程图界面
        {
            _frmPrimary.SwitchToWorkFlowChart();
            Tsbtn_Frm_Run.Visible = true;
            Tsbtn_Frm_FlowChart.Visible = false;
        }
        #endregion

        public void SetControlEnableInRunMode(bool enable)
        {
            foreach (ToolStripItem item in tsrProduction.Items)
            {
                item.Enabled = enable;
            }
            Tsbtn_Stop.Enabled = true;
            Tsbtn_SetZero.Enabled = true;
            Tsbtn_Frm_Run.Enabled = true;
            Tsbtn_Frm_FlowChart.Enabled = true;
        }

        public void SetPurviewControl()
        {
            if (CurrentUser != null && CurrentUser.PurviewList.Find(c => c.PurviewTypeName == "显示") is DisplayPurview displayPurview && displayPurview != null)
            {
                Tsbtn_Frm_Run.Visible = false;
                SetControlVisible(displayPurview.显示流程图界面);
            }
            else
            {
                Tsbtn_Frm_Run.Visible = false;
                SetControlVisible(false);
            }
        }

        void SetControlVisible(bool visible)
        {
            Tsbtn_Frm_FlowChart.Visible = visible;
            Tslbl_SwitchFrm.Visible = visible;
            Tss_SwitchForm.Visible = visible;
        }

        private void Tscb_EnableRubble_Click(object sender, EventArgs e)
        {
            StaticPublicData.SystemData.EnableRubble = Tscb_EnableRubble.HasChecked;
        }

        private void Tscb_CCDObserveMode_Click(object sender, EventArgs e)
        {
            StaticPublicData.SystemData.EnableCCDObserveMode = Tscb_CCDObserveMode.HasChecked;
        }

        private void Tscb_AutoPhoto_Click(object sender, EventArgs e)
        {
            StaticPublicData.SystemData.EnableAutoPhoto = Tscb_AutoPhoto.HasChecked;
        }
    }
}
