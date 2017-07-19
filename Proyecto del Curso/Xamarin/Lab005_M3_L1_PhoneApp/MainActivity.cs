using Android.App;
using Android.Widget;
using Android.OS;

namespace Lab005_M3_L1_PhoneApp
{
    [Activity(Label = "Xamarin Lab 005 - Phone App", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var PhoneNumberText = FindViewById<EditText>(Resource.Id.PhoneNumberText);
            var TranslateButton = FindViewById<Button>(Resource.Id.TranslateButton);
            var CallButton = FindViewById<Button>(Resource.Id.CallButton);

            CallButton.Enabled = false;

            var TranslatedNumber = string.Empty;

            TranslateButton.Click += ((object sender, System.EventArgs e) =>
                {
                    var Translator = new PhoneTranslator();

                    TranslatedNumber = Translator.ToNumber(PhoneNumberText.Text);

                    if (string.IsNullOrWhiteSpace(TranslatedNumber))
                    {
                        //No hay número a llamar
                        CallButton.Text = "Llamar";
                        CallButton.Enabled = false;
                    }
                    else
                    {
                        //hay un posible número telefónico a llamar
                        CallButton.Text = $"Llamar al { TranslatedNumber }";
                        CallButton.Enabled = true;
                    }
                });

            CallButton.Click += ((object sender, System.EventArgs e) =>
                {
                    /* Nota: El AlertDialog colocoa los botones sin tamaño estandar y en
                     * el siguiente orden:
                     *      NeutralButton
                     *      NegativeButton PositiveButton
                     */

                    //Intentar llamar al número telefónico
                    var CallDialog = new AlertDialog.Builder(this);

                    CallDialog.SetMessage($"Llamar al número { TranslatedNumber }?");

                    CallDialog.SetNeutralButton("Lamar", delegate
                        {
                            //Crear un intento para marcar el número telefónico
                            var CallIntent =
                                new Android.Content.Intent(
                                    Android.Content.Intent.ActionCall);

                            CallIntent.SetData(
                                Android.Net.Uri.Parse($"tel:{ TranslatedNumber }"));

                            StartActivity(CallIntent);
                        });

                    CallDialog.SetPositiveButton("PB", delegate
                        {
                            Toast.MakeText(ApplicationContext,
                                "PositiveButton",
                                ToastLength.Long).Show();
                        });

                    CallDialog.SetNegativeButton("Cancelar", delegate 
                        {
                            Toast.MakeText(ApplicationContext,
                                "Se ha cnacelado la operación",
                                ToastLength.Long).Show();
                        });

                    CallDialog.Show();
                });
        }
    }
}