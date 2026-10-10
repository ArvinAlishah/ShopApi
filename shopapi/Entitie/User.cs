using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
 
namespace shopapi.Entitie
{
    public class User : baseEntity
    {

      
        public string FirstName {  get; set; } = null!;
        public string LasttName { get; set; } = null!;
        public string Mobile { set; get; } = null!;
        public string PassWordHash { get; set; } = null!;

        List<UserRole> UserRoles { set; get; } = null!;



    }
}
