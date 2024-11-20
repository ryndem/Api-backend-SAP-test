using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.ProquifaDotNet.Model.Cotizacion
{
    public class cotCotizacion
    {
        public System.Guid IdCotCotizacion { get; set; }
        public string Folio { get; set; }
        public System.Guid IdCliente { get; set; }
        public System.Guid IdContactoCliente { get; set; }
        public Nullable<System.Guid> IdDatosFacturacionCliente { get; set; }
        public System.Guid IdCatCondicionesDePagoDeOrigen { get; set; }
        public int DiasDePagoDeOrigen { get; set; }
        public int DiasDePagoAdicionalesDeOrigen { get; set; }
        public System.Guid IdCatCondicionesDePago { get; set; }
        public int DiasDePagoAdicionales { get; set; }
        public System.Guid IdUsuarioTramita { get; set; }
        public Nullable<System.Guid> IdEmpresa { get; set; }
        public System.Guid IdCatEstadoCotizacion { get; set; }
        public Nullable<System.Guid> IdCatTipoCotizacion { get; set; }
        public Nullable<System.Guid> IdCatZona { get; set; }
        public Nullable<System.Guid> IdFlete { get; set; }
        public Nullable<bool> Enviado { get; set; }
        public bool Ajustada { get; set; }
        public System.DateTime FechaCotizacion { get; set; }
        public System.DateTime FechaCaducidad { get; set; }
        public Nullable<System.DateTime> FechaEnvio { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public System.DateTime FechaUltimaActualizacion { get; set; }
        public Nullable<System.Guid> IdSolicitudAutorizacionCambio { get; set; }
        public bool Activo { get; set; }
        public System.Guid IdCatMoneda { get; set; }
        public bool AgregarDatosFacturacion { get; set; }
        public string ComentarioFlete { get; set; }
        public Nullable<bool> FleteDesglosado { get; set; }
        public Nullable<decimal> montoFlete { get; set; }
        public Nullable<int> Consecutivo { get; set; }
        public Nullable<bool> Caducada { get; set; }
        public Nullable<System.Guid> IdAjOfEstrategiaCotizacion { get; set; }
        public Nullable<System.Guid> IdArchivoPDF { get; set; }
        public Nullable<System.Guid> IdCorreoRecibidoCliente { get; set; }
        public Nullable<System.Guid> IdCorreoRecibidoClienteReferencia { get; set; }
        public string FolioPublicaciones { get; set; }
        public Nullable<System.Guid> IdEmpresaPublicaciones { get; set; }
        public Nullable<System.Guid> IdCotCotizacionOriginal { get; set; }
        public Nullable<bool> EntregaUnica { get; set; }
        public Nullable<System.Guid> IdDireccion { get; set; }
        public Nullable<System.Guid> IdPPPedidoIntramitable { get; set; }
        public Nullable<System.Guid> IdEmpleadoRepresentanteLegal { get; set; }
        public bool CotizacionDeInvestigacion { get; set; }
        public bool EnviadaConInvestigacion { get; set; }
        public bool SeGuardanPartidasInvestigacion { get; set; }
    }
}
