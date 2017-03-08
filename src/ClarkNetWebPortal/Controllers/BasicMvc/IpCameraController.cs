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
    public class IpCameraController //: BasicController<int, IpCamera>
    {
        public IpCameraController(IEntityRepository<IpCamera> repository, ILogger<IpCamera> logger) //: base(repository, logger)
        {
        }
    }
}
