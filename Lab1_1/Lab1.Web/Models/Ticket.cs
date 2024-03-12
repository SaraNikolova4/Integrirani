using System.ComponentModel.DataAnnotations;

namespace Lab1.Web.Models
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }

        public int Pepoles { get; set; }

        public Guid ConcertId { get; set; }

        public Concert? Concerts { get; set; }

        public ConcertUser? ConcertUser { get; set; }
    }
}
