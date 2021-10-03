using System.Collections;
using System.Collections.Generic;
using Ex3_FourthCoffee.Models;

namespace Ex3_FourthCoffee.Data
{
    public interface IProductsService
    {
        public IList<Product> Products { get; }
    }
}