using DispenseAPP.AboutData;
using DispenseAPP.CustomControl;
using System.ComponentModel;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.Tools_Other.VarSet
{
    public partial class FrmVarRealTimeValue : FormM
    {
        public FrmVarRealTimeValue()
        {
            InitializeComponent();
            DG_VarList.AutoGenerateColumns = false;//不自动生成列
            DG_VarList.DataSource = new BindingList<VarCollectionClass>(StaticPublicData.VariableData.varList);
        }
    }
}
