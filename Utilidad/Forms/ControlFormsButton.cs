using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Utilidad.Forms
{
    public class ControlFormsButton
    {

        public static void desabilitarHabilitarBoton(bool estado,Button button1)
        {
            button1.Enabled = estado;
        }

        public static void desabilitarHabilitarBotones(bool estado, Button button1, Button button2, Button button3)
        {
            List<Button> buttons = new List<Button>();
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            iterarBotones(estado,buttons);
        }

        private static void iterarBotones(bool estado,List<Button> buttons)
        {
            foreach (Button button in buttons)
            {
                button.Enabled = estado;
            }
        }
    }
}
