using DispenseAPP.AboutData;
using DispenseAPP.CustomControl;
using DispenseAPP.Tools_Other.Script.CodeFolding;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.CodeCompletion;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Editing;
using ICSharpCode.AvalonEdit.Folding;
using ICSharpCode.AvalonEdit.Highlighting;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Media;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.Tools_Other.Script
{
    public partial class FrmScript : FormM
    {
        private Tools_ScriptClass _tools_ScriptClass;
        private List<string> varNameList = new List<string>();
        private Dictionary<string, List<BlockNameValue>> referenceData = new Dictionary<string, List<BlockNameValue>>();

        public FrmScript(Tools_ScriptClass tools_ScriptClass)
        {
            InitializeComponent();
            InitialScriptControl();
            _tools_ScriptClass = tools_ScriptClass;
            InitialHelper.LogicOperationInitialReference(_tools_ScriptClass.SelectedOperatorBlock.ToolList, Lb_BlockName, referenceData, _tools_ScriptClass.SelectedOperatorBlock.LastIndex, false);
            foreach (VarCollectionClass item in StaticPublicData.VariableData.varList)//遍历所有变量的名称添加到List中
            {
                varNameList.Add(item.VarName);
            }
        }

        private TextEditor textEditor = new TextEditor();
        public static FoldingManager foldingManager;
        CompletionWindow completionWindow;
        private BraceFoldingStrategy foldingStrategy = null;

        private void InitialScriptControl()
        {
            textEditor.ShowLineNumbers = true;//显示行号
            textEditor.Padding = new System.Windows.Thickness(10);//设置空白
            textEditor.FontFamily = new FontFamily("Console");//设置字体
            textEditor.FontSize = 14;
            textEditor.SyntaxHighlighting = HighlightingManager.Instance.GetDefinition("C#");
            textEditor.Encoding = Encoding.Default;
            elementHost_TextEditor.Child = textEditor;
            textEditor.TextArea.TextEntering += TextArea_TextEntering;
            textEditor.TextArea.TextEntered += TextArea_TextEntered;
            textEditor.TextChanged += TextEditor_TextChanged;
            InitFoldStrategy();
        }

        #region 代码折叠
        private void TextEditor_TextChanged(object sender, EventArgs e)
        {
            RefreshFoldStrategy();
        }

        private void RefreshFoldStrategy()
        {
            if (foldingStrategy != null)
            {
                if (foldingManager == null)
                {
                    foldingManager = FoldingManager.Install(textEditor.TextArea);
                }
                foldingStrategy.UpdateFolding(foldingManager, textEditor.Document);
            }
            else
            {
                if (foldingManager != null)
                {
                    foldingManager = FoldingManager.Install(textEditor.TextArea);
                    foldingManager = null;
                }
            }
        }

        private void InitFoldStrategy()//初始化代码折叠
        {
            textEditor.TextArea.IndentationStrategy = new ICSharpCode.AvalonEdit.Indentation.CSharp.CSharpIndentationStrategy(textEditor.Options);
            foldingStrategy = new BraceFoldingStrategy();
        }
        #endregion

        private string AnalysisScriptTextValue()//解析字符串
        {
            string text = textEditor.Text;       
            object value = null;
            foreach (string item in referenceData.Keys)//遍历所有的工具名
            {
                foreach (BlockNameValue items in referenceData[item])//分为两大类 数组和非数组
                {
                    if (item == "Vars") { continue; }
                    IToolable tools = _tools_ScriptClass.SelectedOperatorBlock.ToolList.Find(c => c.StepCustomName == item);
                    PropertyInfo proInfo = tools.GetType().GetProperty(items.Name);
                    object obj = proInfo.GetValue(tools, null);
                    if (obj != null)
                    {
                        if (obj is Array)
                        {
                            if(obj is System.Drawing.PointF[] pointArray)
                            {

                            }
                        }
                        else
                        {
                            if (textEditor.Text.Contains(item + "." + items.Name + ".X"))//PointF类型
                            {

                            }
                            else if (textEditor.Text.Contains(item + "." + items.Name + ".Y"))
                            {

                            }
                            else if (textEditor.Text.Contains(item + "." + items.Name))//代表是 N-整型 S-字符串 B-布尔 P-点位
                            {
                                value = proInfo.GetValue(_tools_ScriptClass.SelectedOperatorBlock.ToolList.Find(c => c.StepCustomName == item)).ToString();
                                switch (proInfo.PropertyType.ToString())
                                {
                                    case "System.Boolean": //如果是布尔类型 需要转换为小写
                                        value = value.ToString().ToLower();
                                        break;
                                    case "System.Drawing.PointF[]":

                                        break;
                                }
                                //text = textEditor.Text.Replace(item + "." + items.Name, value.ToString());
                            }
                        }
                    }
                }
            }
            return text;
        }

        private void TextArea_TextEntered(object sender, System.Windows.Input.TextCompositionEventArgs e)//当.前面是Vars 则出现智能提示
        {
            if (e.Text == ".")
            {
                int index = textEditor.SelectionStart;//选定文本的起始位置
                if (index - 5 < 0)//代表输入的字符比Vars.的个数少
                {
                    return;
                }
                else if (index - 5 == 0)
                {
                    if (textEditor.Document.GetText(0, 4) != "Vars")
                    {
                        return;
                    }
                }
                else
                {
                    if (textEditor.Document.GetText(index - 6, 5) != " Vars")
                    {
                        return;
                    }
                }
                completionWindow = new CompletionWindow(textEditor.TextArea);
                IList<ICompletionData> data = completionWindow.CompletionList.CompletionData;
                foreach (string item in varNameList)
                {
                    data.Add(new MyCompletionData(item));
                }
                completionWindow.Show();
                completionWindow.Closed += delegate { completionWindow = null; };
            }
        }

        private void TextArea_TextEntering(object sender, System.Windows.Input.TextCompositionEventArgs e)//当输入时
        {
            if (e.Text.Length > 0 && completionWindow != null)
            {
                if (!char.IsLetterOrDigit(e.Text[0]))
                {
                    completionWindow.CompletionList.RequestInsertion(e);
                }
            }
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Compile_Click(object sender, EventArgs e)//编译
        {
            Txt_ErrorMessage.Clear();
            string scriptText = textEditor.Text;
            _tools_ScriptClass.ExecuteCompile(AnalysisScriptTextValue(), false, out string[] errorArray);
            foreach (string item in errorArray)
            {
                Txt_ErrorMessage.AppendText(item + "\r\n");
            }
        }

        private void Btn_Run_Click(object sender, EventArgs e)//运行脚本
        {
            Txt_ErrorMessage.Clear();
            string scriptText = textEditor.Text;
            _tools_ScriptClass.ExecuteCompile(AnalysisScriptTextValue(), true, out string[] errorArray);
            foreach (string item in errorArray)
            {
                Txt_ErrorMessage.AppendText(item + "\r\n");
            }
        }

        private void Lb_BlockName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lb_BlockName.SelectedItem != null)
            {
                DG_Var.DataSource = referenceData[Lb_BlockName.SelectedItem.ToString()];
                for (int i = 0; i < DG_Var.ColumnCount; i++)
                {
                    DG_Var.Columns[i].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
                    DG_Var.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                DG_Var.Columns[0].FillWeight = 35;
                DG_Var.Columns[1].FillWeight = 70;
                DG_Var.Columns[2].FillWeight = 100;
            }
        }

        private void DG_Var_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)//双击单元格的任意位置时  添加到代码编辑区
        {
            textEditor.AppendText(Lb_BlockName.SelectedItem.ToString() + "." + DG_Var.Rows[e.RowIndex].Cells[1].Value.ToString());
        }
    }
    public class MyCompletionData : ICompletionData
    {
        public MyCompletionData(string text)
        {
            Text = text;
        }

        public ImageSource Image
        {
            get
            {
                return null;
            }
        }

        public string Text { get; private set; }

        public object Content
        {
            get
            {
                return Text;
            }
        }


        public object Description
        {
            get
            {
                return "Description for " + this.Text;
            }
        }


        public double Priority => throw new NotImplementedException();

        public void Complete(TextArea textArea, ISegment completionSegment, EventArgs insertionRequestEventArgs)
        {
            textArea.Document.Replace(completionSegment, this.Text);
        }
    }
}
