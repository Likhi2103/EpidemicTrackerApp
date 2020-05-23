using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EpidemicTracker.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EpidemicTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private ILogger<AddressController> _logger;

        private EPContext _context;

        public AddressController(ILogger<AddressController> logger, EPContext context)
        {
            _logger = logger;
            _context = context;
        }

        
        [Route("addaddress")]
        [HttpPost]
        public Address AddAddress([FromBody] Address address)
        {
            _context.Address.Add(address);

            _context.SaveChanges();
            return address;
        }
    }
}
