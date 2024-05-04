using System.ComponentModel.DataAnnotations;
// SWilson
// Create Enum for DepartmentID drop down options in TicketModel.



namespace TitanHelp.Models
{
    public enum DepartmentStatus
    {
        [Display(Name = "Account Management")]
        AccountManagement,
        [Display(Name = "Technical Issues")]
        TechnicalIssues,
        [Display(Name = "Billing and Payments")]
        BillingandPayments,
        Other
    }
}