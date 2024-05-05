//author: Nicholas Faz
using System.ComponentModel.DataAnnotations;

namespace TitanHelp.Models;

public class Ticket
{
    public int ID { get; set; }
    public string? Name { get; set; }
    // Change Title to int RoleID for Student = 0, Faculty = 1, Staff = 2
    [Display(Name="User Role")]
    public string? Title { get; set; }
    [DataType(DataType.Date)]
    public DateTime Date { get; set; }
    // For Department Selection 
    //DepartmentID: Account Management, Technical Issues, Billing and Payments, Other
   // [Display(Name = "Department")]
   // public int DepartmentID { get; set}
    public string? Description { get; set; }
}