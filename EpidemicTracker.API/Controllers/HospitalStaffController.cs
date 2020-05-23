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
    public class HospitalStaffController : ControllerBase
    {
        private ILogger<HospitalStaffController> _logger;

        private EPContext _context;

        public HospitalStaffController(ILogger<HospitalStaffController> logger, EPContext context)
        {
            _logger = logger;
            _context = context;
        }

       
        [Route("addhospitalstaff")]
        [HttpPost]
        public HospitalStaff AddHospitalStaff([FromBody] HospitalStaff hospitalstaff)
        {
            _context.HospitalStaff.Add(hospitalstaff);
            _context.SaveChanges();
            return hospitalstaff;
        }
    }
}
