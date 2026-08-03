using IT_ELECTIVE_2_MIDTERM_H1_H2_H3.Models.Entities;

namespace IT_ELECTIVE_2_MIDTERM_H1_H2_H3.Models.Repositories
{
    public static class TransactionRepository
    {
        public static List<Transaction> Transactions { get; } = new();
    }
}