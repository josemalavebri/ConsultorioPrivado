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
        DataTable get(ROL rol);
        bool getId(ROL rol, List<CD_Parameter_SP> lista);
        bool crear(ROL rol, List<CD_Parameter_SP> lista);
        bool elimina(ROL rol, List<CD_Parameter_SP> lista);
    }
}
