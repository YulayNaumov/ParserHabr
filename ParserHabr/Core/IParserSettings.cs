namespace ParserHabr.Habra
{
    public interface IParserSettings
    {
        string BaseUrl { get; set; }// url сайта 
        string Prefix { get; set; }// число от старта до конца
        int StartPoint { get; set; }// с какой страницы парсим сайт
        int EndPoint { get; set; }// по какую страниц парсим
    }
}