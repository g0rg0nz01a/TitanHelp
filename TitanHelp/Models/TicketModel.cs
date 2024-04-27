//author: Nicholas Faz
using System.ComponentModel.DataAnnotations;

namespace TitanHelp.Models;

public class Ticket
{
    public int ID { get; set; }
    public string? Name { get; set; }
    public string? Title { get; set; }
    [DataType(DataType.Date)]
    public DateTime Date { get; set; }
    public string? Description { get; set; }
}