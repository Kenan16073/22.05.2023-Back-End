using System.ComponentModel.DataAnnotations;

namespace P138AllupProject.Models
{
    public class Brand : BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }

        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
