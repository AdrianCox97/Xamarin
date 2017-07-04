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

using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;

namespace Lab001_M1_L1
{
    class Registro
    {

    }

    public class ServiceHelper
    {
        MobileServiceClient clienteServicio = new MobileServiceClient(@"http://xamarin-diplomado.azurewebsites.net/");

        private IMobileServiceTable<LabItem> _LabItemTable;

        public async Task InsertarEntidad(string direccionCorreo, string lab, string AndroidId)
        {
            _LabItemTable = clienteServicio.GetTable<LabItem>();

            await _LabItemTable.InsertAsync(new LabItem
            {
                Email = direccionCorreo,
                Lab = lab,
                DeviceId = AndroidId
            });
        }
    }

    public class LabItem
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Lab { get; set; }
        public string DeviceId { get; set; }

    }
}