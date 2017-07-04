using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Lab001_M1_L1
{
    [Activity(Label = "Xamarin", MainLauncher = true, Icon = "@drawable/XamarinIcon")]
    public class MainActivity : Activity
    {
        Button button;
        TextView textViewDev;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Se hacen las instancias hacia los controles a utilizar.
            button = FindViewById<Button>(Resource.Id.MyButton);
            textViewDev = FindViewById<TextView>(Resource.Id.textViewDev);

            button.Click += Button_Click;
        }

        private async void Button_Click(object sender, EventArgs e)
        {
            textViewDev.Text = "Adrian Alberto Cox Canché";
            //Obtiene el ID del dispositivo
            string myDevice = Android.Provider.Settings.Secure.GetString(ContentResolver, Android.Provider.Settings.Secure.AndroidId);
            ServiceHelper helper = new ServiceHelper();
            await helper.InsertarEntidad("street_cox1997@hotmail.com", "Lab1", myDevice);
            button.Text = "Gracias por completar el Lab001";
        }
    }
}