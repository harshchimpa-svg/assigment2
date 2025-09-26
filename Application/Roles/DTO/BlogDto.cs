using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Roles.DTO;

public class BlogDto
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsPublished { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
}
