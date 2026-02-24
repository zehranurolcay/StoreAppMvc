using Entities.Models;

namespace StoreApp.Models
{
    public class CategoryListViewModel
    {
        public IEnumerable<Category> Categories {get; set;} = Enumerable.Empty<Category>();
        public Pagination Pagination { get; set; } = new();
        public int TotalCount => Categories.Count();
    }
}