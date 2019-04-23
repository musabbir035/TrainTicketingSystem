namespace TrainTicket.Core.Domain
{
    public partial class Ticket
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TrainId { get; set; }
        public int SourceId { get; set; }
        public int DestinationId { get; set; }
        public System.DateTime JourneyDate { get; set; }
        public string Compartment { get; set; }
        public string Seats { get; set; }
        public System.DateTime PurchaseDate { get; set; }
    }
}
