using System;
using System.Collections.Generic;

// <summary>
// Model de Tabla sistema
// </summary>
// <param></param>
// <returns></returns>
namespace mremh_netcore_data.Models
{
    public partial class Sistema
    {
        public int IdSistema { get; set; }
        public string Nombre { get; set; }
        public string Siglas { get; set; }
        public string Descripcion { get; set; }
        public string LinkAcceso { get; set; }
        public int Estado { get; set; }
        public int? AnioProduccion { get; set; }
        public bool? CodigoFuente { get; set; }
        public int? DependenciaSistemas { get; set; }
        public int Arquitectura { get; set; }
        public string BaseDatos { get; set; }
        public string Observaciones { get; set; }
        public string Documento { get; set; }
        public bool Isactivo { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
