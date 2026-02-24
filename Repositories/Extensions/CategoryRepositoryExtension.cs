using Entities.Models;

namespace Repositories.Extensions
{
    public static class CategoryRepositoryExtension
    {
        public static IQueryable<Category> ToPaginate(this IQueryable<Category> categories,
        int pageNumber, int pageSize)
        {
            return categories
            .Skip((pageNumber-1)*pageSize)
            .Take(pageSize);
        }
    }
}