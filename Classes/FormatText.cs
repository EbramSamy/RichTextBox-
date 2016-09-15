using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace Test.Classes
{
    class FormatText
    {

        public static int textLength;
        public static void format(RichTextBox r)
        {

            Regex reg3 = new Regex(@"(@|#)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var start = r.Document.ContentStart;
            int matchIndex = -1;
            while (start != null && start.CompareTo(r.Document.ContentEnd) < 0)
            {
                var newLineIndex = -1;
                if (start.GetPointerContext(LogicalDirection.Forward) == TextPointerContext.Text)
                {

                    string text = new TextRange(start, r.Document.ContentEnd).Text;

                    var match3 = reg3.Match(text);
                    matchIndex = match3.Index;
                    var spaceIndex = -1;
                    spaceIndex = text.IndexOf(" ", match3.Index);
                    newLineIndex = text.IndexOf("\r\n\r\n", match3.Index);

                    if (match3.Index > 0 && spaceIndex > match3.Index && newLineIndex == -1)
                    {

                        int startIndex = match3.Index;
                        string s = text.Substring(startIndex + 1, 1);
                        while (text.Substring(startIndex + 1, 1).Equals("#") || (text.Substring(startIndex + 1, 1).Equals("@")))
                        {
                            var textrange1 = new TextRange(start.GetPositionAtOffset(startIndex, LogicalDirection.Forward), start.GetPositionAtOffset(startIndex, LogicalDirection.Backward));
                            textrange1.ApplyPropertyValue(TextElement.ForegroundProperty, new SolidColorBrush(Colors.Black));
                            textrange1.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
                            startIndex++;
                        }

                        var textrange = new TextRange(start.GetPositionAtOffset(startIndex, LogicalDirection.Forward), start.GetPositionAtOffset(spaceIndex, LogicalDirection.Backward));
                        textrange.ApplyPropertyValue(TextElement.ForegroundProperty, new SolidColorBrush(Colors.Blue));
                        textrange.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);

                    }
                    if (match3.Index > 0 && newLineIndex > match3.Index && spaceIndex == -1)
                    {
                        int startIndex = match3.Index;
                        string s = text.Substring(startIndex + 1, 1);
                        while (text.Substring(startIndex + 1, 1).Equals("#") || (text.Substring(startIndex + 1, 1).Equals("@")))
                        {
                            var textrange1 = new TextRange(start.GetPositionAtOffset(startIndex, LogicalDirection.Forward), start.GetPositionAtOffset(startIndex, LogicalDirection.Backward));
                            textrange1.ApplyPropertyValue(TextElement.ForegroundProperty, new SolidColorBrush(Colors.Black));
                            textrange1.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
                            startIndex++;
                        }
                        var textrange = new TextRange(start.GetPositionAtOffset(startIndex, LogicalDirection.Forward), start.GetPositionAtOffset(newLineIndex, LogicalDirection.Backward));
                        textrange.ApplyPropertyValue(TextElement.ForegroundProperty, new SolidColorBrush(Colors.Blue));
                        textrange.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);

                    }

                }

                start = start.GetNextContextPosition(LogicalDirection.Forward);
            }

            string richText = new TextRange(r.Document.ContentStart, r.Document.ContentEnd).Text;
            textLength = richText.Length;
        }
    }
}
