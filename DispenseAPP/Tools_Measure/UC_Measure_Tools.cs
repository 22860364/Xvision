using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DispenseAPP.Tools_Measure.GeometricalRelation;

namespace DispenseAPP.Tools_Measure
{
    public partial class UC_Measure_Tools : UserControl
    {
        public event ClickToolsDelegate ClickToolsEvent;

        public UC_Measure_Tools()
        {
            InitializeComponent();
        }

        private void Lbl_GeometricalRelation_Click(object sender, EventArgs e)//几何关系
        {
            ClickToolsEvent(ToolsNameEnum.GeometericalRelation, new GeometericalRelationClass());
        }

        private void Lbl_CaliperMeasure_Click(object sender, EventArgs e)//卡尺测量
        {

        }
    }
}
