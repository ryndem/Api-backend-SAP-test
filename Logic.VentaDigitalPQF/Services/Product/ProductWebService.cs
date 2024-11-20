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
using Logic.VentaDigitalPQF.Interfaces.Product;
using Proxy.ProquifaDotNet.Dto;
using Core.VentaDigitalPQF.Dto.ProductCustomerWeb;

namespace Logic.VentaDigitalPQF.Services.Product
{
    public class ProductWebService : IProductWebService
    {
        private readonly IProductoProxy _productoProxy;
        private readonly IMapper _mapper;
        public ProductWebService(IMapper mapper, IProductoProxy productoProxy)
        {
            _mapper = mapper;
            _productoProxy = productoProxy;
        }

        public async Task<ProductCustomerWebDetails> GetDetails( ProductCustomerWebRequest ProductWebRequest )
        {
            var productoWebRequest = _mapper.Map<ProductoClienteWebRequest>( ProductWebRequest );
            var product = await _productoProxy.GetProductoClienteWeb( productoWebRequest );
            ProductCustomerWebDetails productDetails = _mapper.Map<ProductCustomerWebDetails>( product );
            return productDetails;
            //throw new NotImplementedException();
        }
        public async Task<QueryResultVD> GetProducts( QueryInfoVD info, ProductCustomerWebRequest ProductWebRequest )
        {
            var response = await _productoProxy.GetProductosClienteWeb( _mapper.Map<QueryInfoPQF>(info), _mapper.Map<ProductoClienteWebRequest>( ProductWebRequest ) );
            QueryResultVD result = new QueryResultVD();
            result.Results = _mapper.Map<List<vProductoClienteWeb>>( response.Results );
            result.TotalResults = response.TotalResults;
            return result;
        }

        public Task<ProductCustomerWebDetails> GetProductWeb( ProductCustomerWebRequest productoRequest )
        {
            throw new NotImplementedException();
        }
    }
}
