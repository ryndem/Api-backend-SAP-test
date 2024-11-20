using Core.VentaDigitalPQF.Dto.UserRegistration;

namespace Proxy.ProquifaDotNet.Services.Interfaces.UserRegistration
{
    public interface IUserRegistrationProxy
    {
        Task<ClientResponse> GetUserRegistration(ClientCreate UserRegistrationCreate);
    }
}
