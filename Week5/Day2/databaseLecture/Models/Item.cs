#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace databaseLecture.Models;
public class Item
{
    // we need ID 
    // make sure this is the name of your model 
    [Key]
    [Required]
    public int ItemId { get; set; }
    [Required]
    [MinLength(3)]
    public string Name { get; set; }
    public string Description { get; set; }
    // We always include a createdAt and UpdatedAt because it's good Practice 
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

}
