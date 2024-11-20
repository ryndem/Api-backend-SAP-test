namespace Core.VentaDigitalPQF.CrudTools
{
    public class QueryInfoVD
    {
        public string? SortField { get; set; }
        public string? SortDirection { get; set; }
        public List<FilterTupleVD>? Filters { get; set; }
        public List<SearchSuggestionVD>? Suggestions { get; set; }
        public int? PageSize { get; set; }
        public int? DesiredPage { get; set; }
    }
}
