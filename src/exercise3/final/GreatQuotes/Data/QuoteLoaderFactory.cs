using System;
namespace GreatQuotes.Data {
    public class QuoteLoaderFactory {
        // This must be assigned to a method which creates a new quote loader.
        public static Func<IQuoteLoader> Create { get; set; }
    }
}