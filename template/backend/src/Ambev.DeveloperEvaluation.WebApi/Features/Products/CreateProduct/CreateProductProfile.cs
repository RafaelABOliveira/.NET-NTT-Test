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
            CreateMap<CreateProductCommand, CreateProductRequest>();
            CreateMap<CreateProductResult, CreateProductResponse>();
            CreateMap<RatingRequest, RatingClass>();

            CreateMap<CreateProductCommand, Product>()
                .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => new RatingClass
                {
                    Rate = src.Rating.Rate,
                    ProductId = Guid.NewGuid() 
                }));

            CreateMap<Product, CreateProductResult>();
        }
    }
}
