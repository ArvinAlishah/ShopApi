namespace shopapi.Entitie
{
    public class Role : baseEntity
    {
        public string Name { get; set; }
        public string DisplayName {  get; set; }
        List<UserRole> UserRoles { set; get; } = null!;

    }
}
