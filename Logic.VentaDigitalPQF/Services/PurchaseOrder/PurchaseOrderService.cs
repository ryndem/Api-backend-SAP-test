using AutoMapper;
using Core.VentaDigitalPQF.CrudTools;
using Core.VentaDigitalPQF.Dto.Freight;
using Core.VentaDigitalPQF.Dto.PurchaseOrder;
using Core.VentaDigitalPQF.Dto.PurchaseOrder.PurchaseOrderItem;
using Core.VentaDigitalPQF.Dto.Quotation;
using Logic.VentaDigitalPQF.Interfaces.PurchaseOrder;

namespace Logic.VentaDigitalPQF.Services.PurchaseOrder
{
    public class PurchaseOrderService : IPurchaseOrderService
    {
        private readonly IMapper _mapper;
        public PurchaseOrderService(IMapper mapper) => _mapper = mapper;
        public async Task<PurchaseOrderDetails> GetPurchaseOrderDetails(Guid IdPurchaseOrder)
        {
            return await Task.FromResult(new PurchaseOrderDetails
            {
                IdPurchaseOrder = Guid.NewGuid(),
                Folio = "PO123456",
                Address = "123 Main St, Springfield",
                IdPurchaseOrderFile = Guid.NewGuid(),
                Subtotal = 5000,
                SaleTax = 800,
                Total = 5800,
                RegistrationDate = DateTime.Now,
                ListQuotation =
                [
                    new QuotationSummary
                    {
                        IdQuotation = Guid.NewGuid(),
                        Folio = "Q123",
                        IdfilePdf = Guid.NewGuid(),
                        RegistrationDate = DateTime.Now.AddDays(-10),
                        Items = 5,
                        Total = 2500,
                        ExpirationDate = DateTime.Now.AddDays(30),
                        Active = true
                    },
                    new QuotationSummary
                    {
                        IdQuotation = Guid.NewGuid(),
                        Folio = "Q124",
                        IdfilePdf = Guid.NewGuid(),
                        RegistrationDate = DateTime.Now.AddDays(-8),
                        Items = 3,
                        Total = 2500,
                        ExpirationDate = DateTime.Now.AddDays(28),
                        Active = true
                    }
                ],
                FreightExpressDetails = new FreightExpressDetails
                {
                    Amount = 200,
                    ItemCount = 10
                },
                FreightOutsiderDetails = new FreightOutsiderDetails
                {
                    Amount = 150,
                    ItemCount = 8
                }
            });
        }
        public async Task<QueryResultVD> GetListPurchaseOrder()
        {
            var response = await Task.FromResult(new List<PurchaseOrderSummary>
            {
                new()
                {
                    IdPurchaseOrder = Guid.NewGuid(),
                    Folio = "Q12345",
                    IdfilePdf = Guid.NewGuid(),
                    RegistrationDate = DateTime.Parse("2024-05-30T21:52:32.918Z"),
                    Items = 5,
                    Total = 5000
                },
                new() {
                    IdPurchaseOrder = Guid.NewGuid(),
                    Folio = "Q12346",
                    IdfilePdf = Guid.NewGuid(),
                    RegistrationDate = DateTime.Parse("2024-06-15T21:52:32.918Z"),
                    Items = 10,
                    Total = 10000
                },
                new() {
                    IdPurchaseOrder = Guid.NewGuid(),
                    Folio = "Q12347",
                    IdfilePdf = Guid.NewGuid(),
                    RegistrationDate = DateTime.Parse("2024-07-01T21:52:32.918Z"),
                    Items = 7,
                    Total = 7000
                }
            });
            QueryResultVD result = new()
            {
                Results = _mapper.Map<List<PurchaseOrderSummary>>(response),
                TotalResults = response.Count
            };
            return result;
        }
        public async Task<QueryResultVD> ListPurchaseOrderItemsDetails(QueryInfoVD Info)
        {
            var response = await Task.FromResult(new List<PurchaseOrderItemDetails>
            {
                new()
                {
                    IdPurchaseOrder = Guid.NewGuid(),
                    IdPurchaseOrderItem = Guid.NewGuid(),
                    IdQuotation = Guid.NewGuid(),
                    IdQuotationItem = Guid.NewGuid(),
                    Number = 1,
                    CAS = "123-45-6",
                    Catalog = "CAT001",
                    Type = "Chemical",
                    Description = "Chemical A",
                    UnitMeasure = "kg",
                    Quantity = 10,
                    UnitPrice = 20.5m,
                    WebPrice = 19.5m,
                    TEE = 5,
                    AppliesExpressFreight = true,
                    TotalPrice = 205m
                },
                new()
                {
                    IdPurchaseOrder = Guid.NewGuid(),
                    IdPurchaseOrderItem = Guid.NewGuid(),
                    IdQuotation = Guid.NewGuid(),
                    IdQuotationItem = Guid.NewGuid(),
                    Number = 2,
                    CAS = "789-01-2",
                    Catalog = "CAT002",
                    Type = "Chemical",
                    Description = "Chemical B",
                    UnitMeasure = "L",
                    Quantity = 20,
                    UnitPrice = 15.0m,
                    WebPrice = 14.0m,
                    TEE = 3,
                    AppliesExpressFreight = false,
                    TotalPrice = 300m
                },
                new()
                {
                    IdPurchaseOrder = Guid.NewGuid(),
                    IdPurchaseOrderItem = Guid.NewGuid(),
                    IdQuotation = Guid.NewGuid(),
                    IdQuotationItem = Guid.NewGuid(),
                    Number = 3,
                    CAS = "456-78-9",
                    Catalog = "CAT003",
                    Type = "Chemical",
                    Description = "Chemical C",
                    UnitMeasure = "g",
                    Quantity = 100,
                    UnitPrice = 1.5m,
                    WebPrice = 1.4m,
                    TEE = 2,
                    AppliesExpressFreight = true,
                    TotalPrice = 150m
                }
            });

            QueryResultVD result = new()
            {
                Results = _mapper.Map<List<PurchaseOrderItemDetails>>(response),
                TotalResults = response.Count
            };
            return result;
        }
    }
}
