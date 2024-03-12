using Microsoft.AspNetCore.Identity;

namespace Lab1.Web.Models
{
    public class ConcertUser : IdentityUser
    {
        public String ? FirstName { get; set; }
        public String ? LastName { get; set; }
        public String ?  Address { get; set; }

        public virtual ICollection<Ticket> ? Tickets { get; set; }

    }
}
