using System.Collections.Generic;

namespace BudgetApi.Models
{
    public class SubCategory
    {
        //ID
        public int ID {get; set;}
        //Name
        public string Name {get; set;}
        //Category
        public Category Category {get; set;}
        // Expensed Items
        public List<Expense> Expenses {get; set;}
        // Budgeted Amount
        public decimal BudgetedAmount {get; set;}

    }
}