using System;
using System.Collections.Generic;

// <summary>
// Model de Tabla estado
// </summary>
// <param></param>
// <returns></returns>
namespace mremh_netcore_data.Models
{
    public partial class Estado
    {
        public int EstadoId { get; set; }
        public string Nombre { get; set; }
    }
}
