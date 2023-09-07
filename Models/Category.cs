using System.ComponentModel.DataAnnotations;

public class Category{
    [Key]
    public int ID {get; set;}
    [Required]
    public required string Name { get; set; }
    public int DisplayOrder { get; set; }
    //Default DateTime property
    public DateTime CreatedDateTime { get; set; } = DateTime.Now; 
}