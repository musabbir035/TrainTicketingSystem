namespace TrainTicketingSystem.Core.Domain
{
    public partial class Train
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OffDay { get; set; }
        public int StartStation { get; set; }
        public int LastStation { get; set; }
    }
}
