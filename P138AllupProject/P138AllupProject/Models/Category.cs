using System.ComponentModel.DataAnnotations;

namespace P138AllupProject.Models
{
    public class Category : BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsMain { get; set; }
        [StringLength(255)]
        public string? Image { get; set; }

        public int? ParentId { get; set; }
        public Category? Parent { get; set; }
    }
}
