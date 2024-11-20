//using Core.CrudTools.Optimization;
using Proxy.ProquifaDotNet.CrudTools;
using Proxy.ProquifaDotNet.Model;
using Proxy.ProquifaDotNet;
using Proxy.ProquifaDotNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.VentaDigitalPQF.Dto.Product;
using AutoMapper;
using Core.VentaDigitalPQF.CrudTools;
using Core.VentaDigitalPQF.Messages.Interfaces;
using Core.VentaDigitalPQF.Dto.ProductCustomer;
using Logic.VentaDigitalPQF.Interfaces.Product;
using Proxy.ProquifaDotNet.Dto;

namespace Logic.VentaDigitalPQF.Services.Product
{
    public class ProductCustomerService : IProductCustomerService
    {
        private readonly IProductoProxy _productoProxy;
        private readonly IMapper _mapper;
        public ProductCustomerService(IMapper mapper, IProductoProxy productoProxy)
        {
            _mapper = mapper;
            _productoProxy = productoProxy;
        }

        public async Task<ProductCustomerDetails> GetDetails(ProductCustomerRequest productCustomerRequest)
        {
            var productoVDRequest = _mapper.Map<ProductoClienteVDRequest>( productCustomerRequest );
            var product = await _productoProxy.GetProductoCliente( productoVDRequest );
            ProductCustomerDetails productDetails = _mapper.Map<ProductCustomerDetails>( product );
            return productDetails;
            //throw new NotImplementedException();
        }

        public async Task<QueryResultVD> GetProducts( QueryInfoVD info, ProductCustomerRequest productCustomerRequest)
        {
            var response = await _productoProxy.GetProductosCliente( _mapper.Map<QueryInfoPQF>(info), _mapper.Map<ProductoClienteVDRequest>( productCustomerRequest ) );
            QueryResultVD result = new QueryResultVD();
            result.Results = _mapper.Map<List<vProductoClienteVD>>( response.Results );
            result.TotalResults = response.TotalResults;
            //result = _mapper.Map<QueryResultPQF<vProductoClienteVD>>( response );
            return result;
        }
    }
}
