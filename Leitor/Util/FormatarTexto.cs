using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor.Util
{
    static class FormatarTexto
    {
        public static string Format(string texto)
        {
            if (texto == null)
            {
                return "";
            }

            if (texto.Length == 3)
            {
                return texto;
            }

            texto = texto.Replace(" ", "").Trim();
           
            string textoFormatado = "";
            for (int i = 0; i < texto.Length; i = i + 2)
            {
                if(i > 0)
                {
                    textoFormatado += " "+texto.Substring(i, 2);
                }
                else
                {
                    textoFormatado = texto.Substring(i, 2);
                }
                
            }

            return textoFormatado;
        }
    }
}
