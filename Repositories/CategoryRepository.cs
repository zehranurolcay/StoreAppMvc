using Entities.Models;
using Entities.RequestParameters;
using Repositories.Contracts;
using Repositories.Extensions;

namespace Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext context) : base(context)
        {

        }
        public void CreateOneCategory(Category category) => Create(category);
        public void DeleteOneCategory(Category category) => Remove(category);
        public void UpdateOneCategory(Category entity) => Update(entity);
        public IQueryable<Category> GetAllCategories(bool trackChanges)
                => FindAll(trackChanges);

        public Category GetOneCategory(int id, bool trackChanges)
        {
            return FindByCondition(c => c.CategoryId.Equals(id), trackChanges);
        }
        public IQueryable<Category> GetAllCategoriesWithDetails(CategoryRequestParameters c)
        {
            return _context
            .Categories
            .ToPaginate(c.PageNumber, c.PageSize);
        }
    }
}