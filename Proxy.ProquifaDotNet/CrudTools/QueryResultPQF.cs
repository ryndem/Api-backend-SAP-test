namespace Proxy.ProquifaDotNet.CrudTools
{
    public class QueryResultVD<T>
    {
        public int TotalResults { get; set; }

        public List<T> Results { get; set; }
        public QueryResultVD()
        {
            Results = new List<T>();
        }
    }
}
