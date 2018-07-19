using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mremh_netcore_logica.Controllers;

namespace mremh_netcore_servicio.Controllers
{
    // RUTA SERVICIOS CATALOGO DE CODIGOS FUENTE
    [Route("api/codigofuente")]
    [ApiController]
    public class CodigoFuenteController : ControllerBase
    {
        // <summary>
        // Servicio de listado de Códigos Fuente
        // </summary>
        // <param></param>
        // <returns>Retorno desde Capa Lógica</returns>
        [HttpGet]
        public List<mremh_netcore_data.Models.CodigoFuente> GetAll()
        {
            var instancia = new mremh_netcore_logica.Controllers.CodigoFuenteController();
            return instancia.GetAll();
        }

        // <summary>
        // Servicio de consulta de Código Fuente por ID
        // </summary>
        // <param>ID Código Fuente</param>
        // <returns>Retorno desde Capa Lógica</returns>
        [HttpGet("{id}", Name = "GetCodigoFuente")]
        public mremh_netcore_data.Models.CodigoFuente GetById(int id)
        {
            var instancia = new mremh_netcore_logica.Controllers.CodigoFuenteController();
            return instancia.GetById(id);
        }
    }
}
