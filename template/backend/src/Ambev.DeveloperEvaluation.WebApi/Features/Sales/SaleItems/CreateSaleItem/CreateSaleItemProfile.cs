using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.SaleItems.CreateSaleItem
{
    /// <summary>
    /// Defines mapping between SaleItem entities and related DTOs.
    /// </summary>
    public class CreateSaleItemProfile : Profile
    {
        public CreateSaleItemProfile()
        {
            CreateMap<CreateSaleItemRequest, SaleItem>();
            CreateMap<SaleItem, CreateSaleItemResponse>();
        }
    }
}
