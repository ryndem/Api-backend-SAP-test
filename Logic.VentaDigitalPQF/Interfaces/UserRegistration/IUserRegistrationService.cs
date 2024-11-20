using Core.VentaDigitalPQF.Dto.UserRegistration;

namespace Logic.VentaDigitalPQF.Interfaces.UserRegistration
{
    public interface IUserRegistrationService
    {
        Task<ClientResponse> GetUserRegistration(ClientCreate UserRegistrationCreate);
    }
    public interface IUserValidatorService
    {
        Task<string> ValidateUserAsync(ClientCreate userRegistrationCreate);
    }
}
