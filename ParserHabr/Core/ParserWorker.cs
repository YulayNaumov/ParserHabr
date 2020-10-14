using System;
using System.Threading.Tasks;
using AngleSharp.Browser;
using AngleSharp.Html.Parser;

namespace ParserHabr.Habra
{
    public class ParserWorker<T> where T: class
    {
        private IParser<T> parser;
        private IParserSettings parserSettings;
        private HtmlLoader loader;

        private bool isActive;
        
        public event Action<object, T> OnNewData;
        public event Action<object> OnCompleted;
        
        #region Properties

        
        
        public IParser<T> Parser
        {
            get
            {
                return parser;
            }

            set
            {
                parser = value;
            }
        }

        public IParserSettings Settings
        {
            get
            {
                return parserSettings;
            }

            set
            {
                parserSettings = value;
                loader = new HtmlLoader(value);
            }
        }

        public bool IsActive
        {
            get => isActive;
            set => isActive = value;
        }

        #endregion


        public ParserWorker(IParser<T> parser)
        {
            this.parser = parser;
        }

        public ParserWorker(IParser<T> parser, IParserSettings parserSettings) : this(parser)
        {
            this.parserSettings = parserSettings;
        }

        public void Start()
        {
            isActive = true;
            Worker();
        }

        public void Abort()
        {
            isActive = false;
        }

        private async void Worker()
        {
            for (int i = parserSettings.StartPoint; i <= parserSettings.EndPoint; i++)
            {
                if (!isActive)
                {
                    OnCompleted?.Invoke(this);
                    return;
                }

                var source = await loader.GetSourceByPageId(i);
                var domParser = new  HtmlParser();

                var document = await domParser.ParseDocumentAsync(source);

                var result = parser.Parse(document);
                
                OnNewData?.Invoke(this, result);
            }
        }
        
    }
}