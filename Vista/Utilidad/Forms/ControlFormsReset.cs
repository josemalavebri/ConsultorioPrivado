using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Vista.Utilidad.Forms
{
    internal class ControlFormsReset
    {
        public static void TextBoxChangeListener(Button resetButton, params TextBox[] textBoxes)
        {
            EmpezarEventos(resetButton, textBoxes);
        }

        private static void EmpezarEventos(Button resetButton, params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                textBox.TextChanged += TextBox_TextChanged;
                if (textBox != null)
                {
                    ControlFormsButton.desabilitarHabilitarboton(true, resetButton);
                }
            }
        }

        private static void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
        }
    }
}
