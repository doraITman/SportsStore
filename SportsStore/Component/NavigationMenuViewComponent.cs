using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System.Linq;

namespace SportsStore.Component
{
    public class NavigationMenuViewComponent:ViewComponent
    {
     private IProductRepository productRepository;
        public NavigationMenuViewComponent(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IViewComponentResult Invoke()
        {
            return View(productRepository.Products
                .Select(x=>x.Category)
                .Distinct()
                .OrderBy(x=>x));
        }
    } 
}
