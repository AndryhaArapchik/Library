using System;

namespace DataAccessLayer.Models
{
    public class Feedback
    {
        public Guid Id { get; set; }
        public string Decription { get; set; }
        public int Rating { get; set; }
        public virtual User Author { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
