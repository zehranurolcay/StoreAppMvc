using Services.Contracts;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IOrderService _orderService;
        public ServiceManager(ICategoryService categoryService,
        IProductService productService,
        IOrderService orderService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _orderService = orderService;
        }
        public IOrderService OrderService => _orderService;
        public IProductService ProductService => _productService;
        public ICategoryService CategoryService => _categoryService;

    }
}