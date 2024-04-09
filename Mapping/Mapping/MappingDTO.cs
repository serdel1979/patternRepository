using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.DTO.DTO;
using Tasks.Model.Entities;

namespace Mapping.Mapping
{
    public class MappingDTO : Profile
    {

        public MappingDTO()
        {
            CreateMap<Job,JobDTO>().ReverseMap();
            CreateMap<Worker,WorkerDTO>().ReverseMap();
        }


    }
}
