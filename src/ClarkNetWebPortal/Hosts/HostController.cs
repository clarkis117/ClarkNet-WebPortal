using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ClarkNetWebPortal.Models;
using GenericMvc.Controllers;
using GenericMvc.Repositories;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ClarkNetWebPortal.Controllers.BasicMvc
{
    [Authorize]
    public class HostController //: BasicController<int, Host>
    {
        public HostController(IEntityRepository<Host> repository, ILogger<Host> logger) //: base(repository, logger)
        {
        }
    }
}
