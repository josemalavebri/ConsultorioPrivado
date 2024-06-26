﻿using ConsultorioPrivado.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Controlador.Creators
{
    internal class PropiedadesCreator
    {

        private List<ParametrosCreator> lista;

        public PropiedadesCreator()
        {
            lista = new List<ParametrosCreator>();
        }

        public List<ParametrosCreator> CrearListaPropiedades<T>(T entidad) where T : IEntidad
        {
            lista.Clear();
            var propiedades = typeof(T).GetProperties();

            foreach (var propiedad in propiedades)
            {
                var nombreParametro = $"@{propiedad.Name}";
                var valor = propiedad.GetValue(entidad);
                var tipo = MapearTipo(propiedad.PropertyType);
                lista.Add(new ParametrosCreator(nombreParametro, valor, tipo));
            }

            return lista;
        }

        public List<ParametrosCreator> CrearListaPropiedadesId<T>(T entidad) where T : IEntidad
        {
            lista.Clear();
            var propiedades = typeof(T).GetProperties();
            foreach (var propiedad in propiedades)
            {
                if (propiedad.Name.ToLower() == "id")
                {
                    var nombreParametro = $"@{propiedad.Name}";
                    var valor = propiedad.GetValue(entidad);
                    var tipo = MapearTipo(propiedad.PropertyType);
                    lista.Add(new ParametrosCreator(nombreParametro, valor, tipo));
                    break;
                }
            }
            return lista;
        }

        public List<ParametrosCreator> CrearListaPropiedadesCedula<T>(T entidad) where T : IEntidad
        {
            lista.Clear();
            var propiedades = typeof(T).GetProperties();
            foreach (var propiedad in propiedades)
            {
                if (propiedad.Name.ToLower() == "cedula")
                {
                    var nombreParametro = $"@{propiedad.Name}";
                    var valor = propiedad.GetValue(entidad);
                    var tipo = MapearTipo(propiedad.PropertyType);
                    lista.Add(new ParametrosCreator(nombreParametro, valor, tipo));
                    break;
                }
            }

            return lista;
        }

        private bool EsValorValido(object valor)
        {
            if (valor == null)
            {
                return false;
            }

            if (valor is string strValue && string.IsNullOrWhiteSpace(strValue))
            {
                return false;
            }

            if (valor is int intValue && intValue == 0)
            {
                return false;
            }
            return false;
        }

        //MAPEA LOS TIPOS DE LAS ENTIDADES
        private static SqlDbType MapearTipo(Type tipo)
        {
            if (tipo == typeof(string))
                return SqlDbType.Text;
            if (tipo == typeof(int))
                return SqlDbType.Int;
            if (tipo == typeof(DateTime))
                return SqlDbType.Date;
            if (tipo == typeof(Enum))
                return SqlDbType.Text;
            throw new ArgumentException("Tipo no soportado");
        }


    }
}
