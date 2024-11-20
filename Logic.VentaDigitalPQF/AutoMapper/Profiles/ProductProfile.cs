using AutoMapper;
using Core.VentaDigitalPQF.CrudTools;
using Core.VentaDigitalPQF.Dto.PriceOffert;
using Core.VentaDigitalPQF.Dto.Product;
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
    public class ProductProfile : Profile
    {
        public ProductProfile() {
            CreateMap<ProductDetails, vProducto>()
                .ForMember( dst => dst.IdProducto, opt => opt.MapFrom( src => src.IdProduct ) )
                .ForMember( dst => dst.Catalogo, opt => opt.MapFrom( src => src.Catalog ) )
                .ForMember( dst => dst.Descripcion, opt => opt.MapFrom( src => src.Description ) )
                .ForMember( dst => dst.Nota, opt => opt.MapFrom( src => src.Note ) )
                //.ForMember( dst => dst.PrecioLista, opt => opt.MapFrom( src => src.ListPrice ) )
                .ForMember( dst => dst.FechaRegistro, opt => opt.MapFrom( src => src.RegistrationDate ) )
                .ForMember( dst => dst.FechaCaducidadRegistro, opt => opt.MapFrom( src => src.RegistrationExpirationDate ) )
                .ForMember( dst => dst.FechaUltimaActualizacion, opt => opt.MapFrom( src => src.LastUpdateDate ) )
                .ForMember( dst => dst.Activo, opt => opt.MapFrom( src => src.Active ) )
                .ForMember( dst => dst.Controlado, opt => opt.MapFrom( src => src.Controlled ) )
                .ForMember( dst => dst.NumeroDepositarioInternacional, opt => opt.MapFrom( src => src.InternationalDepositNumber ) )
                .ForMember( dst => dst.NumeroDePiezas, opt => opt.MapFrom( src => src.NumberOfPieces ) )
                .ForMember( dst => dst.IdMarcaFamilia, opt => opt.MapFrom( src => src.IdFamilyBrand ) )
                .ForMember( dst => dst.FechaCaducidadVigenciaCuraduria, opt => opt.MapFrom( src => src.CuratorshipExpirationDate ) )
                .ForMember( dst => dst.Peligrosidad, opt => opt.MapFrom( src => src.Hazardousness ) )
                .ForMember( dst => dst.TieneCAS, opt => opt.MapFrom( src => src.HasCASnumber ) )
                .ForMember( dst => dst.IdProveedorPrincipal, opt => opt.MapFrom( src => src.IdMainSupplier ) )
                .ForMember( dst => dst.NombreProveedor, opt => opt.MapFrom( src => src.SupplierName ) )
                //.ForMember( dst => dst.IdMarca, opt => opt.MapFrom( src => src.IdBrand ) )
                .ForMember( dst => dst.NombreMarca, opt => opt.MapFrom( src => src.BrandName ) )
                .ForMember( dst => dst.Tipo, opt => opt.MapFrom( src => src.Type ) )
                .ForMember( dst => dst.TipoProductoClave, opt => opt.MapFrom( src => src.ProductTypeKey ) )
                .ForMember( dst => dst.Subtipo, opt => opt.MapFrom( src => src.Subtype ) )
                .ForMember( dst => dst.SubtipoProductoClave, opt => opt.MapFrom( src => src.SubtypeKey ) )
                .ForMember( dst => dst.Control, opt => opt.MapFrom( src => src.Control ) )
                .ForMember( dst => dst.ControlClave, opt => opt.MapFrom( src => src.ControlKey ) )
                .ForMember( dst => dst.Disponibilidad, opt => opt.MapFrom( src => src.Availability ) )
                .ForMember( dst => dst.Linea, opt => opt.MapFrom( src => src.Line ) )
                .ForMember( dst => dst.Unidad, opt => opt.MapFrom( src => src.Unit ) )
                .ForMember( dst => dst.TipoPresentacion, opt => opt.MapFrom( src => src.PresentationType ) )
                .ForMember( dst => dst.TipoPresentacionClave, opt => opt.MapFrom( src => src.PresentationTypeKey ) )
                .ForMember( dst => dst.Aplicacion, opt => opt.MapFrom( src => src.Application ) )
                .ForMember( dst => dst.MedioTransporte, opt => opt.MapFrom( src => src.Transport ) )
                .ForMember( dst => dst.ManejoTransporte, opt => opt.MapFrom( src => src.TransportHandling ) )
                .ForMember( dst => dst.ManejoAlmacenaje, opt => opt.MapFrom( src => src.StorageHandling ) )
                .ForMember( dst => dst.Uso, opt => opt.MapFrom( src => src.Use ) )
                .ForMember( dst => dst.CAS, opt => opt.MapFrom( src => src.CASNumber ) )
                .ForMember( dst => dst.ATC, opt => opt.MapFrom( src => src.ATCcode ) )
                .ForMember( dst => dst.FormulaQuimica, opt => opt.MapFrom( src => src.ChemicalFormula ) )
                .ForMember( dst => dst.FormulaMolecular, opt => opt.MapFrom( src => src.MolecularFormula ) )
                .ForMember( dst => dst.oferta, member => member.MapFrom( src => src.Offert ) )
                //.ForPath( dst => dst.IdProducto, opt => opt.MapFrom( src => src.IdProduct ) )
                .ReverseMap();

            CreateMap<PrecioOferta, PriceOfferDetails>()
                //.ForMember( dst => dst.IdProduct, opt => opt.MapFrom( src => src.IdProducto ) )
                //.ForMember( dst => dst.IdCliente, opt => opt.MapFrom( src => src.IdCustomer ) )
                /*.ForMember(dst => dst.IdCurrencyCategory, opt => opt.MapFrom(src => src.IdCatMoneda))*/
                .ForMember( dst => dst.Pieces, opt => opt.MapFrom( src => src.Piezas ) )
                .ForMember( dst => dst.UnitPrice, opt => opt.MapFrom( src => src.Precio ) )
                .ForMember( dst => dst.DeliveryTime, opt => opt.MapFrom( src => src.TiempoEntrega ) )
                .ForMember( dst => dst.DeliveryTimeDays, opt => opt.MapFrom( src => src.TiempoEntregaDias ) )
                .ForMember( dst => dst.DeliveryTimeDate, opt => opt.MapFrom( src => src.TiempoEntregaFecha ) )
                //.ForMember( dst => dst.IdTimeDeliveryConfigurationValue, opt => opt.MapFrom( src => src.IdValorConfiguracionTiempoEntrega ) )
                //.ForMember( dst => dst.IdFamilyBrand, opt => opt.MapFrom( src => src.IdMarcaFamilia ) )
                //.ForMember( dst => dst.IdSalesCurrency, opt => opt.MapFrom( src => src.IdCatMonedaVentas ) )
                //.ForMember( dst => dst.IdSupplier, opt => opt.MapFrom( src => src.IdProveedor ) )
                //.ForMember( dst => dst.PriceProquifaDotNet, opt => opt.MapFrom( src => src.PrecioProquifaNetClienteTabla ) )
                //.ForMember( dst => dst.IdPriceSupplierFamilyConfiguration, opt => opt.MapFrom( src => src.IdConfiguracionPrecioProveedorFamilia ) )
                //.ForMember( dst => dst.IdPriceCategoryUtilitySupplierConfiguration, opt => opt.MapFrom( src => src.IdConfiguracionPrecioUtilidadCategoriaProveedor ) )
                //.ForMember( dst => dst.IdSupplierCommissionConfiguration, opt => opt.MapFrom( src => src.IdConfiguracionComisionProveedor ) )
                .ForMember( dst => dst.AppliesPerPiece, opt => opt.MapFrom( src => src.AplicaPorPieza ) )
                //.ForMember(dst => dst.IsConfigured, opt => opt.MapFrom(src => src.Configurado))
                //.ForMember(dst => dst.StockDeliveryTime, opt => opt.MapFrom(src => src.TiempoEntregaStock))
                //.ForMember(dst => dst.StockDeliveryTimeDays, opt => opt.MapFrom(src => src.TiempoEntregaDiasStock))
                //.ForMember(dst => dst.HasStock, opt => opt.MapFrom(src => src.TieneStock))
                .ForMember( dst => dst.IdDeliveryAddress, opt => opt.MapFrom( src => src.IdDireccionEntrega ) )
            //.ReverseMap();
            ;

            /*CreateMap<List<ProductDetails>, List<Producto>>()
            .ConvertUsing<TeamMemberListToTeamConverter>();*/

            CreateMap<ProductRequest, ProductoRequest>()
                .ForMember( dst => dst.IdProducto, opt => opt.MapFrom( src => src.IdProduct ) )
                .ForMember( dst => dst.IdCliente, opt => opt.MapFrom( src => src.IdCustomer ) )
                .ForMember( dst => dst.IdDireccionEntrega, opt => opt.MapFrom( src => src.IdDeliveryAddress ) )
                ;
            CreateMap<QueryResultVD, QueryResultVD<vProducto>>()
                .ForMember( dst => dst.Results, opt => opt.MapFrom( src => src.Results ) )
                .ForMember( dst => dst.TotalResults, opt => opt.MapFrom( src => src.TotalResults ) )
                .ReverseMap();
        }
    }
}
