using System.Diagnostics.Contracts;

namespace shopapi.Entitie
{
    public class ProductCategory : baseEntity
    {
        public string Name { get; set; } = null!;
        public int? ParentId { get; set; }
        public ProductCategory? Parent {  get; set; }
        public List<ProductCategory> Children { get; set; } = null!;
        public List<Product> Product { get; set; } = null!;

    }
}
