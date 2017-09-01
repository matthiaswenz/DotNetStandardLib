using Android.App;
using Android.Widget;
using Android.OS;
using StandardLibTest;

namespace App.Droid
{
    [Activity(Label = "App", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Class1 cls = new Class1();

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

