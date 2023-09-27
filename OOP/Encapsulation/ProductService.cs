using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Encapsulation
{
    public static class ProductService
    {
        public static void InsertProduct()
        {
            Product product = ProductMapper();
            ValidatePromotion(product.HasPromotion);
            ProductRepository.InsertProduct();
        }
        private static Product ProductMapper()
        {
            return new Product
            {
                Id = 1,
                Name = "Arroz",
                Value = Convert.ToDecimal(12.00),
                HasPromotion = true
            };
        }
        private static void ValidatePromotion(bool hasPromotion)
        {
            if (hasPromotion)
            {
                //insert validation when there is a promotion
            }
        }
    }
}
