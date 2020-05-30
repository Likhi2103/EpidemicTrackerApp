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
        public PatientViewModel AddPatient([FromBody] PatientViewModel patientViewModel)
        {

            Patient patient = new Patient()
            {
                IsActive = true,
                DateCreated = DateTime.UtcNow,
                DateModified = DateTime.UtcNow,
                UserCreated = patientViewModel.UserName ,
                UserModified=patientViewModel.UserName,
                UserName = patientViewModel.UserName,
                FirstName = patientViewModel.FirstName,
                LastName = patientViewModel.LastName,
                Gender = patientViewModel.Gender,
                Age = patientViewModel.Age,
                EmailId = patientViewModel.EmailId,
                Password = patientViewModel.Password,
                PhoneNo = patientViewModel.PhoneNo,
                GovernmentIdNo = patientViewModel.GovernmentIdNo,
                OccupationTypeId = patientViewModel.OccupationTypeId,
                OccCompanyName = patientViewModel.OccCompanyName,
                OccupationPhoneNo = patientViewModel.OccupationPhoneNo,
            };
            _context.Patient.Add(patient);
            _context.SaveChanges();

            var permanentAddress = new Address()
            {
                IsActive = true,
                DateCreated = DateTime.UtcNow,
                DateModified = DateTime.UtcNow,
                UserCreated = patientViewModel.UserName,
                UserModified = patientViewModel.UserName,
                HouseNo = patientViewModel.permanentAddress.HouseNo,
                Street = patientViewModel.permanentAddress.Street,
                Locality = patientViewModel.permanentAddress.Locality,
                City = patientViewModel.permanentAddress.City,
                Pincode = patientViewModel.permanentAddress.Pincode,
                State = patientViewModel.permanentAddress.State,
                Country = patientViewModel.permanentAddress.Country,
                PatientId = patient.Id,
                AddressTypeId = 1,
            };
            _context.Address.Add(permanentAddress);
            _context.SaveChanges();

            var currentAddress = new Address()
            {
                IsActive = true,
                DateCreated = DateTime.UtcNow,
                DateModified = DateTime.UtcNow,
                UserCreated = patientViewModel.UserName,
                UserModified = patientViewModel.UserName,
                HouseNo = patientViewModel.currentAddress.HouseNo,
                Street = patientViewModel.currentAddress.Street,
                Locality = patientViewModel.currentAddress.Locality,
                City = patientViewModel.currentAddress.City,
                Pincode = patientViewModel.currentAddress.Pincode,
                State = patientViewModel.currentAddress.State,
                Country = patientViewModel.currentAddress.Country,
                PatientId = patient.Id,
                AddressTypeId = 2,
            };
            _context.Address.Add(currentAddress);
            _context.SaveChanges();


            var workAddress = new Address()
            {
                IsActive = true,
                DateCreated = DateTime.UtcNow,
                DateModified = DateTime.UtcNow,
                UserCreated = patientViewModel.UserName,
                UserModified = patientViewModel.UserName,
                HouseNo = patientViewModel.workAddress.HouseNo,
                Street = patientViewModel.workAddress.Street,
                Locality = patientViewModel.workAddress.Locality,
                City = patientViewModel.workAddress.City,
                Pincode = patientViewModel.workAddress.Pincode,
                State = patientViewModel.workAddress.State,
                Country = patientViewModel.workAddress.Country,
                PatientId = patient.Id,
                AddressTypeId = 3,
            };
            _context.Address.Add(workAddress);
            _context.SaveChanges();

            patientViewModel.Id = patient.Id;
            patientViewModel.permanentAddress.PatientId = patient.Id;
            patientViewModel.currentAddress.PatientId = patient.Id;
            patientViewModel.workAddress.PatientId = patient.Id;
            patientViewModel.permanentAddress.AddressTypeId = 1;
            patientViewModel.currentAddress.AddressTypeId = 2;
            patientViewModel.workAddress.AddressTypeId = 3;
            

            return patientViewModel;
        }
    }
}
