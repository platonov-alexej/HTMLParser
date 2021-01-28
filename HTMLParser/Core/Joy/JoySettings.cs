
namespace HTMLParser.Core.Joy
{
    class JoySettings : IParserSettings
    {
        public JoySettings (int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }
        public string BaseURL { get; set; } = "https://www.f1news.ru";
        public string Prefix { get; set; } = "{currentId}";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
    }
}
