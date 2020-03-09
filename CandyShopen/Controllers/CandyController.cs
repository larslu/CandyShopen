using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandyShopen.Models;
using Microsoft.AspNetCore.Mvc;
using CandyShopen.ViewModels;
namespace CandyShopen.Controllers
{
    public class CandyController : Controller
    {
        private readonly ICandyRepository _candyRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CandyController(ICandyRepository candyRepository, ICategoryRepository categoryRepository)
        {
            _candyRepository = candyRepository;
            _categoryRepository = categoryRepository;
        }
        
        public IActionResult List()
        {
            //ViewBag.CurrentCategory = "Bestsellers";
            //return View(_candyRepository.GetAllCandy);
            var candyListViewModel = new CandyListViewModel();
            candyListViewModel.Candies = _candyRepository.GetAllCandy;
            candyListViewModel.CurrentCategory = "Bestsellers";

            return View(candyListViewModel);
        }
    }
}