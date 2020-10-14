using System.Windows.Forms.VisualStyles;

namespace ParserHabr.Habra
{
    public class HabraSettings: IParserSettings
    {
        
        public string BaseUrl { get; set; } = "https://habr.com/ru/";
        public string Prefix { get; set; } = "page{CurrentId}";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
        
        
        public HabraSettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }

       
    }
}