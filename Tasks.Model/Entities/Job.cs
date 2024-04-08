using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Model.Entities
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Worker> Workers { get; set; }
    }
}
