using Core.VentaDigitalPQF.Dto.SuggestedContact;

namespace Proxy.ProquifaDotNet.Services.Interfaces.SuggestedContact
{
    public interface ISuggestedContactProxy
    {
        Task<SuggestedContactDetails> GetSuggestedContact(SuggestedContactRequest SuggestedContactRequest);
    }
}
