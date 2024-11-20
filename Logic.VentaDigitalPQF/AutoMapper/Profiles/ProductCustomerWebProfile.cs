using AutoMapper;
using Core.VentaDigitalPQF.CrudTools;
using Core.VentaDigitalPQF.Dto.PriceOffert;
using Core.VentaDigitalPQF.Dto.Product;
using Core.VentaDigitalPQF.Dto.ProductCustomer;
using Core.VentaDigitalPQF.Dto.ProductCustomerWeb;


//using Lucene.Net.Index;
using Proxy.ProquifaDotNet.CrudTools;
using Proxy.ProquifaDotNet.Dto;
using Proxy.ProquifaDotNet.Model;
using System;
using System.Collections.Generic;
//using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.VentaDigitalPQF.AutoMapper.Profiles
{
    public class ProductCustomerWebProfile : Profile
    {
        public ProductCustomerWebProfile() {
            CreateMap<ProductCustomerWebDetails, vProductoClienteWeb>()
                .ForMember( dst => dst.IdProducto, opt => opt.MapFrom( src => src.IdProduct ) )
                .ForMember( dst => dst.Descripcion, opt => opt.MapFrom( src => src.Description ) )
                .ForMember( dst => dst.TieneCAS, opt => opt.MapFrom( src => src.HasCAS ) )
                .ForMember( dst => dst.CAS, opt => opt.MapFrom( src => src.CAS ) )
                .ForMember( dst => dst.ATC, opt => opt.MapFrom( src => src.ATC ) )
                .ForMember( dst => dst.Catalogo, opt => opt.MapFrom( src => src.Catalog ) )

                .ForMember( dst => dst.Descripcion, opt => opt.MapFrom( src => src.Description ) )
                .ForMember( dst => dst.TipoPresentacion, opt => opt.MapFrom( src => src.PresentationType ) )
                .ForMember( dst => dst.TipoPresentacionClave, opt => opt.MapFrom( src => src.PresentationTypeKey ) )
                .ForMember( dst => dst.Presentacion, opt => opt.MapFrom( src => src.Presentation ) )
                .ForMember( dst => dst.MedioTransporte, opt => opt.MapFrom( src => src.TransportationMeans ) )
                .ForMember( dst => dst.MedioTransporteClave, opt => opt.MapFrom( src => src.TransportationMeansKey ) )

                .ForMember( dst => dst.ManejoTransporte, opt => opt.MapFrom( src => src.TransportHandling ) )
                .ForMember( dst => dst.ManejoTransporteClave, opt => opt.MapFrom( src => src.TransportHandlingKey ) )
                .ForMember( dst => dst.ManejoAlmacenaje, opt => opt.MapFrom( src => src.StorageHandling ) )
                .ForMember( dst => dst.ManejoAlmacenajeClave, opt => opt.MapFrom( src => src.StorageHandlingKey ) )
                .ForMember( dst => dst.ISBN, opt => opt.MapFrom( src => src.ISBN ) )
                .ForMember( dst => dst.NombreImagenMarca, opt => opt.MapFrom( src => src.BrandImageName ) )

                .ForMember( dst => dst.NombreFamilia, opt => opt.MapFrom( src => src.FamilyName ) )
                .ForMember( dst => dst.Tipo, opt => opt.MapFrom( src => src.Type ) )
                .ForMember( dst => dst.ClaveTipo, opt => opt.MapFrom( src => src.TypeKey ) )
                .ForMember( dst => dst.NombreMarca, opt => opt.MapFrom( src => src.BrandName ) )
                .ForMember( dst => dst.Disponibilidad, opt => opt.MapFrom( src => src.Availability ) )
                .ForMember( dst => dst.DisponibilidadClave, opt => opt.MapFrom( src => src.AvailabilityKey ) )


                .ForMember( dst => dst.Linea, opt => opt.MapFrom( src => src.Line ) )
                .ForMember( dst => dst.Pureza, opt => opt.MapFrom( src => src.Purity ) )
                .ForMember( dst => dst.TieneFleteExpress, opt => opt.MapFrom( src => src.HasExpressFreight ) )
                .ForMember( dst => dst.TieneStock, opt => opt.MapFrom( src => src.HasStock ) )
                .ForMember( dst => dst.ProximoACaducar, opt => opt.MapFrom( src => src.AboutToExpire ) )
                .ForMember( dst => dst.CantidadExistenteStock, opt => opt.MapFrom( src => src.ExistingStockQuantity ) )

                .ForMember( dst => dst.FechaCaducidadStock, opt => opt.MapFrom( src => src.StockExpirationDate ) )
                .ForMember( dst => dst.TiempoEstimadoEntregaStock, opt => opt.MapFrom( src => src.EstimatedDeliveryTimeStock ) )
                
                .ReverseMap();



            /*CreateMap<List<ProductDetails>, List<Producto>>()
            .ConvertUsing<TeamMemberListToTeamConverter>();*/

            CreateMap<ProductCustomerWebRequest, ProductoClienteWebRequest>()
                .ForMember( dst => dst.IdProducto, opt => opt.MapFrom( src => src.IdProduct ) )
                .ForMember( dst => dst.IdCliente, opt => opt.MapFrom( src => src.IdCustomer ) )
                .ForMember( dst => dst.IdDireccionEntrega, opt => opt.MapFrom( src => src.IdDeliveryAddress ) )
                ;
            CreateMap<QueryResultVD, QueryResultVD<vProductoClienteWeb>>()
                .ForMember( dst => dst.Results, opt => opt.MapFrom( src => src.Results ) )
                .ForMember( dst => dst.TotalResults, opt => opt.MapFrom( src => src.TotalResults ) )
                .ReverseMap();
        }
    }
}
