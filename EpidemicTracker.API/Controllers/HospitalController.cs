using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EpidemicTracker.API.ViewModels;
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
        public HospitalStaffViewModel AddHospitalStaff([FromBody] HospitalStaffViewModel hospitalStaffViewModel)
        {
            HospitalStaff hospitalStaff = new HospitalStaff()
            {
                IsActive = true,
                DateCreated = DateTime.UtcNow,
                DateModified = DateTime.UtcNow,
                UserCreated = hospitalStaffViewModel.StaffName,
                UserModified = hospitalStaffViewModel.StaffName,
                StaffName = hospitalStaffViewModel.StaffName,
                UserName = hospitalStaffViewModel.UserName,
                FirstName = hospitalStaffViewModel.Firstname,
                LastName = hospitalStaffViewModel.Lastname,
                Age = hospitalStaffViewModel.Age,
                Gender = hospitalStaffViewModel.Gender,
                PhoneNo = hospitalStaffViewModel.PhoneNo,
                GovernmentIdNo = hospitalStaffViewModel.GovernmentIdNo,
                EmailId = hospitalStaffViewModel.EmailId,
                Password = hospitalStaffViewModel.Password,
                HospitalId = hospitalStaffViewModel.HospitalId,
                StaffRoleId = hospitalStaffViewModel.StaffRoleId,

                AddressLine = hospitalStaffViewModel.AddressLine,
                Area = hospitalStaffViewModel.Area,
                City = hospitalStaffViewModel.City,
                State = hospitalStaffViewModel.State,
                Country = hospitalStaffViewModel.Country,
                Pincode = hospitalStaffViewModel.Pincode,                
                
            };


            _context.HospitalStaff.Add(hospitalStaff);
            _context.SaveChanges();


            hospitalStaffViewModel.Id = hospitalStaff.Id;
            hospitalStaffViewModel.HospitalId = hospitalStaff.HospitalId;
            hospitalStaffViewModel.StaffRoleId = hospitalStaff.StaffRoleId;



            return hospitalStaffViewModel;

        }
    }
}
