using AutoMapper;
using Core.VentaDigitalPQF.CrudTools;
using Core.VentaDigitalPQF.Dto.Address;
using Proxy.ProquifaDotNet.CrudTools;
using Proxy.ProquifaDotNet.Model.Direccion;

namespace Logic.VentaDigitalPQF.AutoMapper.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<vDireccion, AddressDetails>()
                .ForMember(dst => dst.IdAddress, opt => opt.MapFrom(src => src.IdDireccion))
                .ForMember(dst => dst.Address, opt => opt.MapFrom(src => src.DireccionCompleta))
                .ForMember(dst => dst.AcceptPartials, opt => opt.MapFrom(src => src.AceptaParciales));

            CreateMap<QueryResultVD<vDireccion>, QueryResultVD>()
               .ForMember(dst => dst.Results, opt => opt.MapFrom(src => src.Results))
               .ForMember(dst => dst.TotalResults, opt => opt.MapFrom(src => src.TotalResults));
        }
    }
}
