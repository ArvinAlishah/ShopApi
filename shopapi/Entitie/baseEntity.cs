namespace shopapi.Entitie
{
    public  abstract class  baseEntity
    {
        public int Id { get; set; }

        public DateTime Datecreated { set; get; } = DateTime.Now;
    }
}
