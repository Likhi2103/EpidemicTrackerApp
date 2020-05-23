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
    public class HospitalController : ControllerBase
    {
        private ILogger<HospitalController> _logger;

        private EPContext _context;

        public HospitalController(ILogger<HospitalController> logger, EPContext context)
        {
            _logger = logger;
            _context = context;
        }

        //public Hospital AddHospital (Hospital hospital)
        //{
        //    Hospital
        //}
        [Route("addhospital")]
        [HttpPost]
        public void AddHospital([FromBody] Hospital hospital)
        {
            _context.Hospital.Add(hospital);
            _context.SaveChanges();
            //return _context.Hospital;
        }
    }
}
