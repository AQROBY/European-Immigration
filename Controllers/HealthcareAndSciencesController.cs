using European_Immigration.Models;
using European_Immigration.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace European_Immigration.Controllers
{
    public class HealthcareAndSciencesController : Controller
    {
        private ApplicationDbContext _context;
        public HealthcareAndSciencesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Authorize(Roles = "Admin")]
        public ViewResult New()
        {
            var countries = _context.Countries.ToList();

            var viewModel = new HealthcareAndScienceFormViewModel
            {
                Countries = countries
            };

            return View("HealthcareAndSciencesForm", viewModel);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Edit(string countryName)
        {
            var healthcareAndScience = _context.HealthcareAndScience.SingleOrDefault(c => c.CountryName == countryName);

            if (healthcareAndScience == null)
            {
                return HttpNotFound();
            }

            var viewModel = new HealthcareAndScienceFormViewModel
            {
                HealthcareAndScience = healthcareAndScience,
                Countries = _context.Countries.ToList()
            };

            return View("HealthcareAndSciencesForm", viewModel);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Delete(string countryName)
        {
            HealthcareAndScience healthcareAndScience = _context.HealthcareAndScience.Find(countryName);
            if (healthcareAndScience == null)
            {
                return HttpNotFound();
            }

            return View(healthcareAndScience);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string countryName)
        {
            HealthcareAndScience healthcareAndScience = _context.HealthcareAndScience.Find(countryName);
            _context.HealthcareAndScience.Remove(healthcareAndScience);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [AllowAnonymous]
        public ViewResult Index()
        {
            var healthcare = _context.HealthcareAndScience.ToList();

            return View(healthcare);
        }

        [AllowAnonymous]
        public ActionResult Details(string CountryName)
        {
            var country = _context.HealthcareAndScience.SingleOrDefault(c => c.CountryName == CountryName);

            if (country == null)
                return HttpNotFound();

            return View(country);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Save(HealthcareAndScience healthcareAndScience)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new HealthcareAndScienceFormViewModel
                {
                    Countries = _context.Countries.ToList(),
                    HealthcareAndScience = healthcareAndScience
                };

                return View("HealthcareAndSciencesForm", viewModel);
            }

            if (healthcareAndScience.Flag == null)
            {
                healthcareAndScience.Flag = "no";
            }

            if (_context.HealthcareAndScience.Find(healthcareAndScience.CountryName) == null)
            {
                _context.HealthcareAndScience.Add(healthcareAndScience);
            }
            else
            {
                var healthcareAndScienceInDb = _context.HealthcareAndScience.Single(c => c.CountryName == healthcareAndScience.CountryName);
                healthcareAndScienceInDb.CountryName = healthcareAndScience.CountryName;
                healthcareAndScienceInDb.Flag = healthcareAndScience.Flag;
                healthcareAndScienceInDb.HealthcareIndex = healthcareAndScience.HealthcareIndex;
                healthcareAndScienceInDb.LifeExpectancy = healthcareAndScience.LifeExpectancy;
                healthcareAndScienceInDb.ScientificDocumentsHIndex = healthcareAndScience.ScientificDocumentsHIndex;
                healthcareAndScienceInDb.HumanDevelopmentIndex = healthcareAndScience.HumanDevelopmentIndex;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "HealthcareAndSciences");
        }
    }
}