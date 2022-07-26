using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult List()=>View(repository.Products);
    }
}
