using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mremh_netcore_data.Models;

namespace mremh_netcore_logica.Controllers
{
    public class CodigoFuenteController : Controller
    {
        // <summary>
        // Proceso Lista de Codigos Fuente
        // </summary>
        // <param></param>
        // <returns>Lista de Codigos Fuente</returns>
        public List<CodigoFuente> GetAll()
        {
            using(var context = new poc_ahdContext())
            {
                var codigoFuente = from a in context.CodigoFuente select a;
                return codigoFuente.ToList();
            }
        }

        // <summary>
        // Proceso Obtención de Codigo Fuente
        // </summary>
        // <param>Id Codigo Fuente</param>
        // <returns>Registro de Codigo Fuente</returns>
        public CodigoFuente GetById(int id)
        {
            using(var context = new poc_ahdContext())
            {
                var codigoFuente = from a in context.CodigoFuente where a.CodigoFuenteId == id select a;
                return codigoFuente.FirstOrDefault();
            }
        }
    }
}