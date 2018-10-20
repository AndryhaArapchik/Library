using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (LDBContext lDBContext = new LDBContext()) {
                lDBContext.Files.Add(new File()
                {
                    Description = "Test",
                    Id = Guid.NewGuid(),
                    MIME = "PNG",
                    Path = "C\\",
                    Title = "porn"
                });
                lDBContext.SaveChanges();
            }
        }
    }
}
