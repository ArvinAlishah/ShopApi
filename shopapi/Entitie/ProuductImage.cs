namespace shopapi.Entitie
{
    public class ProuductImage : baseEntity
    {
        public int productId { get; set; }
        public string Url { get; set; } = null;
         public string IsMain { get; set; }
        public Product Product { get; set; }
    }
}
