using System;


namespace BudgetApi.Models
{
    public class Expense
    {
        // ID
        public int ID {get; set;}
        // Date
        public DateTime Date {get; set;}
        // Amount
        public decimal Amount {get; set;}
        // SubCategory
        public SubCategory SubCategory {get; set;}
        public int SubCategoryID {get; set;}
        // Description
        public string Description {get; set;}
    }
}