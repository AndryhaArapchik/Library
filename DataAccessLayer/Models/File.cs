using System;

namespace DataAccessLayer.Models
{
    public class File
    {
        public Guid Id { get; set; }
        public string MIME { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
    }
}
