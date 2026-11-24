namespace MVC_02.Entites
{
    public class Member : GymUsers
    {
        public string? photo { get; set; }
        public ICollection<Membership> MemberSubscribtion { get; set; } = default!;

    }
}
