using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.DTO.DTO;
using Tasks.Model.Entities;

namespace Tasks.Services.Job
{
    public interface IJobService
    {

        Task<IQueryable> GetJobs(int Page=1, int Size = 5);
        Task<JobDTO> GetById(int Id);
        Task Create(JobDTO job);
        Task Update(int Id, JobDTO job);
        Task Delete(int Id);

    }
}
