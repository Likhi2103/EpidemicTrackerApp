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
    public class TreatmentController : ControllerBase
    {
        private ILogger<TreatmentController> _logger;

        private EPContext _context;

        public TreatmentController(ILogger<TreatmentController> logger, EPContext context)
        {
            _logger = logger;
            _context = context;
        }


        [Route("addtreatment")]
        [HttpPost]
        public Treatment AddTreatment([FromBody] Treatment treatment)
        {
            _context.Treatment.Add(treatment);
            _context.SaveChanges();
            return treatment;
        }
    }
}
