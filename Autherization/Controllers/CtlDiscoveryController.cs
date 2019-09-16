using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autherization.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Autherization.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CtlDiscoveryController : ControllerBase
    {
        private readonly IControllerDiscovery _controllerDiscovery;
        public CtlDiscoveryController(IControllerDiscovery controllerDiscovery)
        {
            _controllerDiscovery = controllerDiscovery;
        }

        [HttpGet]
        //api/CtlDiscovery
        public System.Object GetCtlvalue()
        {
            var result = _controllerDiscovery.GetControllers();
            return result;
        }
    }
}