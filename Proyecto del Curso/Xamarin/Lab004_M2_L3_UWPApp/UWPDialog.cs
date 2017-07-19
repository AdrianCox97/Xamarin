using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab004_M2_L3_UWPApp
{
    class UWPDialog : Lab004_M2_L3_PCLProyect.IDialog
    {
        public async void Show(string message)
        {
            var Dialog =
                new Windows.UI.Popups.MessageDialog(
                    message);

            await Dialog.ShowAsync();
        }
    }
}