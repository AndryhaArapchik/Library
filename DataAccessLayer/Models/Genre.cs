using System;

namespace DataAccessLayer.Models
{
    public class Genre
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public User Editor { get; set; }
        public DateTime EditingDate { get; set; }
    }
}
