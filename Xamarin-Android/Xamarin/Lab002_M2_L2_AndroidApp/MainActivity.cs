using Android.App;
using Android.Widget;
using Android.OS;

using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;

namespace Lab002_M2_L2_AndroidApp
{
    [Activity(Label = "Xamarin lab 002", MainLauncher = true, Icon = "@drawable/XamarinIcon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Validate();
        }

        private async void Validate()
        {
            SALLab02.ServiceClient ServiceClient = new SALLab02.ServiceClient();

            string StudentEmail = "street_cox1997@hotmail.com";
            string Password = "712398729328";

            string myDevice = Android.Provider.Settings.Secure.GetString(ContentResolver, Android.Provider.Settings.Secure.AndroidId);

            SALLab02.ResultInfo Result =
                await ServiceClient.ValidateAsync(StudentEmail, Password, myDevice);

            Android.App.AlertDialog.Builder Builder = new Android.App.AlertDialog.Builder(this);
            AlertDialog Alert = Builder.Create();
            Alert.SetTitle("Resultado de la verificación");
            Alert.SetIcon(Resource.Drawable.XamarinIcon);
            Alert.SetMessage($"{Result.Status}\n{Result.Fullname}\n{Result.Token}");
            Alert.SetButton("Ok", (s, ev) => { });
            Alert.Show();
        }
    }
}