using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class Traductor
    {
        public static String ToNumber(String numero)
        {
            if (String.IsNullOrWhiteSpace(numero))
            {
                return null;
            }

            numero = numero.ToUpperInvariant();

            var nuevoNumero = new StringBuilder();

            foreach (var c in numero)
            {
                if (" -0123456789".Contains(c))
                {
                    nuevoNumero.Append(c);
                }
                else
                {
                    var resultado = TraducirNumero(c);

                    if (resultado != null)
                    {
                        nuevoNumero.Append(resultado);
                    }
                    else
                    {
                        return null;
                    }
                }
            }

            return nuevoNumero.ToString();
        }

        static Boolean Contains(this String keyString, Char c)
        {
            return keyString.IndexOf(c) >= 0;
        }

        static readonly String[] digitos =
        {
                "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ"
            };

        static int? TraducirNumero(Char c)
        {
            for (int i = 0; i < digitos.Length; i++)
            {
                if (digitos[i].Contains(c))
                {
                    return 2 + i;
                }
            }

            return null;
        }
    }
}