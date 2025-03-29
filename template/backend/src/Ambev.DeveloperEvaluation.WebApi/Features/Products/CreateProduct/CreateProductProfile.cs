using Ambev.DeveloperEvaluation.Application.Products.CreateProduct;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.WebApi.Features.Products.Rating;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct
{
    /// <summary>
    /// Defines mapping between Product entities and related DTOs.
    /// </summary>
    public class CreateProductProfile : Profile
    {
        public CreateProductProfile()
        {
            CreateMap<CreateProductRequest, CreateProductCommand>();
            CreateMap<CreateProductResult, CreateProductResponse>();
            CreateMap<RatingRequest, ProductRating>();

            CreateMap<CreateProductCommand, Product>();

            CreateMap<ProductRating, RatingClass>()
                .ForMember(dest => dest.Rate, opt => opt.MapFrom(src => src.Rate));
        }
    }
}
