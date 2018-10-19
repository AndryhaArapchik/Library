using DataAccessLayer.Enums;
using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string PassportDetails { get; set; }
        public string DateOfDeath { get; set; }
        public int Rating { get; set; }
        public List<Book> Books { get; set; }
        public string Description { get; set; }
        public File Photo { get; set; }
        public User Editor { get; set; }
        public DateTime EditingDate { get; set; }
        public Role Role { get; set; }
    }
}
