using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mremh_netcore_logica.Controllers;

namespace mremh_netcore_servicio.Controllers
{
    // RUTA SERVICIOS CATALOGO DE ESTADOS
    [Route("api/estados")]
    [ApiController]
    public class EstadosController : ControllerBase
    {
        // <summary>
        // Servicio de listado de Estados
        // </summary>
        // <param></param>
        // <returns>Retorno desde Capa Lógica</returns>
        [HttpGet]
        public List<mremh_netcore_data.Models.Estado> GetAll()
        {
            var instancia = new mremh_netcore_logica.Controllers.EstadosController();
            return instancia.GetAll();
        }

        // <summary>
        // Servicio de consulta de Estado por ID
        // </summary>
        // <param>ID Estado</param>
        // <returns>Retorno desde Capa Lógica</returns>
        [HttpGet("{id}", Name = "GetEstado")]
        public mremh_netcore_data.Models.Estado GetById(int id)
        {
            var instancia = new mremh_netcore_logica.Controllers.EstadosController();
            return instancia.GetById(id);
        }
    }
}
