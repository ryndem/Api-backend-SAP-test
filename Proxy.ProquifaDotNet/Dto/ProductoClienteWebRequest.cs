using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.ProquifaDotNet.Model
{
    public class ProductoClienteWebRequest
    {
        public Guid? IdProducto { get; set; }
        public Guid? IdCliente { get; set; }
        public Guid? IdDireccionEntrega { get; set; }

    }
}
