﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultorioPrivado.Utilidad.Datos;

namespace ConsultorioPrivado.Datos.Interface
{

    //INTERFAZ DE ACCESOS A DATOS
    public interface AccesoDB
    {

        DataTable ObtenerPorEntidad(E_ROL rol);
        DataTable ObtenerPorId(E_ROL rol, List<CD_Parameter_SP> lista);
        DataTable ObtenerPorCedula(E_ROL rol, List<CD_Parameter_SP> lista);
        bool Crear(E_ROL rol, List<CD_Parameter_SP> lista);
        bool Actualizar(E_ROL rol, List<CD_Parameter_SP> lista);
        bool Eliminar(E_ROL rol, List<CD_Parameter_SP> lista);
    }
}