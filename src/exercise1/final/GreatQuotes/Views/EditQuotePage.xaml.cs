using Xamarin.Forms;

namespace GreatQuotes.Views {
    public partial class EditQuotePage : ContentPage {
        public EditQuotePage() {
            InitializeComponent();
            BindingContext = App.GreatQuotesViewModel.ItemSelected;
        }

        async void Handle_Clicked(object sender, System.EventArgs e) {
            App.GreatQuotesViewModel.SaveQuotes();
            await this.Navigation.PopModalAsync();
        }
    }
}
