using AutoMapper;
using Logic.VentaDigitalPQF.AutoMapper.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace Logic.VentaDigitalPQF.AutoMapper
{
    public static class ServiceCollectionExtensions
    {
        public static void AddAutoMapperService(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ProductProfile());
                mc.AddProfile(new UserProfile());
                mc.AddProfile(new ProductCustomerProfile());
                mc.AddProfile(new ProductCustomerWebProfile());
                mc.AddProfile(new AddressProfile());
                mc.AddProfile( new CrudToolsProfile() );
            } );
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
