using European_Immigration.Models;
using European_Immigration.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace European_Immigration.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CountriesController : Controller
    {
        private ApplicationDbContext _context;
        public CountriesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult New()
        {
            return View("CountriesForm");
        }

        public ActionResult Edit(string countryName)
        {
            var country = _context.Countries.SingleOrDefault(c => c.CountryName == countryName);

            if (country == null)
            {
                return HttpNotFound();
            }

            var viewModel = new CountryFormViewModel
            {
                Country = country
            };

            return View("CountriesForm", viewModel);
        }

        public ActionResult Delete(string countryName)
        {
            Country country = _context.Countries.Find(countryName);
            if (country == null)
            {
                return HttpNotFound();
            }

            return View(country);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string countryName)
        {
            HealthcareAndScience healthcareAndScience = _context.HealthcareAndScience.Find(countryName);
            if (healthcareAndScience != null)
            {
                _context.HealthcareAndScience.Remove(healthcareAndScience);
            }
            GeneralData generalData = _context.GeneralDatas.Find(countryName);
            if(generalData != null)
            {
                _context.GeneralDatas.Remove(generalData);
            }
            PoliticsAndEconomics politicsAndEconomics = _context.PoliticsAndEconomics.Find(countryName);
            if (politicsAndEconomics != null)
            {
                _context.PoliticsAndEconomics.Remove(politicsAndEconomics);
            }
            QualityOfLife qualityOfLife = _context.QualityOfLife.Find(countryName);
            if (qualityOfLife != null)
            {
                _context.QualityOfLife.Remove(qualityOfLife);
            }
            Taxes taxes = _context.Taxes.Find(countryName);
            if (taxes != null)
            {
                _context.Taxes.Remove(taxes);
            }

            Country country = _context.Countries.Find(countryName);

            _context.Countries.Remove(country);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ViewResult Index()
        {
            var countries = _context.Countries.ToList();

            return View(countries);
        }

        public ActionResult Details(string CountryName)
        {
            var country = _context.Countries.SingleOrDefault(c => c.CountryName == CountryName);

            if (country == null)
                return HttpNotFound();

            return View(country);
        }

        [HttpPost]
        public ActionResult Save(Country country)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CountryFormViewModel
                {
                    Country = country
                };

                return View("CountriesForm", viewModel);
            }

            if (country.Flag == null)
            {
                country.Flag = "no";
            }

            if (_context.Countries.Find(country.CountryName) == null)
            {
                _context.Countries.Add(country);
            }
            else
            {
                var countryInDb = _context.Countries.Single(c => c.CountryName == country.CountryName);
                countryInDb.CountryName = country.CountryName;
                countryInDb.Flag = country.Flag;
                countryInDb.Capital = country.Capital;
                countryInDb.Population = country.Population;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Countries");
        }
    }
}