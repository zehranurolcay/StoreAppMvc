using System.Reflection.Metadata;

namespace Entities.Dtos
{
    public record ProductDtoForUpdate : ProductDto
    {
        public bool Showcase {get; set;}
    }
}