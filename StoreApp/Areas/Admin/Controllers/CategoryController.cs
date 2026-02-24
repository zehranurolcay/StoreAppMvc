using Entities.Dtos;
using Entities.RequestParameters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using StoreApp.Models;

namespace StoreApp.Areas.Admin.Controllers
{


    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly IServiceManager _manager;

        public CategoryController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index([FromQuery] CategoryRequestParameters p)
        {
            ViewData["Title"] = "Categories";

            var categories = _manager.CategoryService.GetAllCategoriesWithDetails(p);

            var pagination = new Pagination()
            {
                CurrentPage = p.PageNumber,
                ItemsPerPage = p.PageSize,
                TotalItems = _manager.CategoryService.GetAllCategories(false).Count()
            };

            return View(new CategoryListViewModel()
            {
                Categories = categories,
                Pagination = pagination
            });
        }
        public IActionResult Create()
        {
            TempData["info"] = "Please fill the form.";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CategoryDtoForInsertion categoryDto)
        {
            if (ModelState.IsValid)
            {
                _manager.CategoryService.CreateCategory(categoryDto);
                TempData["success"] = $"{categoryDto.CategoryName} has been created.";
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Update([FromRoute(Name = "id")] int id)
        {
            var model = _manager.CategoryService
                .GetOneCategoryForUpdate(id, false);

            ViewData["Title"] = model?.CategoryName;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update([FromForm] CategoryDtoForUpdate categoryDto)
        {
            if (ModelState.IsValid)
            {
                _manager.CategoryService.UpdateOneCateory(categoryDto);
                TempData["success"] = $"{categoryDto.CategoryName} has been updated.";
                return RedirectToAction("Index");
            }
            return View();
        }


        [HttpGet]
        public IActionResult Delete([FromRoute(Name = "id")] int id)
        {
            _manager.CategoryService.DeleteOneCategory(id);
            TempData["danger"] = "The product has been removed.";
            return RedirectToAction("Index");
        }
    }


}