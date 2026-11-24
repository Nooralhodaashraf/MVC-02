using MVC_02.Entites.Enums;

namespace MVC_02.Entites
{
    public class Trainer : GymUsers
    {
        public Spciality spciality { get; set; }
        public ICollection<Session> Sessions { get; set; } = default!;
    }
}
