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
    public class CrudToolsProfile : Profile
    {
        public CrudToolsProfile() {
            CreateMap<QueryInfoVD, QueryInfoPQF>()
                .ForMember( dst => dst.SortField, opt => opt.MapFrom( src => src.SortField ) )
                .ForMember( dst => dst.SortDirection, opt => opt.MapFrom( src => src.SortDirection ) )
                .ForMember( dst => dst.Filters, opt => opt.MapFrom( src => src.Filters ) )
                .ForMember( dst => dst.Suggestions, opt => opt.MapFrom( src => src.Suggestions ) )
                .ForMember( dst => dst.PageSize, opt => opt.MapFrom( src => src.PageSize ) )
                .ForMember( dst => dst.DesiredPage, opt => opt.MapFrom( src => src.DesiredPage ) )
                ;

            CreateMap<QueryInfoPQF, QueryInfoVD>()
                .ForMember( dst => dst.SortField, opt => opt.MapFrom( src => src.SortField ) )
                .ForMember( dst => dst.SortDirection, opt => opt.MapFrom( src => src.SortDirection ) )
                .ForMember( dst => dst.Filters, opt => opt.MapFrom( src => src.Filters ) )
                .ForMember( dst => dst.Suggestions, opt => opt.MapFrom( src => src.Suggestions ) )
                .ForMember( dst => dst.PageSize, opt => opt.MapFrom( src => src.PageSize ) )
                .ForMember( dst => dst.DesiredPage, opt => opt.MapFrom( src => src.DesiredPage ) )
                ;
            CreateMap<FilterTupleVD, FilterTuplePQF>()
                .ForMember( dst => dst.NombreFiltro, opt => opt.MapFrom( src => src.NombreFiltro ) )
                .ForMember( dst => dst.ValorFiltro, opt => opt.MapFrom( src => src.ValorFiltro ) )
                ;
            CreateMap<FilterTuplePQF, FilterTupleVD>()
                .ForMember( dst => dst.NombreFiltro, opt => opt.MapFrom( src => src.NombreFiltro ) )
                .ForMember( dst => dst.ValorFiltro, opt => opt.MapFrom( src => src.ValorFiltro ) )
                ;
            CreateMap<SearchSuggestionVD, SearchSuggestionPQF>()
                .ForMember( dst => dst.FieldName, opt => opt.MapFrom( src => src.FieldName ) )
                .ForMember( dst => dst.SuggestionValue, opt => opt.MapFrom( src => src.SuggestionValue ) )
                ;
            CreateMap<SearchSuggestionPQF, SearchSuggestionVD>()
                .ForMember( dst => dst.FieldName, opt => opt.MapFrom( src => src.FieldName ) )
                .ForMember( dst => dst.SuggestionValue, opt => opt.MapFrom( src => src.SuggestionValue ) )
                ;

        }
    }
}
