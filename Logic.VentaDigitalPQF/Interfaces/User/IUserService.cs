using Core.VentaDigitalPQF.Dto.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.VentaDigitalPQF.Interfaces.User
{
    public interface IUserService
    {
        Task<UserProfileDetails> GetUserDetails(UserRequest userRequest);
        Task<UserDetails> GetByUserName(string userName);
    }
}
