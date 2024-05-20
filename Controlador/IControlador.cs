using ConsultorioPrivado.Datos.Interface;
using ConsultorioPrivado.Modelo;
using ConsultorioPrivado.Utilidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Controlador
{
    internal interface IControlador<T>
    {
        DataTable get();

        bool crear(T objeto);

        bool modificar(T objeto);
        
        bool eliminar(T objeto);
    }
}
