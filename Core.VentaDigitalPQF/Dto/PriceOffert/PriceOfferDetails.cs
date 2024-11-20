using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.VentaDigitalPQF.Dto.PriceOffert
{
    public class PriceOfferDetails
    {
        //public Guid IdCustomer { get; set; }
        //public Guid IdProduct { get; set; }
        /*public Guid? IdCurrencyCategory { get; set; }*/
        public decimal Pieces { get; set; }
        public decimal UnitPrice { get; set; }
        public string? DeliveryTime { get; set; }
        public decimal DeliveryTimeDays { get; set; }
        public string? DeliveryTimeDate { get; set; }
        public bool AppliesPerPiece { get; set; }
        //public Guid? IdTimeDeliveryConfigurationValue { get; set; }
        //public Guid IdFamilyBrand { get; set; }

        /*public Guid IdSalesCurrency;*/
        //public Guid? IdSupplier { get; set; }
        //public decimal? PriceProquifaDotNet { get; set; }

        //public Nullable<System.Guid> IdPriceSupplierFamilyConfiguration { get; set; }
        //public Nullable<System.Guid> IdPriceCategoryUtilitySupplierConfiguration { get; set; }
        //public Nullable<System.Guid> IdSupplierCommissionConfiguration { get; set; }

        //public Boolean IsConfigured { get; set; }

        //public string? StockDeliveryTime { get; set; }
        //public Nullable<decimal> StockDeliveryTimeDays { get; set; }
        //public bool HasStock { get; set; }
        public Guid? IdDeliveryAddress { get; set; }
    }
}
