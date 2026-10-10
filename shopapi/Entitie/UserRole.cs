namespace shopapi.Entitie
{
    public class UserRole : baseEntity
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public User User { get; set; } = null!;
        public UserRole Role { get; set; } = null!;
    }
}
