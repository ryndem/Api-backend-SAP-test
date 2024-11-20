using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.ProquifaDotNet.Dto
{
    public class ProductoRequest
    {
        public Guid? IdProducto { get; set; }
        public Guid? IdCliente { get; set; }
        public Guid? IdDireccionEntrega { get; set; }

    }
}
