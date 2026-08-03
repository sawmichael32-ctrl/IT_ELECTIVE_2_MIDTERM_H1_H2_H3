using IT_ELECTIVE_2_MIDTERM_H1_H2_H3.Models.Entities;

namespace IT_ELECTIVE_2_MIDTERM_H1_H2_H3.Models.Repositories
{
    public static class CartRepository
    {
        public static ShoppingCart Cart { get; } = new ShoppingCart();
    }
}