using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.VentaDigitalPQF.Dto.PriceOffert
{
    public class PriceOfferVDRequest
    {
        [Required( ErrorMessage = "IdProduct is required" )]
        public required Guid IdProduct { get; set; }
        [Required( ErrorMessage = "IdCustomer is required" )]
        public required Guid IdCustomer { get; set; }
        [Required( ErrorMessage = "IdDeliveryAddress is required" )]
        public required Guid IdDeliveryAddress { get; set; }
        [Required( ErrorMessage = "Pieces is required" )]
        public required int Pieces { get; set; }
    }
}
