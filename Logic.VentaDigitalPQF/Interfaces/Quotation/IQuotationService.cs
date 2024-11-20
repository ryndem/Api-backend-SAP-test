using Core.VentaDigitalPQF.CrudTools;
using Core.VentaDigitalPQF.Dto.Quotation;
using Core.VentaDigitalPQF.Dto.Quotation.QuotationItem;

namespace Logic.VentaDigitalPQF.Interfaces.Quotation
{
    public interface IQuotationService
    {
        Task<QuotationSendResponse> GetShoppingCart();
        Task<QuotationItemDetails> PutShoppingCart(QuotationItemSCarRequest QuotationItemSCarRequest);
        Task<QuotationRefreshResponse> RefreshShoppingCart(QuotationRefreshRequets GMQuotationRefreshRequets);
        Task<QuotationSendResponse> SendQuotation(QuotationRefreshRequets GMQuotationRefreshRequets);
        Task<QueryResultVD> Post();
        Task<QuotationSendResponse> Get(Guid IdQuotation);
        Task<QueryResultVD> GetListQuotation();
        Task<QueryResultVD> ListQuotationItemsDetails(QueryInfoVD Info);
    }
}
