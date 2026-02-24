using Entities.Models;
using Entities.RequestParameters;

namespace Repositories.Contracts
{
    public interface ICategoryRepository : IRepositoryBase<Category>
    {
        Category? GetOneCategory(int id, bool trackChanges);
        void DeleteOneCategory(Category category);
        void CreateOneCategory(Category category);
        void UpdateOneCategory(Category entity);
        IQueryable<Category> GetAllCategoriesWithDetails(CategoryRequestParameters c);
        
    }
}