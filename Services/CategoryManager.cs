using AutoMapper;
using Entities.Dtos;
using Entities.Models;
using Entities.RequestParameters;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class CategoryManager : ICategoryService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public CategoryManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public void CreateCategory(CategoryDtoForInsertion categoryDto)
        {
            Category category = _mapper.Map<Category>(categoryDto);
            _manager.Category.Create(category);
            _manager.Save();
        }

        public void DeleteOneCategory(int id)
        {
            Category category = GetOneCategory(id, false);
            if (category is not null)
            {
                _manager.Category.DeleteOneCategory(category);
                _manager.Save();
            }
        }

        public Category? GetOneCategory(int id, bool trackChanges)
        {
            var category = _manager.Category.GetOneCategory(id,trackChanges);
            if (category == null)
            {
                throw new Exception("Category not found");
            }
            return category;
        }
        public IEnumerable<Category> GetAllCategories(bool trackchanges)
        {
            return _manager.Category.FindAll(trackchanges);
        }

        public IEnumerable<Category> GetAllCategoriesWithDetails(CategoryRequestParameters c)
        {
            return _manager.Category.GetAllCategoriesWithDetails(c);
        }
        public CategoryDtoForUpdate GetOneCategoryForUpdate(int id, bool trackChanges)
        {
            var category = GetOneCategory(id,trackChanges);
            var categoryDto = _mapper.Map<CategoryDtoForUpdate>(category);
            return categoryDto;
        }

        public void UpdateOneCateory(CategoryDtoForUpdate categoryDto)
        {
            var entity = _mapper.Map<Category>(categoryDto);
            _manager.Category.UpdateOneCategory(entity);
            _manager.Save();
        }

    }
}