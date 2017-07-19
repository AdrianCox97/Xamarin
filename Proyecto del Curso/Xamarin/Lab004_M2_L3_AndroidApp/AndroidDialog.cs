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

namespace Lab004_M2_L3_AndroidApp
{
    class AndroidDialog : Lab004_M2_L3_PCLProyect.IDialog
    {
        Context AppContext;

        public AndroidDialog(Context context)
        {
            AppContext = context;
        }

        public void Show(string message)
        {
            Android.App.AlertDialog.Builder Builder =
                new AlertDialog.Builder(AppContext);

            AlertDialog Alert = Builder.Create();
            Alert.SetTitle("Resultado de la verificación");
            Alert.SetIcon(Resource.Drawable.XamarinIcon);
            Alert.SetMessage(message);
            Alert.SetButton("Ok", (s, ev) => { });
            Alert.Show();
        }
    }
}