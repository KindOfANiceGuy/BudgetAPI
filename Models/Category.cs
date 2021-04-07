using System.ComponentModel.DataAnnotations;

namespace BudgetApi.Models
{
    public enum Category
    {
        Savings, 
        Charity,
        Housing,
        Utilities,
        Food,
        Clothing,
        Transportation,

        [Display(Name="Medical/Health")]
        Medical,
        Insurance,
        Personal,
        Recreation,
    }
}
