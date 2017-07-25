using Foundation;
using Phoneword.iOS;
using UIKit;
using Xamarin.Forms;
using Phoneword;
using System;

[assembly: Dependency(typeof(PhoneDialer))]
namespace Phoneword.iOS
{
    public class PhoneDialer : IDialer
    {
        public bool Dial(string number)
        {
            return UIApplication.SharedApplication.OpenUrl(
                new NSUrl($"tel:{ number }"));
        }
    }

    public interface IDialer
    {
        bool Dial(string number);
    }
}