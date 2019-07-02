using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GreatQuotes.ViewModels {
    public class BaseViewModel : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetPropertyValue<T>(ref T field, T value, [CallerMemberName] string propertyName = null) {
            if (Equals(field, value) == false) {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }
            return false;
        }
    }
}