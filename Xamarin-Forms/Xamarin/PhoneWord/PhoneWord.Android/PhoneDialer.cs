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

using Android.Telephony;
using PhoneWord.Droid;
using Xamarin.Forms;
using Uri = Android.Net.Uri;

[assembly: Dependency(typeof(PhoneDialer))]
namespace PhoneWord.Droid
{
    class PhoneDialer : IDialer
    {
        public bool Dial(string numero)
        {
            throw new NotImplementedException();
        }
    }
}