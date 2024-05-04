//author: Nicholas Faz
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//using System.ComponentModel.DataAnnotations;

namespace TitanHelp.Models;

public class Ticket
{
    //ID required by database for pk
    public int ID { get; set; }

    //The question mark after string indicates that the property is nullable.
    public string? Name { get; set; }

    //RoleID: Student, Faculty, Staff 
    public RoleStatus RoleID { get; set; }
    //Removed required from ^
    public required IEnumerable<SelectListItem> RoleList { get; set; }

    //DepartmentID: Account Management, Technical Issues, Billing and Payments, Other  
    public DepartmentStatus DepartmentID { get; set; }
    //Removed required from ^
    public required IEnumerable<SelectListItem> DepartmentList { get; set; }

    //[DT] attribute to specifies the type of data in the Date property.
    //With this attribute: The user isn't required to enter time information in the date field.
    //Only the date is displayed, not time information.
    [DataType(DataType.Date)]
    public DateTime Date { get; set; }

    public string? Description { get; set; }

}