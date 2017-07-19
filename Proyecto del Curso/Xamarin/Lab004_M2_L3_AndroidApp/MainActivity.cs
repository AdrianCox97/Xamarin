using Android.App;
using Android.Widget;
using Android.OS;

namespace Lab004_M2_L3_AndroidApp
{
    [Activity(Label = "Xamarin Lab 004", MainLauncher = true, Icon = "@drawable/XamarinIcon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            /* Creamos la instancia del código compartido
             * y le inyectamos la denpendencia.
             */

            var Validator =
                new Lab004_M2_L3_PCLProyect.AppValidator(new AndroidDialog(this));

            /* Aquí podríamos establecer los valores de las propiedades
             * Email, Password, y Device.
             */

            Validator.EMail = "street_cox1997@hotmail.com";
            Validator.Password = "712398729328";
            Validator.Device =
                Android.Provider.Settings.Secure.GetString(
                    ContentResolver,
                    Android.Provider.Settings.Secure.AndroidId);

            /* Realizamos la validación */
            //Validator.Validate();
            Validator.Validate_Diplomado();
            //Toast.MakeText(ApplicationContext, "xD", ToastLength.Long).Show();
        }
    }
}