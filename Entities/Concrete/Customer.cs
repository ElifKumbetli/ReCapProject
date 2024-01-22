using Core.Entities;
using System.ComponentModel.DataAnnotations;

public class Customer : IEntity
{
    [Key]
    public int UserId { get; set; }

    public string? CompanyName { get; set; }
}


