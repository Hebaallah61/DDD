using SharedKernal;

namespace DDD.Catalog.Domain
{
    public class Product:AggregateRoot<int> //Entity<int>
    {
        public Product(int id):base(id)
        {
            Id= id;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Category> Categories = new();
        
    }
}