using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Datos.Interface
{
    public interface InterfaceDatos
    {
        DataTable get(CODIGO_SP codigo_SP, ROL rol);
        bool get_id(CODIGO_SP codigo_SP, ROL rol, List<CD_Parameter_SP> lista);
        bool crear(CODIGO_SP codigo_SP, ROL rol, List<CD_Parameter_SP> lista);
        bool eliminar(CODIGO_SP codigo_SP, ROL rol, List<CD_Parameter_SP> lista);
    }
}
