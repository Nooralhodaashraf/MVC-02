namespace MVC_02.Entites
{
    public class Session :BaseEntity
    {
        public string Descreption { get; set; } = default!;
        public int Capacity { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; } = default!;
    }
}
