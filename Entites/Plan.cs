namespace MVC_02.Entites
{
    public class Plan :BaseEntity
    { public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int DurationDays { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Membership> Memberships { get; set; }

    }
}
