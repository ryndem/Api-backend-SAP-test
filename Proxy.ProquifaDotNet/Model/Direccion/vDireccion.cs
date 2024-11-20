namespace Proxy.ProquifaDotNet.Model.Direccion
{
    public class vDireccion
    {
        public Guid IdDireccion { get; set; }

        public Guid? IdCatTipoDireccion { get; set; }

        public Guid? IdCatRutaEntrega { get; set; }

        public Guid? IdCatZona { get; set; }

        public string? DireccionTextoUno { get; set; }

        public string? DireccionTextoDos { get; set; }

        public bool? UsaFormatoEnTexto { get; set; }

        public string? TipoRegion { get; set; }

        public string? Calle { get; set; }

        public string? NumeroInterior { get; set; }

        public string? NumeroExterior { get; set; }

        public string? Colonia { get; set; }

        public string? Ciudad { get; set; }

        public string? Municipio { get; set; }

        public string? Estado { get; set; }

        public string? CodigoPostal { get; set; }

        public Guid IdCatPais { get; set; }

        public decimal? Latitud { get; set; }

        public decimal? Longitud { get; set; }

        public bool? RequiereCita { get; set; }

        public DateTime FechaRegistro { get; set; }

        public DateTime FechaUltimaActualizacion { get; set; }

        public bool Activo { get; set; }

        public bool PagaGuiaEnvio { get; set; }

        public bool? AceptaParcialesPorLinea { get; set; }

        public bool? AceptaParciales { get; set; }

        public bool? EsMensajeriaInterna { get; set; }

        public string? DescripcionZona { get; set; }

        public string? ClaveZona { get; set; }

        public string? DescripcionRutaEntrega { get; set; }

        public string? ClaveRutaEntrega { get; set; }

        public string? DescripcionTipoDireccion { get; set; }

        public string? ClaveTipoDireccion { get; set; }

        public Guid IdCliente { get; set; }

        public string? DireccionCompleta { get; set; }

        public string? NombreEspanol { get; set; }

        public string? NombreIngles { get; set; }

        public Guid IdDireccionCliente { get; set; }

        public bool? DireccionRecogeEnProquifa { get; set; }
    }
}
