using System.Collections.Generic;
using GreatQuotes.ViewModels;

namespace GreatQuotes.Data {
    public interface IQuoteLoader {
        IEnumerable<GreatQuoteViewModel> Load();
        void Save(IEnumerable<GreatQuoteViewModel> quotes);
    }
}