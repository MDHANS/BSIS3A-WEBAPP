using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace bsisweb_app.Models
{
    public class Type
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)] 
        public string Name { get; set; }

        public Item item { get; set; }
        public int ItemId { get; set; }
    }
}