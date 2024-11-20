namespace Proxy.ProquifaDotNet.CrudTools
{
    public class QueryInfoPQF
    {
        public string? SortField { get; set; }
        public string? SortDirection { get; set; }
        public List<FilterTuplePQF> Filters { get; set; }
        public List<SearchSuggestionPQF>? Suggestions { get; set; }
        public int? PageSize { get; set; }
        public int? DesiredPage { get; set; }

        public QueryInfoPQF()
        {
            Filters = new List<FilterTuplePQF>();
        }
    }
}
