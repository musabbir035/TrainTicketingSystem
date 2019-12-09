using System;
using System.Collections.Generic;

namespace TrainTicketingSystem.Core.Domain
{
    public partial class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public int EmailValidated { get; set; }
        public int MobileNoValidated { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<LoginHistory> LoginHistories { get; set; }
    }
}
