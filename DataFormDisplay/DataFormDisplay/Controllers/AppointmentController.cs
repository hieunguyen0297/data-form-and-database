using DataFormDisplay.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataFormDisplay.Controllers
{
    public class AppointmentController : Controller
    {
        //this will store all the appointment created and display in index
        static List<Appointment> appoinments = new List<Appointment>();
        public IActionResult Index()
        {
            //view a list of appointments
            //return appointment and view as a list
            return View(appoinments);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Details(Appointment appt)
        {
            appoinments.Add(appt);
            return View("Details",appt);
        }

    }
}
