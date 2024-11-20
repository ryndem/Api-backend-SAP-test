using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.VentaDigitalPQF.Dto.Product
{
    public class ProductCustomerRequest
    {
        public Guid? IdProduct { get; set; }
        public Guid? IdCustomer { get; set; }
        public Guid? IdDeliveryAddress { get; set; }
    }
}
