using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Folding;
using System.Collections.Generic;

namespace DispenseAPP.Tools_Other.Script.CodeFolding
{
    public class BraceFoldingStrategy
    {
        public BraceFoldingStrategy()
        {
            OpeingBrace = '{';
            ClosingBrace = '}';
        }

        public char OpeingBrace { get; set; }

        public char ClosingBrace { get; set; }

        public void UpdateFolding(FoldingManager manager, TextDocument document)//更新折叠
        {
            IEnumerable<NewFolding> newFoldings = CreateNewFoldings(document, out int firstErrorOffset);
            //manager.UpdateFoldings(newFoldings, firstErrorOffset);  这里报错  需要解决 
        }

        public IEnumerable<NewFolding> CreateNewFoldings(TextDocument document, out int firstErrorOffset)
        {
            firstErrorOffset = -1;
            return CreateNewFoldings(document);
        }

        public IEnumerable<NewFolding> CreateNewFoldings(ITextSource document)
        {
            List<NewFolding> newFoldings = new List<NewFolding>();
            Stack<int> startOffsets = new Stack<int>();//表示大小可变后进先出的集合
            int lastNewLineOffset = 0;
            char openingBrace = OpeingBrace;
            char closingBrace = ClosingBrace;
            for (int i = 0; i < document.TextLength; i++)
            {
                char c = document.GetCharAt(i);//获得i处的字符
                if (c == openingBrace)
                {
                    startOffsets.Push(i);
                }
                else if (c == closingBrace && startOffsets.Count > 0)
                {
                    int startOffset = startOffsets.Pop();
                    if (startOffset < lastNewLineOffset)//如果开括号和闭括号在同一条线上，不要折叠
                    {
                        newFoldings.Add(new NewFolding(startOffset, i + 1));
                    }
                }
                else if (c == '\r' || c == '\n')
                {
                    lastNewLineOffset = i + 1;
                }//如果有回车或者换行 则+1
            }
            return newFoldings;
        }
    }
}
