using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mremh_netcore_logica.Controllers;

namespace mremh_netcore_servicio.Controllers
{
    // RUTA SERVICIOS CATALOGO DE ARQUITECTURAS
    [Route("api/arquitectura")]
    [ApiController]
    public class ArquitecturaController : ControllerBase
    {
        // <summary>
        // Servicio de listado de Arquitecturas
        // </summary>
        // <param></param>
        // <returns>Retorno desde Capa Lógica</returns>
        [HttpGet]
        public List<mremh_netcore_data.Models.Arquitectura> GetAll()
        {
            var instancia = new mremh_netcore_logica.Controllers.ArquitecturaController();
            return instancia.GetAll();
        }

        // <summary>
        // Servicio de consulta de Arquitectura por ID
        // </summary>
        // <param>ID Arquitectura</param>
        // <returns>Retorno desde Capa Lógica</returns>
        [HttpGet("{id}", Name = "GetArquitectura")]
        public mremh_netcore_data.Models.Arquitectura GetById(int id)
        {
            var instancia = new mremh_netcore_logica.Controllers.ArquitecturaController();
            return instancia.GetById(id);
        }
    }
}