using Final_Exam_Practice.Data;
using Final_Exam_Practice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Exam_Practice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly DataDbContext _dataDbContext;  //start this line for store database in db

        public List<Student> MyContacts { get; private set; }

        public HomeController(DataDbContext dataDbContext)
        {

            _dataDbContext = dataDbContext;

        }
        [HttpGet]
        public IActionResult Contact()
        {
            MyContacts = _dataDbContext.Students.ToList();
            return View(MyContacts);
        }
        [HttpPost]
        public IActionResult Contact(Student std)
        {
            try
            {
                _dataDbContext.Students.Add(std);
                _dataDbContext.SaveChanges();
                ViewData["message"] = "Data saved successflly";
                return RedirectToAction("Contact");
            }
            catch (Exception)
            {
                ViewData["message"] = "Data not saved";
                return RedirectToAction("Contact");

            }

            
        }
    } }
