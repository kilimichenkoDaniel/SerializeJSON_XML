using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Domain
{
    public class Album
    {
        public string Author { get; set; }

        public string Name { get; set; }

        public string Genre { get; set; }

        public int Year { get; set; }
        
        public List<Song> Songs { get; set; }
    }
}
