using IT_ELECTIVE_2_MIDTERM_H1_H2_H3.Models.DTOs;
using IT_ELECTIVE_2_MIDTERM_H1_H2_H3.Models.Entities;
using IT_ELECTIVE_2_MIDTERM_H1_H2_H3.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_2_MIDTERM_H1_H2_H3.Controllers
{
    public class CheckoutController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            if (!CartRepository.Cart.Items.Any())
            {
                TempData["Error"] = "Your cart is empty.";
                return RedirectToAction("Index", "Cart");
            }

            return View(new CheckoutFormDTO());
        }

        [HttpPost]
        public IActionResult Index(CheckoutFormDTO model)
        {
            if (!ModelState.IsValid)
                return View(model);

            foreach (var item in CartRepository.Cart.Items)
            {
                var product = ProductRepository.Products
                    .FirstOrDefault(p => p.Id == item.ProductId);

                if (product != null)
                    product.StockQuantity -= item.Quantity;
            }

            TransactionRepository.Transactions.Add(new Transaction
            {
                TransactionId = TransactionRepository.Transactions.Count + 1,
                Date = DateTime.Now,
                CustomerName = model.CustomerName,
                TotalAmount = CartRepository.Cart.GrandTotal,
                PurchasedItems = CartRepository.Cart.Items
                    .Select(i => new CartItem
                    {
                        ProductId = i.ProductId,
                        ProductName = i.ProductName,
                        Quantity = i.Quantity,
                        UnitPrice = i.UnitPrice
                    })
                    .ToList()
            });

            CartRepository.Cart.Items.Clear();

            return RedirectToAction(nameof(History));
        }

        public IActionResult History()
        {
            return View(TransactionRepository.Transactions);
        }

        public IActionResult Details(int id)
        {
            var transaction = TransactionRepository.Transactions
                .FirstOrDefault(t => t.TransactionId == id);

            if (transaction == null)
                return NotFound();

            return View(transaction);
        }
    }
}