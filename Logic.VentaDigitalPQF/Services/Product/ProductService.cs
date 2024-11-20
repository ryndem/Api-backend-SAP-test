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
using Proxy.ProquifaDotNet.Dto;
using Logic.VentaDigitalPQF.Interfaces.Product;


namespace Logic.VentaDigitalPQF.Services.Product
{
    public class ProductService : IProductService
    {
        private readonly IProductoProxy _productoProxy;
        private readonly IMapper _mapper;
        public ProductService(IMapper mapper, IProductoProxy productoProxy)
        {
            _mapper = mapper;
            _productoProxy = productoProxy; 
        }
        public async Task<ProductDetails> GetDetails(ProductRequest productRequest)
        {
            var productoRequest = _mapper.Map<ProductoRequest>(productRequest);
            var product = await _productoProxy.GetProducto(productoRequest);
            ProductDetails productDetails = _mapper.Map<ProductDetails>(product);
            return productDetails;
        }
        public async Task<ProductDetails> GetProduct(ProductRequest productRequest)
        {
            ProductDetails productDetails = _mapper.Map<ProductDetails>(await _productoProxy.GetProducto(_mapper.Map<ProductoRequest>(productRequest)));
            return productDetails;
        }

        public async Task<QueryResultVD> GetProducts(object info, ProductRequest productRequest)
        {
            var response = await _productoProxy.GetProductos(info, _mapper.Map<ProductoRequest>(productRequest));
            QueryResultVD result = new QueryResultVD();
            result.Results = _mapper.Map<List<ProductDetails>>(response.Results);
            result.TotalResults = response.TotalResults;
            return result;
        }

    }
}
