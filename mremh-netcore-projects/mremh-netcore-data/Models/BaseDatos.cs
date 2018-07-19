using System;
using System.Collections.Generic;

// <summary>
// Model de Tabla base_datos
// </summary>
// <param></param>
// <returns></returns>
namespace mremh_netcore_data.Models
{
    public partial class BaseDatos
    {
        public int BaseDatosId { get; set; }
        public string Nombre { get; set; }
    }
}
