using AutoMapper;
using Core.VentaDigitalPQF.Dto.UserRegistration;
using Logic.VentaDigitalPQF.Interfaces.UserRegistration;

namespace Logic.VentaDigitalPQF.Services.UserRegistration
{
    public class UserRegistrationService : IUserRegistrationService
    {
        private readonly IMapper _mapper;
        private readonly IUserValidatorService _userValidatorService;

        public UserRegistrationService(IMapper mapper, IUserValidatorService userValidatorService)
        {
            _mapper = mapper;
            _userValidatorService = userValidatorService;
        }

        public async Task<ClientResponse> GetUserRegistration(ClientCreate userRegistrationCreate)
        {
            string status = await _userValidatorService.ValidateUserAsync(userRegistrationCreate);
            ClientResponse userRegistrationResponse = new()
            {
                Email = userRegistrationCreate.Email,
                Status = status
            };

            return userRegistrationResponse;
        }
    }
}
