using ClarkNetWebPortal.Models;
using GenericMvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenericMvc.Repositories;
using Microsoft.Extensions.Logging;

namespace ClarkNetWebPortal.Controllers.BasicMvc
{
    public class ApplicationController //: BasicController<int, Application>
    {
        public ApplicationController(IEntityRepository<Application> repository, ILogger<Application> logger) //: base(repository, logger)
        {
        }
    }
}
