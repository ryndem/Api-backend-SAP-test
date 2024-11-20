using Core.VentaDigitalPQF.CrudTools;
using Proxy.ProquifaDotNet.CrudTools;
using Proxy.ProquifaDotNet.Model.Direccion;

namespace Proxy.ProquifaDotNet.Services.Interfaces.Direccion
{
    public interface IDireccionProxy
    {
        Task<QueryResultVD<vDireccion>> GetDirecciones(QueryInfoVD Info);
    }
}
