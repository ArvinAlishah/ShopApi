namespace shopapi.Entitie
{
    public class Product : baseEntity
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;
        public long Price { get; set; }
        public List<ProuductImage> Images { get; set; } = null!;


    }
}
