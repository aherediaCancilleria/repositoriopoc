using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mremh_netcore_data.Models;

namespace mremh_netcore_logica.Controllers
{
    public class ArquitecturaController : Controller
    {
        // <summary>
        // Proceso Lista de Arquitecturas
        // </summary>
        // <param></param>
        // <returns>Lista de Arquitecturas</returns>
        public List<Arquitectura> GetAll()
        {
            using(var context = new poc_ahdContext())
            {
                var arquitectura = from a in context.Arquitectura select a;
                return arquitectura.ToList();
            }
        }

        // <summary>
        // Proceso Obtención de Arquitectura
        // </summary>
        // <param>Id Arquitectura</param>
        // <returns>Registro de Arquitectura</returns>
        public Arquitectura GetById(int id)
        {
            using(var context = new poc_ahdContext())
            {
                var arquitectura = from a in context.Arquitectura where a.ArquitecturaId == id select a;
                return arquitectura.FirstOrDefault();
            }
        }
    }
}