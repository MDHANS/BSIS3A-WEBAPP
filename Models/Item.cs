using System.ComponentModel.DataAnnotations;

namespace bsisweb_app.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]

        public string Name { get; set; }
    }
}