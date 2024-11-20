namespace Core.Promsy.Models.Export
{
    public class InformacionCodigoPostal
    {
        public string Codigo { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Colonia { get; set; }

        public int? Precision { get; set; }
    }
}