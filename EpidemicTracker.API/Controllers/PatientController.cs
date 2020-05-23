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
    public class PatientController : ControllerBase
    {
        private ILogger<PatientController> _logger;

        private EPContext _context;

        public PatientController(ILogger<PatientController> logger, EPContext context)
        {
            _logger = logger;
            _context = context;
        }


        [Route("addpatient")]
        [HttpPost]
        public Patient AddTreatment([FromBody] Patient patient)
        {
            _context.Patient.Add(patient);
            _context.SaveChanges();
            return patient;
        }
    }
}
