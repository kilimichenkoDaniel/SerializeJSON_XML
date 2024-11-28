using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Domain
{
    public class Song
    {
        public string Name { get; set; }

        public DateTime Duration { get; set; }

        public override string ToString() => $"{Name} {Duration}";
    }
}
