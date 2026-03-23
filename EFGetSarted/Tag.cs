using System.ComponentModel.DataAnnotations;

namespace EFGetSarted;

public class Tag
{
    public int TagId { get; set; }
    //data notations
    [MaxLength(50)]
    [MinLength(3)]
    public string Name { get; set; }
    
    public int PostId { get; set; }
    public Post Post { get; set; }
}