using Storage;
namespace Cargo
{
    public class Authorization : IUser
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public bool Enabled { get; set; }
        public Role Role { get; set; }
    }
}
