using System;

namespace DataAccessLayer.Models
{
    public class Language
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Decription { get; set; }
        public string Rating { get; set; }
        public User Editor { get; set; }
        public DateTime EditingDate { get; set; }
    }
}
