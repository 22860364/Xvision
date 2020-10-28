using DispenseAPP.CustomControl;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Highlighting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DispenseAPP.Tools_Other.Script
{
    public partial class FrmScript : FormM
    {
        public FrmScript()
        {
            InitializeComponent();
            InitialScriptControl();
        }

        private TextEditor textEditor = new TextEditor();

        private void InitialScriptControl()
        {
            textEditor.ShowLineNumbers = true;//显示行号
            textEditor.Padding = new System.Windows.Thickness(20);//设置空白
            textEditor.FontFamily = new System.Windows.Media.FontFamily("Console");//设置字体
            textEditor.FontSize = 14;
            textEditor.SyntaxHighlighting = HighlightingManager.Instance.GetDefinition("C#");
            textEditor.Encoding = Encoding.Default;
            elementHost_TextEditor.Child = textEditor;
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Compile_Click(object sender, EventArgs e)
        {

        }
    }
}
