using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mremh_netcore_logica.Controllers;

namespace mremh_netcore_servicio.Controllers
{
    // RUTA SERVICIOS CATALOGO DE BASES DE DATOS
    [Route("api/basedatos")]
    [ApiController]
    public class BaseDatosController : ControllerBase
    {
        // <summary>
        // Servicio de listado deBases de Datos
        // </summary>
        // <param></param>
        // <returns>Retorno desde Capa Lógica</returns>
        [HttpGet]
        public List<mremh_netcore_data.Models.BaseDatos> GetAll()
        {
            var instancia = new mremh_netcore_logica.Controllers.BaseDatosController();
            return instancia.GetAll();
        }

        // <summary>
        // Servicio de consulta de Base de Datos por ID
        // </summary>
        // <param>ID Base de Datos</param>
        // <returns>Retorno desde Capa Lógica</returns>
        [HttpGet("{id}", Name = "GetBaseDatos")]
        public mremh_netcore_data.Models.BaseDatos GetById(int id)
        {
            var instancia = new mremh_netcore_logica.Controllers.BaseDatosController();
            return instancia.GetById(id);
        }
    }
}