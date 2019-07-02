using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GreatQuotes.ViewModels;

namespace GreatQuotes.Data {
    public class QuoteManager {

        static readonly Lazy<QuoteManager> instance = new Lazy<QuoteManager>(() => new QuoteManager());

        private IQuoteLoader loader;

        public static QuoteManager Instance { get => instance.Value; }

        public IList<GreatQuoteViewModel> Quotes { get; set; }

        private QuoteManager() {
            loader = QuoteLoaderFactory.Create();
            Quotes = new ObservableCollection<GreatQuoteViewModel>(loader.Load());
        }

        public void Save() {
            loader.Save(Quotes);
        }

        public void SayQuote(GreatQuoteViewModel quote) {
            if (quote == null)
                throw new ArgumentNullException("No quote set");

            ITextToSpeech tts = ServiceLocator.Instance.Resolve<ITextToSpeech>();

            var text = quote.QuoteText;

            if (!string.IsNullOrWhiteSpace(quote.Author))
                text += $" by {quote.Author}";

            tts.Speak(text);
        }
    }
}
