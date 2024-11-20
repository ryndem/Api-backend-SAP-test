using AutoMapper;
using Core.VentaDigitalPQF.Dto.SuggestedContact;
using Logic.VentaDigitalPQF.Interfaces.SuggestedContact;

namespace Logic.VentaDigitalPQF.Services.SuggestedContact
{
    public class SuggestedContactService : ISuggestedContactService
    {
        private readonly IMapper _mapper;
        private readonly ISuggestedContactProviderService _suggestedContactProviderService;

        public SuggestedContactService(IMapper mapper, ISuggestedContactProviderService suggestedContactProviderService)
        {
            _mapper = mapper;
            _suggestedContactProviderService = suggestedContactProviderService;
        }
        public async Task<SuggestedContactDetails> GetSuggestedContact(SuggestedContactRequest suggestedContactRequest)
        {
            var suggestedContactsList = await _suggestedContactProviderService.GetSuggestedContactsAsync();
            SuggestedContactDetails ClienteSugueridoSelecionado = new();

            foreach (var c in suggestedContactsList)
            {
                if ((c.Email ?? "").Equals(suggestedContactRequest.Email) && (c.TaxId ?? "").Equals(suggestedContactRequest.TaxId))
                {
                    ClienteSugueridoSelecionado = c;
                    break;
                }
            }

            return ClienteSugueridoSelecionado;
        }
    }
}
