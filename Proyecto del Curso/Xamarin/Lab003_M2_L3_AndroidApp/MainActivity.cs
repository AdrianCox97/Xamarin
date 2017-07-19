using Android.App;
using Android.Widget;
using Android.OS;

namespace Lab003_M2_L3_AndroidApp
{
    [Activity(Label = "Xamarin Lab 003", MainLauncher = true, Icon = "@drawable/XamarinIcon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var Helper = new Lab003_M2_L3_SharedProject.MySharedCode();
            new AlertDialog.Builder(this)
                .SetMessage(Helper.GetFilePath("demo.dat"))
                .Show();

            Validate();
            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }

        private async void Validate()
        {
            var ServiceClient =
                new SALLab03.ServiceClient();

            string StudentEmail = "street_cox1997@hotmail.com";
            string Password = "712398729328";

            string myDevice =
                Android.Provider.Settings.Secure.GetString(
                    ContentResolver,
                    Android.Provider.Settings.Secure.AndroidId);

            var Result =
                await ServiceClient.ValidateAsync(
                    StudentEmail, Password, myDevice);

            Android.App.AlertDialog.Builder Builder =
                new AlertDialog.Builder(this);
            AlertDialog Alert = Builder.Create();
            Alert.SetTitle("Resultado de la verificación");
            Alert.SetIcon(Resource.Drawable.XamarinIcon);
            Alert.SetMessage(
                $"{ Result.Status }\n{ Result.Fullname }\n{ Result.Token }");
            Alert.SetButton("Ok", (s, ev) => { });
            Alert.Show();
        }
    }
}