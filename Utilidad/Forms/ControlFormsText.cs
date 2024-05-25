using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Utilidad.Forms
{
    public class ControlFormsText
    {


        private static void QuitarTextos(List<TextBox> tbxGeneral)
        {
            foreach (TextBox item in tbxGeneral)
            {
                item.Text = string.Empty;
            }
        }

        private static List<TextBox> CrearListaTextBox(params TextBox[] textBoxes)
        {
            return new List<TextBox>(textBoxes);
        }

        public static void EliminarTextos(params TextBox[] textBoxes)
        {
            QuitarTextos(CrearListaTextBox(textBoxes));
        }



    }
}
