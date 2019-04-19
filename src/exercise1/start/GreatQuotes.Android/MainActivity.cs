using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using GreatQuotes.ViewModels;
using System.Collections.ObjectModel;

namespace GreatQuotes.Droid {
    [Activity(Label = "@string/app_name", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public MainViewModel GreatQuotesViewModel { get; private set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            var quoteLoader = new QuoteLoader();
            GreatQuotesViewModel = new MainViewModel(() => quoteLoader.Save(GreatQuotesViewModel.Quotes)) {
                Quotes = new ObservableCollection<GreatQuoteViewModel>(quoteLoader.Load())
            };

            var app = new App(GreatQuotesViewModel);
            LoadApplication(app);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}