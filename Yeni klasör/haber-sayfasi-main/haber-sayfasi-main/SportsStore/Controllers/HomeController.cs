﻿using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System.Linq;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers {
    public class HomeController : Controller {
        private INewsRepository repository;
        public int PageSize = 4;

        public HomeController(INewsRepository repo) {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View(new NewsListViewModel
            {
                News = repository.Haberler
            });
        }

        //public ViewResult Index(string category, int productPage = 1)
        //    => View(new ProductsListViewModel {
        //        Products = repository.Products
        //            .Where(p => category == null || p.Category == category)
        //            .OrderBy(p => p.ProductID)
        //            .Skip((productPage - 1) * PageSize)
        //            .Take(PageSize),
        //        PagingInfo = new PagingInfo {
        //            CurrentPage = productPage,
        //            ItemsPerPage = PageSize,
        //            TotalItems = category == null ?
        //                repository.Products.Count() :
        //                repository.Products.Where(e =>
        //                    e.Category == category).Count()
        //        },
        //        CurrentCategory = category
        //    });
    }
}
