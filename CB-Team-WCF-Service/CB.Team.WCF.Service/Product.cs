using System.Collections.Generic;

namespace CB.Team.WCF.Service
{
    public class Product : IProduct
    {
        public List<Products> GetProducts()
        {
            return new List<Products>
            {
                new Products
                {
                    Id = 1,
                    Name = "Fernet Branca",
                    Brand = "Branca",
                    Description = "Fernet",
                    Price = 2300,
                    Stock = 20,
                },
                new Products
                {
                    Id = 2,
                    Name = "Coca-Cola",
                    Brand = "Coca-Cola",
                    Description = "2,5 lts",
                    Price = 800,
                    Stock = 20,
                },
            };
        }
    }
}
