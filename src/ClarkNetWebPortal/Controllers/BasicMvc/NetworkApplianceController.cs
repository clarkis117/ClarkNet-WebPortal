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
    public class NetworkApplianceController : BasicController<int, NetworkAppliance>
    {
        public NetworkApplianceController(IEntityRepository<NetworkAppliance> repository, ILogger<NetworkAppliance> logger) : base(repository, logger)
        {
        }
    }
}
