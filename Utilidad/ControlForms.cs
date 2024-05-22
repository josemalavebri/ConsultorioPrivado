using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Utilidad
{
    public class ControlForms
    {


        public static void eliminarTextoBox(TextBox textBox)
        {
            textBox.Text = string.Empty;

        }

        private static void quitarTextos(List<TextBox> tbxGeneral)
        {
            foreach (TextBox item in tbxGeneral)
            {
                item.Text = string.Empty;
            }
        }

        
        private static List<TextBox> agregarTextBoxLista1(TextBox tbx1, TextBox tbx2, TextBox tbx3, TextBox tbx4)
        {
            List<TextBox> tbxGeneral = new List<TextBox>();
            tbxGeneral.Add(tbx1);
            tbxGeneral.Add(tbx2);
            tbxGeneral.Add(tbx3);
            tbxGeneral.Add(tbx4);
            return tbxGeneral;
        }

        private static List<TextBox> agregarTextBoxLista2(TextBox tbx1, TextBox tbx2, TextBox tbx3, TextBox tbx4,TextBox tbx5)
        {
            List<TextBox> txtGeneral = agregarTextBoxLista1(tbx1, tbx2, tbx3, tbx4);
            txtGeneral.Add(tbx5);
            return txtGeneral;
        }

        public static void eliminarCuatroTextoBoxs(TextBox tbx1, TextBox tbx2, TextBox tbx3, TextBox tbx4)
        {
            quitarTextos(agregarTextBoxLista1(tbx1, tbx2, tbx3, tbx4));
        }

        public static void eliminarCincoTextoBoxs(TextBox tbx1, TextBox tbx2, TextBox tbx3, TextBox tbx4, TextBox tbx5)
        {
            quitarTextos(agregarTextBoxLista2(tbx1, tbx2, tbx3, tbx4,tbx5));
        }


    }
}
