using IT_ELECTIVE_2_MIDTERM_H1_H2_H3.Models.Entities;

namespace IT_ELECTIVE_2_MIDTERM_H1_H2_H3.Models.Repositories
{
    public static class ProductRepository
    {
        public static List<Product> Products { get; } = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Gaming Mouse",
                Price = 1200,
                StockQuantity = 10
            },

            new Product
            {
                Id = 2,
                Name = "Mechanical Keyboard",
                Price = 3500,
                StockQuantity = 8
            },

            new Product
            {
                Id = 3,
                Name = "Gaming Headset",
                Price = 2500,
                StockQuantity = 6
            },

            new Product
            {
                Id = 4,
                Name = "1TB SSD",
                Price = 4200,
                StockQuantity = 5
            },

            new Product
            {
                Id = 5,
                Name = "16GB RAM",
                Price = 3000,
                StockQuantity = 12
            },

            new Product
            {
                Id = 6,
                Name = "Ryzen 7 Processor",
                Price = 14500,
                StockQuantity = 4
            },

            new Product
            {
                Id = 7,
                Name = "RTX 4060 Graphics Card",
                Price = 28000,
                StockQuantity = 3
            },

            new Product
            {
                Id = 8,
                Name = "27-inch Gaming Monitor",
                Price = 9800,
                StockQuantity = 7
            }
        };
    }
}