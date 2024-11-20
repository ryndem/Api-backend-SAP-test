using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.VentaDigitalPQF.Dto.Product
{
    public class ProductRead
    {
        public System.Guid IdProduct { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public Nullable<System.Guid> IdAvailabilityCategory { get; set; }
        public Nullable<System.Guid> IDLineCategory { get; set; }
        public decimal ListPrice { get; set; }
        public Nullable<System.Guid> IdUnitCategory { get; set; }
        public bool ChargesVAT { get; set; }
        public System.DateTime RegistrationDate { get; set; }
        public Nullable<System.DateTime> ExpiryRegistrationDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public bool IsActive { get; set; }
        public Nullable<decimal> VATPercentage { get; set; }
        public Nullable<System.Guid> IdInformationClassificationCategory { get; set; }
        public bool CompleteInvestigation { get; set; }
        public bool Controlled { get; set; }
        public Nullable<System.Guid> IdCertificateFile { get; set; }
        public Nullable<System.Guid> IdInternationalDepositoryCategory { get; set; }
        public string InternationalDepositoryNumber { get; set; }
        public Nullable<System.Guid> IdSupplier { get; set; }
        public Nullable<System.Guid> IdFeatureGroupCategory { get; set; }
        public Nullable<decimal> SupplierListPriceCurrency { get; set; }
        public Nullable<decimal> AppliedExchangeRateOnCapture { get; set; }
        public Nullable<System.Guid> IdControlTypeCategory { get; set; }
        public Nullable<System.Guid> IdPermitCurrencyCategory { get; set; }
        public Nullable<System.Guid> IdIncotermCategory { get; set; }
        public string Declaration { get; set; }
        public string ImportFraction { get; set; }
        public string TariffFraction { get; set; }
        public Nullable<decimal> PermitPrice { get; set; }
        public Nullable<bool> RequiresPermitProcessedByProquifa { get; set; }
        public Nullable<bool> RequiresPermitProcessedByClient { get; set; }
        public Nullable<bool> RequiresAdditionalDocuments { get; set; }
        public Nullable<bool> LogisticRestrictionInboundTransitCountry { get; set; }
        public Nullable<int> NumberOfPieces { get; set; }
        public System.Guid BrandFamilyId { get; set; }
        public Nullable<System.DateTime> PriceExpiryDate { get; set; }
        public Nullable<System.DateTime> CuratorValidityExpiryDate { get; set; }
        public Nullable<System.DateTime> SanitaryRegistrationExpiryDate { get; set; }
        public string Hazard { get; set; }
        public Nullable<bool> HasCAS { get; set; }
        public string Catalog { get; set; }
        public Nullable<System.Guid> IdProductDownloadTypeCategory { get; set; }
        public Nullable<System.DateTime> IdBackOrderAvailabilityDate { get; set; }
        public string Presentation { get; set; }
        public decimal BaseListPrice { get; set; }
    }
}
