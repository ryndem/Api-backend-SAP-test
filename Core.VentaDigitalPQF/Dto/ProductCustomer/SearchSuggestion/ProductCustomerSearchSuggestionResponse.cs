using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.VentaDigitalPQF.Dto.ProductCustomer.SearchSuggestion
{
    public class ProductCustomerSearchSuggestionResponse
    {
        public Guid IdProducto { get; set; }
        public string? Description { get; set; }
    }
}
