using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public class Author
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string DateOfBirth { get; set; }
        public string DateOfDeath { get; set; }
        public virtual List<Feedback> Reviews { get; set; }
        public virtual List<Book> Books { get; set; }
        public string Description { get; set; }
        public virtual List<File> Photos { get; set; }
        public virtual User Editor { get; set; }
        public DateTime EditingDate { get; set; }
    }
}
