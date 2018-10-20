using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public class Publisher
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public virtual List<Feedback> Reviews { get; set; }
        public virtual List<Book> Books { get; set; }
        public virtual User Editor { get; set; }
        public DateTime EditingDate { get; set; }
    }
}
