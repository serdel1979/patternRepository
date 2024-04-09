using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.DTO.DTO;

namespace Tasks.Services.Job
{
    public class JobService : IJobService
    {
        public Task Create(JobDTO job)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable> GetJobs(int Page = 1, int Size = 5)
        {
            throw new NotImplementedException();
        }

        public Task Update(int Id, JobDTO job)
        {
            throw new NotImplementedException();
        }
    }
}
