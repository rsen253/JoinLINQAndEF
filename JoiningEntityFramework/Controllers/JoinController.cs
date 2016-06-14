using JoiningEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JoiningEntityFramework.Controllers
{
    public class JoinController : Controller
    {
        DatabaseContext dbcontext = new DatabaseContext();
        // GET: Join
        public ActionResult Index()
        {
            var result = (from s in dbcontext.Student
                          join c in dbcontext.Country on s.CountryId equals c.CountryId
                          join k in dbcontext.Room on s.RoomId equals k.RoomId
                          select s).ToList();

            return View(result);
        }

        public ActionResult Create()
        {
            List<Country> allCountry = new List<Country>();
            using (DatabaseContext databasecontext = new DatabaseContext())
            {
                allCountry = databasecontext.Country.OrderBy(a => a.CountryName).ToList();
            }
            ViewBag.CountryId = new SelectList(allCountry, "CountryId", "CountryName");
            //var checkUser = (from s in dbcontext.Student where s.Name == );
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            List<Country> allCountry = new List<Country>();
            allCountry = dbcontext.Country.OrderBy(a => a.CountryName).ToList();
            ViewBag.CountryId = new SelectList(allCountry, "CountryId", "CountryName");
            dbcontext.Student.Add(student);
            dbcontext.SaveChanges();
            return View();
        }
        public ActionResult AddCountry()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCountry(Country country)
        {
            var checkCountry = (from s in dbcontext.Country where s.CountryName == country.CountryName select s).FirstOrDefault();
            if (checkCountry == null)
            {
                dbcontext.Country.Add(country);
                dbcontext.SaveChanges();
            }
            return View();
        }
    }
}