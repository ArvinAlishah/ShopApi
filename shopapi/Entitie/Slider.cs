namespace shopapi.Entitie
{
    public class Slider  : baseEntity
    {
        public string ImageUrl { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
