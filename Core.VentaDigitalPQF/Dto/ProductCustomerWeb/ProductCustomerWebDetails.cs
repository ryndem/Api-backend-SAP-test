using Core.VentaDigitalPQF.Dto.PriceOffert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.VentaDigitalPQF.Dto.ProductCustomerWeb
{
    public class ProductCustomerWebDetails
    {
        public System.Guid IdProduct { get; set; }
        public Nullable<System.Guid> IdCustomer { get; set; }
        //public System.Guid IdFamily { get; set; }
        public Nullable<bool> HasCAS { get; set; }
        public string? CAS { get; set; } // CAS remains the same
        public string? ATC { get; set; } // ATC remains the same
        public string? Catalog { get; set; }
        public string? Description { get; set; }
        public string? PresentationType { get; set; }
        public string? PresentationTypeKey { get; set; }
        public string? Presentation { get; set; }
        public string? TransportationMeans { get; set; }
        public string? TransportationMeansKey { get; set; }
        public string? TransportHandling { get; set; }
        public string? TransportHandlingKey { get; set; }
        public string? StorageHandling { get; set; }
        public string? StorageHandlingKey { get; set; }
        public string? ISBN { get; set; } // ISBN remains the same
        public string? BrandImageName { get; set; }
        public string? FamilyName { get; set; }
        public string? Type { get; set; }
        public string? TypeKey { get; set; }
        public string? BrandName { get; set; }
        public string? Availability { get; set; }
        public string? AvailabilityKey { get; set; }
        public string? Line { get; set; }
        public string? Unit { get; set; }
        public Nullable<decimal> Purity { get; set; }
        public bool HasExpressFreight { get; set; }
        public Nullable<bool> HasStock { get; set; }
        public Nullable<bool> AboutToExpire { get; set; }
        public Nullable<int> ExistingStockQuantity { get; set; }
        public Nullable<System.DateTime> StockExpirationDate { get; set; }
        public Nullable<decimal> EstimatedDeliveryTimeStock { get; set; }
        public virtual PriceOfferDetails Offert { get; set; }
        public ProductCustomerWebDetails()
        {
            Offert = new PriceOfferDetails();
        }
    }
}
