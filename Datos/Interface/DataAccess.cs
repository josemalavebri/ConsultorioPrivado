using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultorioPrivado.Utilidad.Datos;

namespace ConsultorioPrivado.Datos.Interface
{
    public interface DataAccess
    {

        DataTable get(E_ROL rol);
        DataTable getId(E_ROL rol, List<CD_Parameter_SP> lista);
        DataTable getCedula(E_ROL rol, List<CD_Parameter_SP> lista);
        bool crear(E_ROL rol, List<CD_Parameter_SP> lista);
        bool actualizar(E_ROL rol, List<CD_Parameter_SP> lista);
        bool eliminar(E_ROL rol, List<CD_Parameter_SP> lista);

    }
}
