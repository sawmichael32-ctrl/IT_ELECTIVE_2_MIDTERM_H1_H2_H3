using System.Collections.Generic;
using System.Linq;

namespace IT_ELECTIVE_2_MIDTERM_H1_H2_H3.Models.Entities
{
    public class ShoppingCart
    {
        public List<CartItem> Items { get; set; } = new();

        public decimal GrandTotal
        {
            get
            {
                return Items.Sum(item => item.LineTotal);
            }
        }
    }
}