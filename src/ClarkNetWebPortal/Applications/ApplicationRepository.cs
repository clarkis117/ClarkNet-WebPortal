using ClarkNetWebPortal.Models;
using GenericMvc.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClarkNetWebPortal.DbContexts;

namespace ClarkNetWebPortal.Repositories
{
    public class ApplicationRepository : BaseEntityRepository<Application>
    {
        public ApplicationRepository(SqliteDbContext dbContext) : base(dbContext)
        {
        }
    }
}
