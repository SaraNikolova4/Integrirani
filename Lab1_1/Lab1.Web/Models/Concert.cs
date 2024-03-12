using System.ComponentModel.DataAnnotations;

namespace Lab1.Web.Models
{
    public class Concert
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string  ConcertName { get; set; }
    
        public DateTime ConcertDate { get; set; }
        public int  ConcertPrice  { get; set; }
        [Required]
        public string  ConcertPlace{ get; set; }

        public virtual ICollection<Ticket>? Tickets { get; set; }


    }
}
