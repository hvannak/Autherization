using Autherization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autherization.Services
{
    public interface IControllerDiscovery
    {
        IEnumerable<ControllerInfo> GetControllers();
    }
}
