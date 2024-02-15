#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace mtmLecture.Models;
public class Movie
{
    [Key]
    public int MovieId { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    // navigation properties
    public List<Cast> MyActors { get; set; } = new List<Cast>();
}