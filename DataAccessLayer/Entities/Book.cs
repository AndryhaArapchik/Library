using DataAccessLayer.Enums;
using System;
using System.Collections.Generic;

namespace DataAccessLayer.Entities
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public virtual List<Author> Author { get; set; }
        public virtual List<Genre> Genre { get; set; }
        public int Year { get; set; }
        public virtual Publisher Publisher { get; set; }
        public virtual User Reader { get; set; }
        public Condition Condition { get; set; }
        public string Description { get; set; }
        public bool PossibilityIssuing { get; set; }
        public virtual List<Feedback> Reviews { get; set; }
        public virtual Language WritingLanguage { get; set; }
        public string Tags { get; set; }
        public int Term { get; set; }
        public DateTime DateRegistration { get; set; }
        public virtual User Editor { get; set; }
        public DateTime EditingDate { get; set; }
        public DateTime DateIssue { get; set; }
        public virtual User IssuedUser { get; set; }
        public virtual List<File> Photos { get; set; }
    }
}
