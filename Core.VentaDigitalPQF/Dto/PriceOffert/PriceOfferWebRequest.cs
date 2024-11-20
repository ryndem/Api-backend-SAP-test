using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.VentaDigitalPQF.Dto.PriceOffert
{
    public class PriceOfferWebRequest
    {
        [Required( ErrorMessage = "IdProduct is required" )]
        public Guid IdProduct { get; set; }
        [Required( ErrorMessage = "Pieces is required" )]
        public int Pieces { get; set; }
    }
}
