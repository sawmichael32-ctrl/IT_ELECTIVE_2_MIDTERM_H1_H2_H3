using Microsoft.AspNetCore.Mvc;
using IT_ELECTIVE_2_MIDTERM_H1_H2_H3.Models.DTOs;
using IT_ELECTIVE_2_MIDTERM_H1_H2_H3.Models.Repositories;

namespace IT_ELECTIVE_2_MIDTERM_H1_H2_H3.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View(CartRepository.Cart);
        }

        [HttpPost]
        public IActionResult Update(UpdateCartDTO dto)
        {
            var item = CartRepository.Cart.Items
                .FirstOrDefault(x => x.ProductId == dto.ProductId);

            if (item != null)
            {
                item.Quantity = dto.Quantity;
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Remove(int productId)
        {
            var item = CartRepository.Cart.Items
                .FirstOrDefault(x => x.ProductId == productId);

            if (item != null)
            {
                CartRepository.Cart.Items.Remove(item);
            }

            return RedirectToAction("Index");
        }
    }
}