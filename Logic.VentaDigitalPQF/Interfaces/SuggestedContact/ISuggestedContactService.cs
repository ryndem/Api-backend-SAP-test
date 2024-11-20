using Core.VentaDigitalPQF.Dto.SuggestedContact;

namespace Logic.VentaDigitalPQF.Interfaces.SuggestedContact
{
    public interface ISuggestedContactService
    {
        Task<SuggestedContactDetails> GetSuggestedContact(SuggestedContactRequest SuggestedContactRequest);
    }
    public interface ISuggestedContactProviderService
    {
        Task<List<SuggestedContactDetails>> GetSuggestedContactsAsync();
    }
}
