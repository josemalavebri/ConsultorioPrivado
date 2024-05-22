using System;
using System.Collections.Generic;
using ConsultorioPrivado.Utilidad;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Datos.Interface
{
    public interface InterfaceDatos
    {
        DataTable get(E_ROL rol);
        bool getId(E_ROL rol, List<CD_Parameter_SP> lista);
        bool crear(E_ROL rol, List<CD_Parameter_SP> lista);
        bool elimina(E_ROL rol, List<CD_Parameter_SP> lista);
    }
}
