using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Lab005_M3_L1_PhoneApp
{
    [Activity(Label = "Validar actividad")]
    public class ValidarActividad : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ValidarActividad);

            EditText txtCorreo = FindViewById<EditText>(Resource.Id.txtCorreo);
            EditText txtContrasenia = FindViewById<EditText>(Resource.Id.txtContrasenia);
            TextView tvValidando = FindViewById<TextView>(Resource.Id.tvValidando);
            Button btnValidar = FindViewById<Button>(Resource.Id.btnValidar);

            txtCorreo.TextChanged += txt_TextChanged;
            txtContrasenia.TextChanged += txt_TextChanged;

            btnValidar.Click += ((object sender, System.EventArgs e) =>
                {
                    Validator(tvValidando);
                });

            void txt_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
            {
                if (txtCorreo.Text.Trim().Length > 0 && txtContrasenia.Text.Trim().Length > 0)
                {
                    btnValidar.Enabled = true;
                }
                else
                {
                    btnValidar.Enabled = false;
                }
            }
        }

        async void Validator(TextView tvValidando)
        {
            var Validar = new SALLab06.ServiceClient();
            string EMail = "street_cox1997@hotmail.com";
            string Password = "712398729328";
            string Device = Android.Provider.Settings.Secure.GetString(
                ContentResolver, Android.Provider.Settings.Secure.AndroidId);
            string strValidacion = "";

            var Validacion = await Validar.ValidateAsync(EMail, Password, Device);

            strValidacion = Validacion.Status + "\n" +
                Validacion.Fullname + "\n" +
                Validacion.Token;

            tvValidando.Text = strValidacion;
            tvValidando.SetTextColor(Android.Graphics.Color.Green);
        }
    }
}