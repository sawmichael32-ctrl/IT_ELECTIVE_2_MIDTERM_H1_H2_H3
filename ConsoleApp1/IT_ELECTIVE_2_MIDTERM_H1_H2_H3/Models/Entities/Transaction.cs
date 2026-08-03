using System;
using System.Collections.Generic;

namespace IT_ELECTIVE_2_MIDTERM_H1_H2_H3.Models.Entities
{
    public class Transaction
    {
        public int TransactionId { get; set; }

        public DateTime Date { get; set; }

        public string CustomerName { get; set; } = string.Empty;

        public decimal TotalAmount { get; set; }

        public List<CartItem> PurchasedItems { get; set; } = new();
    }
}