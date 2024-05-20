using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Controlador
{
    public class Parametrizacion
    {
        private List<string> parametrosTexto;

        public Parametrizacion()
        {
            parametrosTexto = new List<string>();
        }
        
        public void añadirParametrosTexto(string texto )
        {
            parametrosTexto.Add(texto);
        }

    }
}
