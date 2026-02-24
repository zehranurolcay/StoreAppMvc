using Entities.Dtos;
using Entities.Models;
using Entities.RequestParameters;

namespace Services.Contracts
{
    public interface ICategoryService
    {
        void CreateCategory(CategoryDtoForInsertion categoryDto);
        void DeleteOneCategory(int id);
        void UpdateOneCateory(CategoryDtoForUpdate categoryDto);
        Category? GetOneCategory(int id,bool trackChanges);
        IEnumerable<Category> GetAllCategories(bool trackchanges);
        IEnumerable<Category> GetAllCategoriesWithDetails(CategoryRequestParameters p);
        CategoryDtoForUpdate GetOneCategoryForUpdate(int id, bool trackChanges);
    }
}