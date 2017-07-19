using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab004_M2_L3_PCLProyect
{
    public class AppValidator
    {
        IDialog Dialog;
        
        public AppValidator(IDialog platformDialog)
        {
            Dialog = platformDialog;
        }

        public string EMail { set; get; }
        public string Password { set; get; }
        public string Device { set; get; }

        public void Validate()
        {
            string Result;
            /* Aquí se puede implementar la funcionalidad
             * principal de la clase. Por el momento solo devuelve
             * una cadena fija.
             */

            Result = "¡Aplicación Validada!";

            Dialog.Show(Result);
        }

        public async void Validate_Diplomado()
        {
            string Result;

            var ServiceClient = new SALLab04.ServiceClient();
            var SvcResult = await ServiceClient.ValidateAsync(
                EMail, Password, Device);

            Result =
                $"{ SvcResult.Status }\n{ SvcResult.Fullname }\n{ SvcResult.Token }";

            /* Invocar el código específico de la plataforma */
            Dialog.Show(Result);
        }
    }
}