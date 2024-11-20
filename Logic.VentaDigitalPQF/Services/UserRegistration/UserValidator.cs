using Core.VentaDigitalPQF.Dto.UserRegistration;
using Logic.VentaDigitalPQF.Interfaces.UserRegistration;

namespace Logic.VentaDigitalPQF.Services.UserRegistration
{
    public class UserValidatorService : IUserValidatorService
    {
        public async Task<string> ValidateUserAsync(ClientCreate userRegistrationCreate)
        {
            string status = "Error";

            if ((userRegistrationCreate.Email ?? "").Equals("juan.perez@example.com") && (userRegistrationCreate.TaxId ?? "").Equals("XAXX010101000"))
            {
                status = "Pendiente";
            }
            else if ((userRegistrationCreate.Email ?? "").Equals("maria.garcia@example.com") && (userRegistrationCreate.TaxId ?? "").Equals("BAXX020202000"))
            {
                status = "Validacion";
            }
            else if ((userRegistrationCreate.Email ?? "").Equals("luis.martinez@example.com") && (userRegistrationCreate.TaxId ?? "").Equals("CAXX030303000"))
            {
                status = "Exitoso";
            }

            return await Task.FromResult(status);
        }
    }
}
