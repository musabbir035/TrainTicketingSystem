using Microsoft.EntityFrameworkCore;
using TrainTicketingSystem.Core.Domain;

namespace TrainTicketingSystem.Infrastructure
{
    public class TrainDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<LoginHistory> LoginHistories { get; set; }
        public DbSet<PasswordReset> PasswordResets { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketSeat> TicketSeats { get; set; }
        public DbSet<Train> Trains { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=INCOGNITO;Initial Catalog=TrainTicket; Integrated Security=True");
        }
    }
}
