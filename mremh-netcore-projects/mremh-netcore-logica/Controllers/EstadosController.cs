using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mremh_netcore_data.Models;

namespace mremh_netcore_logica.Controllers
{
    public class EstadosController : Controller
    {
        // <summary>
        // Proceso Lista de Estados
        // </summary>
        // <param></param>
        // <returns>Lista de Estados</returns>
        public List<Estado> GetAll()
        {
            using(var context = new poc_ahdContext())
            {
                var estado = from a in context.Estado select a ;
                return estado.ToList();
            }
        }

        // <summary>
        // Proceso Obtención de Estado
        // </summary>
        // <param>Id Estado</param>
        // <returns>Registro de Estado</returns>
        public Estado GetById(int id)
        {
            using(var context = new poc_ahdContext())
            {
                var estado = from a in context.Estado where a.EstadoId == id select a ;
                return estado.FirstOrDefault();
            }
        }
    }
}
