namespace GreatQuotes.Data {
    public class GreatQuote {
        private string _author;
        private string _quoteText;

        public string Author {
            get { return _author; }
            set { _author = value; }
        }

        public string QuoteText {
            get { return _quoteText; }
            set { _quoteText = value; }
        }

        public GreatQuote() : this("Unknown", "Quote goes here..") {
        }

        public GreatQuote(GreatQuote copy) {
            this.QuoteText = copy.QuoteText;
            this.Author = copy.Author;
        }

        public GreatQuote(string author, string quoteText) {
            Author = author;
            QuoteText = quoteText;
        }
    }
}