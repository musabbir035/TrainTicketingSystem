using System.Data.Entity;

namespace TrainTicketingSystem.Core.Domain
{
    public class TrainDbContext : DbContext
    {
        public TrainDbContext() : base("TrainTicket")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<LoginHistory> LoginHistory { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Train> Trains { get; set; }
    }
}
