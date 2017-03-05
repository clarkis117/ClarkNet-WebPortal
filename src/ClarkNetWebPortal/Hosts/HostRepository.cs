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
    public class HostRepository : BaseEntityRepository<Host>
    {
        public HostRepository(SqliteDbContext dbContext) : base(dbContext)
        {
        }
    }
}
