using AutoMapper;
using Core.VentaDigitalPQF.Dto.Address;
using Core.VentaDigitalPQF.Dto.Client;
using Core.VentaDigitalPQF.Dto.User;
using Logic.VentaDigitalPQF.Interfaces.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.VentaDigitalPQF.Services.User
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        //DbContext

        public UserService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<UserDetails> GetByUserName(string userName)
        {
            return new UserDetails
            {
                IdUser = Guid.NewGuid(),
                FirstNameUser = "Javier",
                LastNameUser = "",
                UserName = userName,
                IdCustomer = Guid.NewGuid(),
                IdCatLanguage = Guid.NewGuid(),
                Department = "Departamento",
                Position = "Posicion",
                AcceptTerms = true,
                Authentication2FA = false,
                EmailUser = "user@rynedm.mx",
                PhoneNumberUser = "498498498498",
                IdContactPQF2 = Guid.NewGuid(),
                PasswordValidated = true,
                NameQustomer = "FARMACIAS JAVIER",
                AliasCustumer = "FARMACIAS JAVIER",
                Sector = "Sector",
                Industry = "Industria",
                TaxId = "AJUEOJDYURUVCN",
                PhoneNumberQustomer = "498498498498",
                FinalUser = true,
                Reseller = true,
                PaymentTerms = "30 Dias",
                Currency = "MXN",
                EmailEVI = "correoEVI@proquifa.com"
            };
        }

        public async Task<UserProfileDetails> GetUserDetails(UserRequest userRequest)
        {
            return new UserProfileDetails
            {
                IdUser = Guid.NewGuid(),
                FirstName = "User Name",
                LastName = "User Last Name",
                Email = "",
                Client = new ClientDetails
                {
                    ClientId = Guid.NewGuid(),
                    FirstName = "Client Name",
                    Phone = "498449849489",
                    Email = "client@client.com",
                    EmailEVI = "evi@ventas.com",
                    Address = new List<AddressDetails>() {
                        new AddressDetails
                        {
                            IdAddress = Guid.NewGuid(),
                            Address = "Direccion de entrega 1"
                        },
                        new AddressDetails
                        {
                            IdAddress = Guid.NewGuid(),
                            Address = "Direccion de entrega 2"
                        }
                    }
                }
            };
        }
    }
}
