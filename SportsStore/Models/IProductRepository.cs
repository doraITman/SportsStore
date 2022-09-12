using System.Linq;
using System.Collections.Generic;


namespace SportsStore.Models

{
   public interface IProductRepository
    {
      IQueryable<Product> Products { get; }
        void Add(Product product);
      
    }     
  
}
