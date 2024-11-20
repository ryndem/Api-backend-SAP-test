//using Core.CrudTools.Genericos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.ProquifaDotNet.Model
{
    public class PrecioOferta
    {
        //public Guid? IdCliente { get; set; }
        //public Guid IdProducto { get; set; }
        public Guid? IdCatMoneda { get; set; }
        public decimal Piezas { get; set; }
        public decimal Precio { get; set; }
        public string? TiempoEntrega { get; set; }
        public decimal TiempoEntregaDias { get; set; }
        
        public string? TiempoEntregaFecha { get; set; }
        //public Guid? IdValorConfiguracionTiempoEntrega { get; set; }
        //public Guid IdMarcaFamilia { get; set; }

        //public Guid IdCatMonedaVentas;
        //public Guid? IdProveedor { get; set; }
        //public decimal? PrecioProquifaNetClienteTabla { get; set; }
       
        //public Nullable<System.Guid> IdConfiguracionPrecioProveedorFamilia { get; set; }
        //public Nullable<System.Guid> IdConfiguracionPrecioUtilidadCategoriaProveedor { get; set; }
        //public Nullable<System.Guid> IdConfiguracionComisionProveedor { get; set; }

        public bool AplicaPorPieza { get; set; }
        public Boolean Configurado { get; set; }

        public string? TiempoEntregaStock { get; set; }
        public Nullable<decimal> TiempoEntregaDiasStock { get; set; }
        public bool TieneStock { get; set; }
        public Guid? IdDireccionEntrega { get; set; }
    }
}
