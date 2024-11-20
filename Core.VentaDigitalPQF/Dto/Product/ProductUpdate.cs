using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.VentaDigitalPQF.Dto.Product
{
    public class ProductUpdate
    {
        public System.Guid IdProduct { get; set; }
        public string? Description { get; set; }
    }
}
