using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EpidemicTracker.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;

namespace EpidemicTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookupDataController : ControllerBase
    {
        private readonly ILogger<LookupDataController> _logger;

        private EPContext _context;

        public LookupDataController(ILogger<LookupDataController> logger, EPContext context)
        {
            _logger = logger;
            _context = context;
        }

        [Route("getdiseasetypes")]
        [HttpGet]
        public IEnumerable<DiseaseType> GetDiseaseTypes()
        {
            
           return _context.DiseaseType.ToList();
            
        }

        [Route("getaddresstypes")]
        [HttpGet]
        public IEnumerable<AddressType> GetAddressTypes()
        {

            return _context.AddressType.ToList();

        }

        [Route("getoccupationtypes")]
        [HttpGet]
        public IEnumerable<OccupationType> GetOccupationTypes()
        {

            return _context.OccupationType.ToList();

        }

        [Route("getstaffrole")]
        [HttpGet]
        public IEnumerable<StaffRole> GetStaffRoles()
        {

            return _context.StaffRole.ToList();

        }

        [Route("gettreatmentstatus")]
        [HttpGet]
        public IEnumerable<TreatmentStatus> GetTreatmentStatuses()
        {

            return _context.TreatmentStatus.ToList();

        }

        [Route("getdiseasedetails")]
        [HttpGet]
        public IEnumerable<Disease> GetDisease()
        {

            return _context.Disease.ToList();

        }


    }   
    
}
