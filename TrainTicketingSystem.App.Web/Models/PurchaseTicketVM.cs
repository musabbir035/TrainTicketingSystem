using System.ComponentModel.DataAnnotations;

namespace TrainTicketingSystem.App.Web.Models
{
    public class PurchaseTicketVM
    {
        [Required]
        public int Source { get; set; }
        [Required]
        public int Destination { get; set; }
        [Required]
        public string Date { get; set; }
    }
}