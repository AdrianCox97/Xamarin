using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PhoneWord
{
    public partial class MainPage : ContentPage
    {
        String numeroTraducido;

        public MainPage()
        {
            InitializeComponent();
        }

        void btnTraducir_Traducir(object sender, EventArgs e)
        {
            numeroTraducido = Core.Traductor.ToNumber(txtNumeroTelefono.Text);
            if (!String.IsNullOrWhiteSpace(numeroTraducido))
            {
                btnLlamar.IsEnabled = true;
                btnLlamar.Text = $"Llamar a { numeroTraducido }";
            }
            else
            {
                btnLlamar.IsEnabled = false;
                btnLlamar.Text = "Llamar";
            }
        }

        async void btnLlamar_Llamar(object sender, EventArgs e)
        {
            if (await this.DisplayAlert (
                "Llamar a Número",
                $"¿Te gustaría llamar al número { numeroTraducido }?",
                "Yes",
                "No"))
            {
                var marcador = DependencyService.Get<IDialer>();
                if (marcador != null)
                {
                    marcador.Dial(numeroTraducido);
                }
            }
        }
    }
}