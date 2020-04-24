﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandyShopen.Models;
using CandyShopen.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CandyShopen.Controllers
{
    public class ShoppingCartController : Controller
    {

        private readonly ICandyRepository _candyRepository;

        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ICandyRepository candyRepository, ShoppingCart shoppingCart)
        {
            _candyRepository = candyRepository;
            _shoppingCart = shoppingCart;
        }
        public ViewResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }
    }
}
