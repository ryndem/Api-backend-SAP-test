using Core.VentaDigitalPQF.Dto.PriceOffert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.VentaDigitalPQF.Dto.Product
{
    public class ProductDetails
    {
        public System.Guid IdProduct { get; set; }
        public string? Catalog { get; set; }
        public string? Description { get; set; }
        public string? Note { get; set; }
        //public decimal ListPrice { get; set; }
        public string? Presentation { get; set; }
        public System.DateTime RegistrationDate { get; set; }
        public Nullable<System.DateTime> RegistrationExpirationDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public bool Active { get; set; }
        public bool Controlled { get; set; }
        public string? InternationalDepositNumber { get; set; }
        public Nullable<int> NumberOfPieces { get; set; }
        public System.Guid IdFamilyBrand { get; set; }
        public Nullable<System.DateTime> CuratorshipExpirationDate { get; set; }
        public string? Hazardousness { get; set; }
        public Nullable<bool> HasCASnumber { get; set; }
        public Nullable<System.Guid> IdMainSupplier { get; set; }
        public string? SupplierName { get; set; }
        //public Nullable<System.Guid> IdBrand { get; set; }
        public string? BrandName { get; set; }
        public string? Type { get; set; }
        public string? ProductTypeKey { get; set; }
        public string? Subtype { get; set; }
        public string? SubtypeKey { get; set; }
        public string? Control { get; set; }
        public string? ControlKey { get; set; }
        public string? Availability { get; set; }
        public string? Line { get; set; }
        public string? Unit { get; set; }
        public string? PresentationType { get; set; }
        public string? PresentationTypeKey { get; set; }
        public string? Application { get; set; }
        public string? Transport { get; set; }
        public string? TransportHandling { get; set; }
        public string? StorageHandling { get; set; }
        public string? Use { get; set; }
        public string? CASNumber { get; set; }
        public string? ATCcode { get; set; }
        public string? ChemicalFormula { get; set; }
        public string? MolecularFormula { get; set; }

        public virtual PriceOfferDetails Offert { get; set; }

        public ProductDetails()
        {
            Offert = new PriceOfferDetails();
        }
    }
}
