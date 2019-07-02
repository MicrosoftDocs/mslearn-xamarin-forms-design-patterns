using System;
using GreatQuotes.Data;

namespace GreatQuotes.ViewModels {
    public class GreatQuoteViewModel : BaseViewModel {

        private string _author;
        private string _quoteText;

        public GreatQuoteViewModel() 
            : this(new GreatQuote()) {
        }

        public GreatQuoteViewModel(GreatQuote copy) {
            this.QuoteText = copy.QuoteText;
            this.Author = copy.Author;
        }

        public string Author {
            get => _author; 
            set => SetPropertyValue(ref _author, value);
        }

        public string QuoteText {
            get => _quoteText;
            set => SetPropertyValue(ref _quoteText, value);
        }
    }
}
