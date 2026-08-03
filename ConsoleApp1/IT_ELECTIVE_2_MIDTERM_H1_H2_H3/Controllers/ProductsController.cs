using Microsoft.AspNetCore.Mvc;
using IT_ELECTIVE_2_MIDTERM_H1_H2_H3.Models.Repositories;
using IT_ELECTIVE_2_MIDTERM_H1_H2_H3.Models.DTOs;
using IT_ELECTIVE_2_MIDTERM_H1_H2_H3.Models.Entities;

namespace IT_ELECTIVE_2_MIDTERM_H1_H2_H3.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View(ProductRepository.Products);
        }

        [HttpPost]
        public IActionResult AddToCart(AddToCartDTO dto)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Index");

            var product = ProductRepository.Products
                .FirstOrDefault(p => p.Id == dto.ProductId);

            if (product == null)
                return RedirectToAction("Index");

            var existingItem = CartRepository.Cart.Items
                .FirstOrDefault(c => c.ProductId == dto.ProductId);

            if (existingItem != null)
            {
                existingItem.Quantity += dto.Quantity;
            }
            else
            {
                CartRepository.Cart.Items.Add(new CartItem
                {
                    ProductId = product.Id,
                    ProductName = product.Name,
                    Quantity = dto.Quantity,
                    UnitPrice = product.Price
                });
            }

            return RedirectToAction("Index");
        }
    }
}