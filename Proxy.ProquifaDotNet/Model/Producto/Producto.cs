using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.ProquifaDotNet.Model
{
    public class Producto
    {
        public System.Guid IdProducto { get; set; }
        public string Descripcion { get; set; }
        public string Nota { get; set; }
        public Nullable<System.Guid> IdCatDisponibilidad { get; set; }
        public Nullable<System.Guid> IdCatLinea { get; set; }
        public decimal PrecioLista { get; set; }
        public Nullable<System.Guid> IdCatUnidad { get; set; }
        public bool GravaIVA { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public Nullable<System.DateTime> FechaCaducidadRegistro { get; set; }
        public System.DateTime FechaUltimaActualizacion { get; set; }
        public bool Activo { get; set; }
        public Nullable<decimal> PorcentajeIVA { get; set; }
        public Nullable<System.Guid> IdCatClasificacionInformativaProducto { get; set; }
        public bool InvestigacionCompleta { get; set; }
        public bool Controlado { get; set; }
        public Nullable<System.Guid> IdArchivoCertificado { get; set; }
        public Nullable<System.Guid> IdCatDepositarioInternacional { get; set; }
        public string NumeroDepositarioInternacional { get; set; }
        public Nullable<System.Guid> IdProveedor { get; set; }
        public Nullable<System.Guid> IdAgrupadorCaracteristica { get; set; }
        public Nullable<decimal> PrecioListaMonedaProveedor { get; set; }
        public Nullable<decimal> TipoDeCambioAplicadoCaptura { get; set; }
        public Nullable<System.Guid> IdCatTipoControl { get; set; }
        public Nullable<System.Guid> IdCatMonedaPermiso { get; set; }
        public Nullable<System.Guid> IdCatIncoterm { get; set; }
        public string Declaracion { get; set; }
        public string FraccionImportacion { get; set; }
        public string FraccionArancelaria { get; set; }
        public Nullable<decimal> PrecioPermiso { get; set; }
        public Nullable<bool> RequierePermisoTramitadoPorProquifa { get; set; }
        public Nullable<bool> RequierePermisoTramitadoPorCliente { get; set; }
        public Nullable<bool> RequiereDocumentosAdicionales { get; set; }
        public Nullable<bool> RestriccionLogisticaInternadoPaisTransito { get; set; }
        public Nullable<int> NumeroDePiezas { get; set; }
        public System.Guid IdMarcaFamilia { get; set; }
        public Nullable<System.DateTime> FechaCaducidadPrecio { get; set; }
        public Nullable<System.DateTime> FechaCaducidadVigenciaCuraduria { get; set; }
        public Nullable<System.DateTime> FechaCaducidadRegistroSanitario { get; set; }
        public string Peligrosidad { get; set; }
        public Nullable<bool> TieneCAS { get; set; }
        public string Catalogo { get; set; }
        public Nullable<System.Guid> IdCatTipoDescargaProducto { get; set; }
        public Nullable<System.DateTime> FechaDisponibilidadBackOrder { get; set; }
        public string Presentacion { get; set; }
        public decimal BasePrecioLista { get; set; }
    }
}
