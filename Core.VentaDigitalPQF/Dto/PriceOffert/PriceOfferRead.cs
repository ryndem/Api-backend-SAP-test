using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.VentaDigitalPQF.Dto.PriceOffert
{
    public class PriceOfferRead
    {
        public decimal UnitPrice { get; set; }
        public string? StockDeliveryTime { get; set; }
        public Nullable<decimal> StockDeliveryTimeDays { get; set; }
        public bool HasStock { get; set; }
    }
}
