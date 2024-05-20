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
        bool getId(CODIGO_SP codigo_SP, ROL rol, List<CD_Parameter_SP> lista);
        bool crear(CODIGO_SP codigo_SP, ROL rol, List<CD_Parameter_SP> lista);
        bool eliminar(CODIGO_SP codigo_SP, ROL rol, List<CD_Parameter_SP> lista);
    }
}
