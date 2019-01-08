using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Project
    {
        public string Name { get; set; }
        public List<Tuple<Employee, int>> Workers  { get; set; }
        public DateTime StarTime { get; set; } 
        public DateTime EndTime { get; set; }
    }
}

