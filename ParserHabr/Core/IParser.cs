using AngleSharp.Html.Dom;

namespace ParserHabr.Habra
{
    public interface IParser<T> where T: class
    {
        T Parse(IHtmlDocument document);
    }
}