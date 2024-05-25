using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Utilidad.Forms
{
    public class ControlFormsButton
    {


        public static void desabilitarHabilitarboton(bool estado,  Button button)
        {
            button.Enabled = estado;
        }
        public static void desabilitarHabilitarBotones(bool estado, params Button[] buttons)
        {
            List<Button> botones = crearListaTextBox(buttons);
            iterarBotones(estado, botones);
        }


        private static List<Button> crearListaTextBox(params Button[] botones)
        {
            return new List<Button>(botones);
        }

        private static void iterarBotones(bool estado,List<Button> botones)
        {
            foreach (Button button in botones)
            {
                button.Enabled = estado;
            }
        }

        //metodos que detectan los cambios en los botones

    }
}

