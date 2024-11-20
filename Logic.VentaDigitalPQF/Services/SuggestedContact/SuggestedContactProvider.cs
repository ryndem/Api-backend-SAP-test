using Core.VentaDigitalPQF.Dto.SuggestedContact;
using Logic.VentaDigitalPQF.Interfaces.SuggestedContact;

namespace Logic.VentaDigitalPQF.Services.SuggestedContact
{
    public class SuggestedContactProviderService : ISuggestedContactProviderService
    {
        public async Task<List<SuggestedContactDetails>> GetSuggestedContactsAsync()
        {
            return await Task.FromResult(new List<SuggestedContactDetails>
        {
            new() {
                ClientId = Guid.NewGuid(),
                ContactId = Guid.NewGuid(),
                Sector = "Technology",
                Industry = "Software",
                TaxId = "XAXX010101000",
                FirstName = "Juan",
                LastName = "Pérez",
                Phone = "555-1234",
                Position = "Developer",
                Email = "juan.perez@example.com"
            },
            new() {
                ClientId = Guid.NewGuid(),
                ContactId = Guid.NewGuid(),
                Sector = "Health",
                Industry = "Pharmaceutical",
                TaxId = "BAXX020202000",
                FirstName = "María",
                LastName = "García",
                Phone = "555-5678",
                Position = "Sales Manager",
                Email = "maria.garcia@example.com"
            },
            new() {
                ClientId = Guid.NewGuid(),
                ContactId = Guid.NewGuid(),
                Sector = "Finance",
                Industry = "Banking",
                TaxId = "CAXX030303000",
                FirstName = "Luis",
                LastName = "Martínez",
                Phone = "555-9101",
                Position = "Financial Analyst",
                Email = "luis.martinez@example.com"
            },
            new() {
                ClientId = Guid.NewGuid(),
                ContactId = Guid.NewGuid(),
                Sector = "Education",
                Industry = "Universities",
                TaxId = "DAXX040404000",
                FirstName = "Ana",
                LastName = "López",
                Phone = "555-2345",
                Position = "Professor",
                Email = "ana.lopez@example.com"
            }
        });
        }
    }
}
