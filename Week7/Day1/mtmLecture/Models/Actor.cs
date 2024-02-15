#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace mtmLecture.Models;
public class Actor
{
    [Key]
    public int ActorId { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    // navigation properties
    public List<Cast> MyMovies { get; set; } = new List<Cast>();
}