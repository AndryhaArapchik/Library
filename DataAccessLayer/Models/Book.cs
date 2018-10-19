using DataAccessLayer.Enums;
using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public List<Author> Author { get; set; }
        public List<Genre> Genre { get; set; }
        public int Year { get; set; }
        public Publisher Publisher { get; set; }
        public User Reader { get; set; }
        public Condition Condition { get; set; }
        public string Description { get; set; }
        public bool PossibilityIssuing { get; set; }
        public List<Feedback> Reviews { get; set; }
        public Language WritingLanguage { get; set; }
        public string Tags { get; set; }
        public int Term { get; set; }
        public DateTime DateRegistration { get; set; }
        public User Editor { get; set; }
        public DateTime EditingDate { get; set; }
        public DateTime DateIssue { get; set; }
        public User IssuedUser { get; set; }
        public List<File> Photos { get; set; }
    }
}
