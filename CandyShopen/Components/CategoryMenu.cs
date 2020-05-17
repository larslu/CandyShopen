using CandyShopen.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShopen.Components 
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;
        private List<Category> categoryList;

        public CategoryMenu(ICategoryRepository categoryRep)
        {
            _categoryRepository = categoryRep;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.GetAllCategories.OrderBy(c => c.CategoryName);
            return View(categories);
        }
    }
}
