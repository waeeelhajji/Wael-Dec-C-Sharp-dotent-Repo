#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace mtmLecture.Models;
public class Cast
{
    [Key]
    public int CastId { get; set; }
    [Required]
    public int ActorId { get; set; }
    public Actor? Actor { get; set; }
    [Required]
    public int MovieId { get; set; }
    public Movie? Movie { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}