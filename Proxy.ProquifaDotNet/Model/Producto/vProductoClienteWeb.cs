using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.ProquifaDotNet.Model
{
    public class vProductoClienteWeb
    {
        public System.Guid IdProducto { get; set; }
        public System.Guid IdFamilia { get; set; }
        public Nullable<bool> TieneCAS { get; set; }
        public string? CAS { get; set; }
        public string? ATC { get; set; }
        public string? Catalogo { get; set; }
        public string? Descripcion { get; set; }
        public string? TipoPresentacion { get; set; }
        public string? TipoPresentacionClave { get; set; }
        public string? Presentacion { get; set; }
        public string? MedioTransporte { get; set; }
        public string? MedioTransporteClave { get; set; }
        public string? ManejoTransporte { get; set; }
        public string? ManejoTransporteClave { get; set; }
        public string? ManejoAlmacenaje { get; set; }
        public string? ManejoAlmacenajeClave { get; set; }
        public string? ISBN { get; set; }
        public string? NombreImagenMarca { get; set; }
        public string? NombreFamilia { get; set; }
        public string? Tipo { get; set; }
        public string? ClaveTipo { get; set; }
        public string? NombreMarca { get; set; }
        public string? Disponibilidad { get; set; }
        public string? DisponibilidadClave { get; set; }
        public string? Linea { get; set; }
        public string? Unidad { get; set; }
        public Nullable<decimal> Pureza { get; set; }
        public bool TieneFleteExpress { get; set; }
        public Nullable<bool> TieneStock { get; set; }
        public Nullable<bool> ProximoACaducar { get; set; }
        public Nullable<int> CantidadExistenteStock { get; set; }
        public Nullable<System.DateTime> FechaCaducidadStock { get; set; }
        public Nullable<decimal> TiempoEstimadoEntregaStock { get; set; }
        private PrecioOferta _oferta = new PrecioOferta();
        public PrecioOferta oferta
        {
            get { return _oferta; }
            set
            {
                if ( value == null )
                {
                    _oferta = new PrecioOferta();
                }
                else
                {
                    _oferta = value;
                }

            }
        }
    }
}
