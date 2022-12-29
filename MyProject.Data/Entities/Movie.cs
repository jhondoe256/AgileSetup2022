
using System.ComponentModel.DataAnnotations;

public class Movie
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public DateTime ReleaseDate { get; set; }
    public virtual List<Rating> Ratings { get; set; }
}
