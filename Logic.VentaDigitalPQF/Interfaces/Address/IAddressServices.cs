using Core.VentaDigitalPQF.CrudTools;

namespace Logic.VentaDigitalPQF.Interfaces.Address
{
    public interface IAddressServices
    {
        Task<QueryResultVD> GetAddressDetails(QueryInfoVD Info);
    }
}
