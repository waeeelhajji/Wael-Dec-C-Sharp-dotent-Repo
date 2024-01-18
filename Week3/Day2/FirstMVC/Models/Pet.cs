#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;

namespace FirstMVC.Models;


public class Pet
{
    [Required(ErrorMessage = "Name here is Required")]
    public string Name { get; set; }
    [Required]
    [MinLength(2)]
    public string Species { get; set; }
    public bool IsFriendly { get; set; }
    [Required]
    [Range(0, int.MaxValue)]
    public int Age { get; set; }
}