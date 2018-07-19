using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mremh_netcore_data.Models;

namespace mremh_netcore_logica.Controllers
{
    public class BaseDatosController : Controller
    {
        // <summary>
        // Proceso Lista de Bases de Datos
        // </summary>
        // <param></param>
        // <returns>Lista de Bases de Datos</returns>
        public List<BaseDatos> GetAll()
        {
            using(var context = new poc_ahdContext())
            {
                var baseDatos = from a in context.BaseDatos select a;
                return baseDatos.ToList();
            }
        }

        // <summary>
        // Proceso Obtención de Base de Datos
        // </summary>
        // <param>Id Base de Datos</param>
        // <returns>Registro de Base de Datos</returns>
        public BaseDatos GetById(int id)
        {
            using(var context = new poc_ahdContext())
            {
                var baseDatos = from a in context.BaseDatos where a.BaseDatosId == id select a;
                return baseDatos.FirstOrDefault();
            }
        }
    }
}