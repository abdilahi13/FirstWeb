using System.ComponentModel.DataAnnotations;

namespace mynew.model
{
    public class Category
    {
        [key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
