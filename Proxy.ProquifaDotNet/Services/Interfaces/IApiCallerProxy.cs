//using Core.CrudTools.Optimization;
using Proxy.ProquifaDotNet.CrudTools;
using Proxy.ProquifaDotNet.Model;
using Core.VentaDigitalPQF.Dto.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proxy.ProquifaDotNet.Dto;
//using Core.CrudTools.ModelBOs;

namespace Proxy.ProquifaDotNet.Interfaces
{
    public class ObjetoGenerico<T>
    {
        T objeto { get; set; }
        public ObjetoGenerico( T _objeto )
        {
            objeto = _objeto;
        }
    }
    public interface IApiCallerProxy
    {
        Task<string> Get( string Controller, string CampoLlave, Guid IdGuid, int ApiSelector );
        Task<string> Get( string Controller, object? GetParametros, int ApiSelector );
        Task<string> Post( string Controller, object? info, object? GetParametros, int ApiSelector );
        Task<string> Put( string Controller, object? FromBody, object? GetParametros, int ApiSelector );
        Task<string> Delete( string Controller, string CampoLlave, Guid IdGuid, int ApiSelector );
        Task<string> Patch( string Controller, object? FromBody, object? GetParametros, int ApiSelector );
    }
}
