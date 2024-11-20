using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.VentaDigitalPQF.Dto.Product
{
    public class ProductResponse
    {
        public Guid? IdProduct { get; set; }
        public string Catalog { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime RegistrationDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public bool IsActive { get; set; }
    }
}
