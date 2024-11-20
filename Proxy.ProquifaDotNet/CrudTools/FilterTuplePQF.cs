namespace Proxy.ProquifaDotNet.CrudTools
{
    public class FilterTuplePQF
    {
        public string NombreFiltro { get; set; }
        public string ValorFiltro { get; set; }
        public FilterTuplePQF( string Nombre, string Valor )
        {
            NombreFiltro = Nombre;
            ValorFiltro = Valor;
        }

        public Guid GuidValorFiltro()
        {
            if ( string.IsNullOrEmpty( ValorFiltro ) )
            {
                return Guid.Empty;
            }

            return Guid.Parse( ValorFiltro );
        }

        public DateTime DatetTimeValorFiltro()
        {
            return DateTimeOffset.Parse( ValorFiltro ).DateTime;
        }
        public List<string> ListaCSVValorFiltro()
        {
            if ( string.IsNullOrEmpty( ValorFiltro ) )
            {
                return new List<string> { "" };
            }

            if ( !ValorFiltro.Contains( "," ) )
            {
                return new List<string> { ValorFiltro };
            }

            return ValorFiltro.Split( ',' ).ToList();
        }

        public int IntValorFiltro()
        {
            if ( int.TryParse( ValorFiltro, out var result ) )
            {
                return result;
            }

            return 0;
        }
    }
}
