using System.Collections.Generic;
using SportsStore.Models;
using SportsStore.Infrastructure;

namespace SportsStore.Models.ViewModels
{
    public class ProductListViewModel
    {

        public IEnumerable<Product> Products { get; set; }
        public PageInfo PageInfo { get; set; }
        public string CurrentCategory { get; set; }

    }
}
