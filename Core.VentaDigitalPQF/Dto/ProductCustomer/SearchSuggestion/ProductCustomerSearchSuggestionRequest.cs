using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.VentaDigitalPQF.Dto.ProductCustomer.SearchSuggestion
{
    public class ProductCustomerSearchSuggestionRequest
    {
        public Guid? IdCustomer { get; set; }
        public string? Search { get; set; }
    }
}
