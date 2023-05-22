namespace P138AllupProject.Models
{
    public class ProductsTag : BaseEntity
    {
        public int? ProductId { get; set; }
        public Product Product { get; set; }
        public int? TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
