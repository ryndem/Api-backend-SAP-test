//using Core.CrudTools.Optimization;
using Proxy.ProquifaDotNet.CrudTools;
using Proxy.ProquifaDotNet.Model;
using Proxy.ProquifaDotNet.Dto;
using Core.VentaDigitalPQF.Dto.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.ProquifaDotNet.Interfaces
{
    public interface IOfertaProductoProxy
    {
        Task<PrecioOferta> GetOfertaProducto( ProductoClienteVDRequest productoRequest );
        Task<PrecioOferta> GetOfertaProducto( ProductoClienteWebRequest productoRequest );
        Task<PrecioOferta> GetOfertaProducto( ProductoRequest productoRequest );
        Task<PrecioOferta> GetOfertaProducto( Guid IdProducto, Guid? IdCliente, Guid? IdDireccionEntrega, int? piezas = 1 );
    }
}
