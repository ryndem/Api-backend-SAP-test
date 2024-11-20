using Proxy.ProquifaDotNet.Model;

namespace Proxy.ProquifaDotNet.Model
{
    public class vProducto
    {
        //public Nullable<System.Guid> IdFamilia { get; set; }
        public System.Guid IdProducto { get; set; }
        public string? Catalogo { get; set; }
        public string? Descripcion { get; set; }
        public string? Nota { get; set; }
        public decimal PrecioLista { get; set; }
        public string? Presentacion { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public Nullable<System.DateTime> FechaCaducidadRegistro { get; set; }
        public System.DateTime FechaUltimaActualizacion { get; set; }
        public bool Activo { get; set; }
        public bool Controlado { get; set; }
        public string? NumeroDepositarioInternacional { get; set; }
        public Nullable<int> NumeroDePiezas { get; set; }
        public System.Guid IdMarcaFamilia { get; set; }
        public Nullable<System.DateTime> FechaCaducidadVigenciaCuraduria { get; set; }
        public string? Peligrosidad { get; set; }
        public Nullable<bool> TieneCAS { get; set; }
        public Nullable<System.Guid> IdProveedorPrincipal { get; set; }
        public string? NombreProveedor { get; set; }
        public Nullable<System.Guid> IdMarca { get; set; }
        public string? NombreMarca { get; set; }
        public string? Tipo { get; set; }
        public string? TipoProductoClave { get; set; }
        public string? Subtipo { get; set; }
        public string? SubtipoProductoClave { get; set; }
        public string? Control { get; set; }
        public string? ControlClave { get; set; }
        public string? Disponibilidad { get; set; }
        public string? Linea { get; set; }
        public string? Unidad { get; set; }
        public string? TipoPresentacion { get; set; }
        public string? TipoPresentacionClave { get; set; }
        public string? Aplicacion { get; set; }
        public string? MedioTransporte { get; set; }
        public string? ManejoTransporte { get; set; }
        public string? ManejoAlmacenaje { get; set; }
        public string? Uso { get; set; }
        public string? CAS { get; set; }
        public string? ATC { get; set; }
        public string? FormulaQuimica { get; set; }
        public string? FormulaMolecular { get; set; }
        private PrecioOferta _oferta = new PrecioOferta();
        public PrecioOferta oferta {
            get { return _oferta; }
            set {
                if ( value == null)
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
