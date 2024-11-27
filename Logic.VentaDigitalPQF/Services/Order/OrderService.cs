using AutoMapper;
using Core.VentaDigitalPQF.CrudTools;
using Core.VentaDigitalPQF.Dto.Order;
using Core.VentaDigitalPQF.Dto.Order.OrderItem;
using Logic.VentaDigitalPQF.Interfaces.Order;

namespace Logic.VentaDigitalPQF.Services.Order
{
    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        public OrderService(IMapper mapper) => _mapper = mapper;

        public async Task<OrderDetails> GetOrderDetails(Guid IdOrder)
        {
            return await Task.FromResult(new OrderDetails
            {
                IdOrder = Guid.NewGuid(),
                IdOrderFile = Guid.NewGuid(),
                Status = "Delivered",
                IdPurchaseOrder = Guid.NewGuid(),
                Folio = "PO123456",
                Address = "123 Main St, Springfield",
                IdPurchaseOrderFile = Guid.NewGuid(),
                Subtotal = 10000,
                SaleTax = 1600,
                Total = 11600,
                RegistrationDate = DateTime.Now,
                ListQuotation =
                [
                    new ()
                    {
                        IdQuotation = Guid.NewGuid(),
                        Folio = "Q123",
                        IdfilePdf = Guid.NewGuid(),
                        RegistrationDate = DateTime.Now.AddDays(-10),
                        Items = 5,
                        Total = 5000,
                        ExpirationDate = DateTime.Now.AddDays(30),
                        Active = true
                    },
                    new()
                    {
                        IdQuotation = Guid.NewGuid(),
                        Folio = "Q124",
                        IdfilePdf = Guid.NewGuid(),
                        RegistrationDate = DateTime.Now.AddDays(-8),
                        Items = 3,
                        Total = 3000,
                        ExpirationDate = DateTime.Now.AddDays(28),
                        Active = true
                    }
                ],
                FreightExpressDetails = new()
                {
                    Amount = 200,
                    ItemCount = 10
                },
                FreightOutsiderDetails = new()
                {
                    Amount = 150,
                    ItemCount = 8
                }
            });
        }
        public async Task<QueryResultVD> GetListOrder()
        {
            var response = await Task.FromResult(new List<OrderSummary>
                {
                new()
                {
                    IdOrder = Guid.NewGuid(),
                    Folio = "Folio11111",
                    IdfilePdf = Guid.NewGuid(),
                    RegistrationDate = DateTime.Now.AddDays(-30),
                    Items = 5,
                    Total = 500
                },
                new()
                {
                    IdOrder = Guid.NewGuid(),
                    Folio = "Folio2222",
                    IdfilePdf = Guid.NewGuid(),
                    RegistrationDate = DateTime.Now.AddDays(-29),
                    Items = 10,
                    Total = 1000
                },
                new()
                {
                    IdOrder = Guid.NewGuid(),
                    Folio = "Folio3",
                    IdfilePdf = Guid.NewGuid(),
                    RegistrationDate = DateTime.Now.AddDays(-28),
                    Items = 15,
                    Total = 1500
                },
                new()
                {
                    IdOrder = Guid.NewGuid(),
                    Folio = "Folio4",
                    IdfilePdf = Guid.NewGuid(),
                    RegistrationDate = DateTime.Now.AddDays(-27),
                    Items = 20,
                    Total = 2000
                },
                new()
                {
                    IdOrder = Guid.NewGuid(),
                    Folio = "Folio5",
                    IdfilePdf = Guid.NewGuid(),
                    RegistrationDate = DateTime.Now.AddDays(-26),
                    Items = 25,
                    Total = 2500
                },
                new()
                {
                    IdOrder = Guid.NewGuid(),
                    Folio = "Folio6",
                    IdfilePdf = Guid.NewGuid(),
                    RegistrationDate = DateTime.Now.AddDays(-25),
                    Items = 30,
                    Total = 3000
                },
                new()
                {
                    IdOrder = Guid.NewGuid(),
                    Folio = "Folio7",
                    IdfilePdf = Guid.NewGuid(),
                    RegistrationDate = DateTime.Now.AddDays(-24),
                    Items = 35,
                    Total = 3500
                },
                new()
                {
                    IdOrder = Guid.NewGuid(),
                    Folio = "Folio8",
                    IdfilePdf = Guid.NewGuid(),
                    RegistrationDate = DateTime.Now.AddDays(-23),
                    Items = 40,
                    Total = 4000
                },
                new()
                {
                    IdOrder = Guid.NewGuid(),
                    Folio = "Folio9",
                    IdfilePdf = Guid.NewGuid(),
                    RegistrationDate = DateTime.Now.AddDays(-22),
                    Items = 45,
                    Total = 4500
                },
                new()
                {
                    IdOrder = Guid.NewGuid(),
                    Folio = "Folio10",
                    IdfilePdf = Guid.NewGuid(),
                    RegistrationDate = DateTime.Now.AddDays(-21),
                    Items = 50,
                    Total = 5000
                }
            });
            QueryResultVD result = new()
            {
                Results = _mapper.Map<List<OrderSummary>>(response),
                TotalResults = response.Count
            };
            return result;
        }
        public async Task<QueryResultVD> ListOrderItemsDetails(QueryInfoVD Info)
        {
            var response = await Task.FromResult(new List<OrderItemDetails>
            {
                new() {
                    IdOrder = Guid.NewGuid(),
                    IdOrderItem = Guid.NewGuid(),
                    IdPurchaseOrder = Guid.NewGuid(),
                    IdPurchaseOrderItem = Guid.NewGuid(),
                    IdQuotation = Guid.NewGuid(),
                    IdQuotationItem = Guid.NewGuid(),
                    Number = 1,
                    CAS = "50-00-0",
                    Catalog = "Chem123",
                    Type = "Chemical",
                    Description = "Formaldehyde",
                    UnitMeasure = "Liters",
                    Quantity = 100,
                    UnitPrice = 15.50m,
                    WebPrice = 14.00m,
                    TEE = 1,
                    AppliesExpressFreight = true,
                    TotalPrice = 1500.00m,
                    DeliveryStatusDetails = new()
                    {
                        OrderConfirmed = true,
                        OrderConfirmedDate = DateTime.Now.AddDays(-10),
                        OrderInTransit = true,
                        OrderInTransitDate = DateTime.Now.AddDays(-5),
                        ProductShipped = true,
                        ProductShippedDate = DateTime.Now.AddDays(-3),
                        InTransit = true,
                        InTransitDate = DateTime.Now.AddDays(-1),
                        OrderDelivered = false
                    }
                },
                new() {
                    IdOrder = Guid.NewGuid(),
                    IdOrderItem = Guid.NewGuid(),
                    IdPurchaseOrder = Guid.NewGuid(),
                    IdPurchaseOrderItem = Guid.NewGuid(),
                    IdQuotation = Guid.NewGuid(),
                    IdQuotationItem = Guid.NewGuid(),
                    Number = 2,
                    CAS = "60-00-1",
                    Catalog = "Chem124",
                    Type = "Chemical",
                    Description = "Acetic Acid",
                    UnitMeasure = "Gallons",
                    Quantity = 50,
                    UnitPrice = 20.00m,
                    WebPrice = 18.00m,
                    TEE = 1,
                    AppliesExpressFreight = false,
                    TotalPrice = 1000.00m,
                    DeliveryStatusDetails = new()
                    {
                        OrderConfirmed = true,
                        OrderConfirmedDate = DateTime.Now.AddDays(-12),
                        OrderInTransit = true,
                        OrderInTransitDate = DateTime.Now.AddDays(-7),
                        ProductShipped = true,
                        ProductShippedDate = DateTime.Now.AddDays(-4),
                        InTransit = false,
                        OrderDelivered = false
                    }
                },
                new() {
                    IdOrder = Guid.NewGuid(),
                    IdOrderItem = Guid.NewGuid(),
                    IdPurchaseOrder = Guid.NewGuid(),
                    IdPurchaseOrderItem = Guid.NewGuid(),
                    IdQuotation = Guid.NewGuid(),
                    IdQuotationItem = Guid.NewGuid(),
                    Number = 3,
                    CAS = "70-00-2",
                    Catalog = "Chem125",
                    Type = "Chemical",
                    Description = "Ethanol",
                    UnitMeasure = "Liters",
                    Quantity = 200,
                    UnitPrice = 25.00m,
                    WebPrice = 23.00m,
                    TEE = 1,
                    AppliesExpressFreight = true,
                    TotalPrice = 5000.00m,
                    DeliveryStatusDetails = new()
                    {
                        OrderConfirmed = true,
                        OrderConfirmedDate = DateTime.Now.AddDays(-15),
                        OrderInTransit = true,
                        OrderInTransitDate = DateTime.Now.AddDays(-10),
                        ProductShipped = true,
                        ProductShippedDate = DateTime.Now.AddDays(-7),
                        InTransit = true,
                        InTransitDate = DateTime.Now.AddDays(-2),
                        OrderDelivered = false,
                        OrderDeliveredDate = null
                    }
                },
                new() {
                    IdOrder = Guid.NewGuid(),
                    IdOrderItem = Guid.NewGuid(),
                    IdPurchaseOrder = Guid.NewGuid(),
                    IdPurchaseOrderItem = Guid.NewGuid(),
                    IdQuotation = Guid.NewGuid(),
                    IdQuotationItem = Guid.NewGuid(),
                    Number = 4,
                    CAS = "80-00-3",
                    Catalog = "Chem126",
                    Type = "Chemical",
                    Description = "Methanol",
                    UnitMeasure = "Gallons",
                    Quantity = 150,
                    UnitPrice = 30.00m,
                    WebPrice = 28.00m,
                    TEE = 1,
                    AppliesExpressFreight = false,
                    TotalPrice = 4500.00m,
                    DeliveryStatusDetails = new()
                    {
                        OrderConfirmed = true,
                        OrderConfirmedDate = DateTime.Now.AddDays(-20),
                        OrderInTransit = true,
                        OrderInTransitDate = DateTime.Now.AddDays(-15),
                        ProductShipped = true,
                        ProductShippedDate = DateTime.Now.AddDays(-10),
                        InTransit = true,
                        InTransitDate = DateTime.Now.AddDays(-5),
                        OrderDelivered = false,
                        OrderDeliveredDate = null
                    }
                },
                new() {
                    IdOrder = Guid.NewGuid(),
                    IdOrderItem = Guid.NewGuid(),
                    IdPurchaseOrder = Guid.NewGuid(),
                    IdPurchaseOrderItem = Guid.NewGuid(),
                    IdQuotation = Guid.NewGuid(),
                    IdQuotationItem = Guid.NewGuid(),
                    Number = 5,
                    CAS = "90-00-4",
                    Catalog = "Chem127",
                    Type = "Chemical",
                    Description = "Chloroform",
                    UnitMeasure = "Liters",
                    Quantity = 300,
                    UnitPrice = 40.00m,
                    WebPrice = 38.00m,
                    TEE = 1,
                    AppliesExpressFreight = true,
                    TotalPrice = 12000.00m,
                    DeliveryStatusDetails = new()
                    {
                        OrderConfirmed = true,
                        OrderConfirmedDate = DateTime.Now.AddDays(-25),
                        OrderInTransit = true,
                        OrderInTransitDate = DateTime.Now.AddDays(-20),
                        ProductShipped = true,
                        ProductShippedDate = DateTime.Now.AddDays(-15),
                        InTransit = false,
                        InTransitDate = null,
                        OrderDelivered = false,
                        OrderDeliveredDate = null
                    }
                }
            });

            QueryResultVD result = new()
            {
                Results = _mapper.Map<List<OrderItemDetails>>(response),
                TotalResults = response.Count
            };
            return result;
        }
    }
}
