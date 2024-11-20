using AutoMapper;
using Core.VentaDigitalPQF.CrudTools;
using Core.VentaDigitalPQF.Dto.Freight;
using Core.VentaDigitalPQF.Dto.Quotation;
using Core.VentaDigitalPQF.Dto.Quotation.QuotationItem;
using Logic.VentaDigitalPQF.Interfaces.Quotation;

namespace Logic.VentaDigitalPQF.Services.Quotation
{
    public class QuotationService : IQuotationService
    {
        private readonly IMapper _mapper;
        public QuotationService(IMapper mapper) => _mapper = mapper;
        public async Task<QuotationSendResponse> GetShoppingCart()
        {
            return await Task.FromResult(GMQuotationSendResponseTemp);
        }
        public async Task<QuotationItemDetails> PutShoppingCart(QuotationItemSCarRequest QuotationItemSCarRequest)
        {
            return await Task.FromResult(new QuotationItemDetails()
            {
                IdQuotationItem = Guid.NewGuid(),
                Number = 1,
                CAS = "123-45-6",
                Catalog = "CAT001",
                Type = "TypeA",
                Description = "Item Description 1",
                UnitMeasure = "kg",
                Quantity = 10,
                UnitPrice = 100,
                WebPrice = 90,
                TEE = 5,
                AppliesExpressFreight = true
            });
        }
        public async Task<QuotationRefreshResponse> RefreshShoppingCart(QuotationRefreshRequets GMQuotationRefreshRequets)
        {
            return await Task.FromResult(new QuotationRefreshResponse()
            {
                IdQuotation = Guid.NewGuid(),
                Subtotal = 1000,
                SaleTax = 160,
                Total = 1160,
                listquotationItemRefreshResponses = [
                    new()
                    {
                        IdQuotationItem = Guid.NewGuid(),
                        Quantity = 5,           // Ejemplo de cantidad
                        TotalPrice = 123.45M    // Ejemplo de precio total
                    },
                    new()
                    {
                        IdQuotationItem = Guid.NewGuid(),
                        Quantity = 5,           // Ejemplo de cantidad
                        TotalPrice = 123.45M    // Ejemplo de precio total
                    },
                    new()
                    {
                        IdQuotationItem = Guid.NewGuid(),
                        Quantity = 5,           // Ejemplo de cantidad
                        TotalPrice = 123.45M    // Ejemplo de precio total
                    }
                ],
                FreightExpressDetails = new FreightExpressDetails
                {
                    Amount = 500,
                    ItemCount = 5
                },
                FreightOutsiderDetails = new FreightOutsiderDetails
                {
                    Amount = 750,
                    ItemCount = 3
                }

            });
        }
        public async Task<QuotationSendResponse> SendQuotation(QuotationRefreshRequets GMQuotationRefreshRequets)
        {
            return await Task.FromResult(GMQuotationSendResponseTemp);
        }
        public async Task<QueryResultVD> Post()
        {
            var response = await Task.FromResult(new List<QuotationDetails>
            {
                QuotationDetailsT,
                QuotationDetailsT,
                QuotationDetailsT
            });
            QueryResultVD result = new()
            {
                Results = _mapper.Map<List<QuotationDetails>>(response),
                TotalResults = response.Count
            };
            return result;

        }
        public async Task<QuotationSendResponse> Get(Guid IdQuotation)
        {
            return await Task.FromResult(GMQuotationSendResponseTemp);
        }
        public async Task<QueryResultVD> GetListQuotation()
        {
            var response = await Task.FromResult(new List<QuotationSummary>
            {
                new()
                {
                    IdQuotation = Guid.NewGuid(),
                    Folio = "Q12345",
                    IdfilePdf = Guid.NewGuid(),
                    ExpirationDate = DateTime.Parse("2024-06-30T21:52:32.918Z"),
                    RegistrationDate = DateTime.Parse("2024-05-30T21:52:32.918Z"),
                    Active = true,
                    Items = 5,
                    Total = 5000
                },
                new() {
                    IdQuotation = Guid.NewGuid(),
                    Folio = "Q12346",
                    IdfilePdf = Guid.NewGuid(),
                    ExpirationDate = DateTime.Parse("2024-07-15T21:52:32.918Z"),
                    RegistrationDate = DateTime.Parse("2024-06-15T21:52:32.918Z"),
                    Active = true,
                    Items = 10,
                    Total = 10000
                },
                new() {
                    IdQuotation = Guid.NewGuid(),
                    Folio = "Q12347",
                    IdfilePdf = Guid.NewGuid(),
                    ExpirationDate = DateTime.Parse("2024-08-01T21:52:32.918Z"),
                    RegistrationDate = DateTime.Parse("2024-07-01T21:52:32.918Z"),
                    Active = false,
                    Items = 7,
                    Total = 7000
                }
            });
            QueryResultVD result = new()
            {
                Results = _mapper.Map<List<QuotationSummary>>(response),
                TotalResults = response.Count
            };
            return result;
        }

        public async Task<QueryResultVD> ListQuotationItemsDetails(QueryInfoVD info)
        {
            var response = await Task.FromResult(new List<QuotationItemDetails> {
                new QuotationItemDetails
                {
                    IdQuotation = Guid.NewGuid(),
                    IdQuotationItem = Guid.NewGuid(),
                    Number = 1,
                    CAS = "123-45-6",
                    Catalog = "CAT-001",
                    Type = "Chemical",
                    Description = "Example chemical 1",
                    UnitMeasure = "kg",
                    Quantity = 10,
                    UnitPrice = 15.0M,
                    WebPrice = 12.0M,
                    TEE = 3,
                    AppliesExpressFreight = true,
                    TotalPrice = 150.0M
                },
                new QuotationItemDetails
                {
                    IdQuotation = Guid.NewGuid(),
                    IdQuotationItem = Guid.NewGuid(),
                    Number = 2,
                    CAS = "789-12-3",
                    Catalog = "CAT-002",
                    Type = "Chemical",
                    Description = "Example chemical 2",
                    UnitMeasure = "L",
                    Quantity = 5,
                    UnitPrice = 20.0M,
                    WebPrice = 18.0M,
                    TEE = 2,
                    AppliesExpressFreight = false,
                    TotalPrice = 100.0M
                },
                new QuotationItemDetails
                {
                    IdQuotation = Guid.NewGuid(),
                    IdQuotationItem = Guid.NewGuid(),
                    Number = 3,
                    CAS = "456-78-9",
                    Catalog = "CAT-003",
                    Type = "Chemical",
                    Description = "Example chemical 3",
                    UnitMeasure = "unit",
                    Quantity = 20,
                    UnitPrice = 10.0M,
                    WebPrice = 8.0M,
                    TEE = 1,
                    AppliesExpressFreight = true,
                    TotalPrice = 200.0M
                }
            });

            QueryResultVD result = new()
            {
                Results = _mapper.Map<List<QuotationItemDetails>>(response),
                TotalResults = response.Count
            };

            return result;
        }

        //Objetos Temporales
        private readonly QuotationDetails QuotationDetailsT = new()
        {
            IdQuotation = Guid.NewGuid(),
            Folio = "Q12345",
            ClientId = Guid.NewGuid(),
            IdfilePdf = Guid.NewGuid(),
            PaymentTerms = "30 days",
            ExpirationDate = DateTime.Now.AddDays(30),
            RegistrationDate = DateTime.Now,
            Currency = "USD",
            Active = true,
            SaleTax = 160,
            Total = 1160
        };
        private readonly QuotationSendResponse GMQuotationSendResponseTemp = new()
        {
            QuotationDetails = new()
            {
                IdQuotation = Guid.NewGuid(),
                Folio = "Q12345",
                ClientId = Guid.NewGuid(),
                IdfilePdf = Guid.NewGuid(),
                PaymentTerms = "30 days",
                ExpirationDate = DateTime.Now.AddDays(30),
                RegistrationDate = DateTime.Now,
                Currency = "USD",
                Active = true,
                SaleTax = 160,
                Total = 1160
            },
            ListQuotationItem =
                [
                    new() {
                        IdQuotationItem = Guid.NewGuid(),
                        Number = 1,
                        CAS = "123-45-6",
                        Catalog = "CAT001",
                        Type = "TypeA",
                        Description = "Item Description 1",
                        UnitMeasure = "kg",
                        Quantity = 10,
                        UnitPrice = 100,
                        WebPrice = 90,
                        TEE = 5,
                        AppliesExpressFreight = true
                    },
                    new() {
                        IdQuotationItem = Guid.NewGuid(),
                        Number = 2,
                        CAS = "789-01-2",
                        Catalog = "CAT002",
                        Type = "TypeB",
                        Description = "Item Description 2",
                        UnitMeasure = "kg",
                        Quantity = 20,
                        UnitPrice = 200,
                        WebPrice = 180,
                        TEE = 10,
                        AppliesExpressFreight = false
                    }
                ],
            FreightExpressDetails = new()
            {
                Amount = 50,
                ItemCount = 2
            },
            FreightOutsiderDetails = new()
            {
                Amount = 75,
                ItemCount = 3
            }
        };
    }
}
