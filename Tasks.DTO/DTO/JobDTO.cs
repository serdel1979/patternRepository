﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.DTO.DTO
{
    public class JobDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<WorkerDTO> Workers { get; set; }
    }
}
