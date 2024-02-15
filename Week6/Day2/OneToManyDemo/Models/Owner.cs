#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace OneToManyDemo.Models;


public class Owner
{
    [Key]
    public int OwnerId { get; set; }
    [Required]
    public string Name { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdateAt { get; set; } = DateTime.Now;
    public List<Pet> PetsOwned { get; set; } = new List<Pet>();

}