using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mremh_netcore_data.Models;

namespace mremh_netcore_logica.Controllers
{
    public class SistemasController : Controller
    {
        // <summary>
        // Proceso Lista de Sistemas
        // </summary>
        // <param></param>
        // <returns>Lista de Sistemas</returns>
        public List<Sistema> GetAll()
        {
            using(var context = new poc_ahdContext())
            {
                var sistema = from a in context.Sistema where a.Isactivo == true select a ;
                return sistema.ToList();
            }
        }

        // <summary>
        // Proceso Obtención de Sistema
        // </summary>
        // <param>Id Sistema</param>
        // <returns>Registro de Sistema</returns>
        public Sistema GetById(int id)
        {
            using(var context = new poc_ahdContext())
            {
                var sistema = from a in context.Sistema where a.Isactivo == true && a.IdSistema == id select a ;
                return sistema.FirstOrDefault();
            }
        }

        // <summary>
        // Proceso Creación de Sistema
        // </summary>
        // <param>Registro Sistema</param>
        // <returns>Integer 1: Correcto, 0 Incorrecto</returns>
        public int Create(Sistema registro)
        {
            using(var context = new poc_ahdContext())
            {
                context.Add(registro);
                return context.SaveChanges();
     
            }
        }

        // <summary>
        // Proceso Actualización de Sistema
        // </summary>
        // <param>Id Sistema</param>
         // <param>Registro Sistema</param>
        // <returns>Integer 1: Correcto, 0 Incorrecto</returns>
        public int Update(int id, Sistema par_sistema)
        {
            using(var context = new poc_ahdContext())
            {
                var actualizar = context.Sistema.Find(id);
                
                if(actualizar != null)
                {
                    actualizar.Nombre = par_sistema.Nombre;
                    actualizar.Siglas = par_sistema.Siglas;
                    actualizar.Descripcion = par_sistema.Descripcion;
                    actualizar.LinkAcceso = par_sistema.LinkAcceso;
                    actualizar.Estado = par_sistema.Estado;
                    actualizar.AnioProduccion = par_sistema.AnioProduccion;
                    actualizar.CodigoFuente = par_sistema.CodigoFuente;
                    actualizar.DependenciaSistemas = par_sistema.DependenciaSistemas;
                    actualizar.Arquitectura = par_sistema.Arquitectura;
                    actualizar.BaseDatos = par_sistema.BaseDatos;
                    actualizar.Observaciones = par_sistema.Observaciones;
                    actualizar.Documento = par_sistema.Documento;
                    actualizar.UsuarioModificacion = par_sistema.UsuarioModificacion;
                    actualizar.FechaModificacion = par_sistema.FechaModificacion;

                    context.Sistema.Update(actualizar);
                    return context.SaveChanges();
                }
                else
                {
                    return 0;
                }
            }
        }

        // <summary>
        // Proceso Cambio Estado Activo de Sistema
        // </summary>
        // <param>Id Sistema</param>
         // <param>Registro Sistema</param>
        // <returns>Integer 1: Correcto, 0 Incorrecto</returns>
        public int Delete(int id, Sistema par_sistema)
        {
            using(var context = new poc_ahdContext())
            {
                var eliminar = context.Sistema.Find(id);
                
                if(eliminar != null)
                {
                    eliminar.Isactivo = false;
                    eliminar.UsuarioModificacion = par_sistema.UsuarioModificacion;
                    eliminar.FechaModificacion = par_sistema.FechaModificacion;
                    context.Sistema.Update(eliminar);
                    return context.SaveChanges();
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
