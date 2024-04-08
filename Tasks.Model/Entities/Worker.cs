using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Model.Entities
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int JobId { get; set; }
        public Job Job { get; set; }
    }
}
