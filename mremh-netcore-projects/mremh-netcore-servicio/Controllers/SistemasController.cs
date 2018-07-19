using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mremh_netcore_logica.Controllers;

namespace mremh_netcore_servicio.Controllers
{
    // RUTA SERVICIOS CATALOGO DE SISTEMAS
    [Route("api/sistemas")]
    [ApiController]
    public class SistemasController : ControllerBase
    {
        // <summary>
        // Servicio de listado de Sistemas
        // </summary>
        // <param></param>
        // <returns>Retorno desde Capa Lógica</returns>
        [HttpGet]
        public List<mremh_netcore_data.Models.Sistema> GetAll()
        {
            var instancia = new mremh_netcore_logica.Controllers.SistemasController();
            return instancia.GetAll();
        }

        // <summary>
        // Servicio de consulta de Sistema por ID
        // </summary>
        // <param>ID Sistema</param>
        // <returns>Retorno desde Capa Lógica</returns>
        [HttpGet("{id}", Name = "GetSistema")]
        public mremh_netcore_data.Models.Sistema GetById(int id)
        {
            var instancia = new mremh_netcore_logica.Controllers.SistemasController();
            return instancia.GetById(id);
        }

        // <summary>
        // Servicio de creación de Sistema
        // </summary>
        // <param>Registro Sistema</param>
        // <returns>Retorno desde Capa Lógica (1 / 0)</returns>
        [HttpPost]
        public int Create(mremh_netcore_data.Models.Sistema registro)
        {
            var instancia = new mremh_netcore_logica.Controllers.SistemasController();
            return instancia.Create(registro);
        }

        // <summary>
        // Servicio de actualización de Sistema
        // </summary>
        // <param>ID Sistema</param>
        // <param>Registro Sistema</param>
        // <returns>Retorno desde Capa Lógica (1 / 0)</returns>
        [HttpPut("{id}")]
        public int Update(int id, mremh_netcore_data.Models.Sistema par_sistema)
        {
            var instancia = new mremh_netcore_logica.Controllers.SistemasController();
            return instancia.Update(id,par_sistema);
        }

        // <summary>
        // Servicio de desactivación de Sistema
        // </summary>
        // <param>ID Sistema</param>
        // <param>Registro Sistema</param>
        // <returns>Retorno desde Capa Lógica (1 / 0)</returns>
        [HttpDelete("{id}")]
        public int Delete(int id, mremh_netcore_data.Models.Sistema par_sistema)
        {
            var instancia = new mremh_netcore_logica.Controllers.SistemasController();
            return instancia.Delete(id,par_sistema);
        }
    }
}
