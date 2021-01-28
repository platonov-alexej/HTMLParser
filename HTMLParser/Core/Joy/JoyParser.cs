using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLParser.Core.Joy
{
    class JoyParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            var list = new List<string>();
            var items = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("b-news-list__title"));
            
            foreach(var item in items)
            {
                list.Add(item.TextContent);
            }
            return list.ToArray();
        }
    }
}
