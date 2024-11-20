using AutoMapper;
using Core.VentaDigitalPQF.CrudTools;
using Core.VentaDigitalPQF.Dto.Address;
using Core.VentaDigitalPQF.Messages.Interfaces;
using Logic.VentaDigitalPQF.Interfaces.Address;
using Proxy.ProquifaDotNet.Services.Interfaces.Direccion;

namespace Logic.VentaDigitalPQF.Services.Address
{
    public class AddressService : IAddressServices
    {
        private readonly IDireccionProxy _direccionProxy;
        private readonly IMapper _mapper;
        private readonly IModelMessage _modelMessage;

        public AddressService(IMapper mapper, IDireccionProxy direccionProxy, IModelMessage modelMessage)
        {
            _direccionProxy = direccionProxy;
            _mapper = mapper;
            _modelMessage = modelMessage;

        }

        public async Task<QueryResultVD> GetAddressDetails(QueryInfoVD Info)
        {
            try
            {
                var response = await _direccionProxy.GetDirecciones(Info);
                QueryResultVD result = new()
                {
                    Results = _mapper.Map<List<AddressDetails>>(response.Results),
                    TotalResults = response.TotalResults
                };
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
