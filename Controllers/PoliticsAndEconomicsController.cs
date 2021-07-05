using European_Immigration.Models;
using European_Immigration.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace European_Immigration.Controllers
{
    public class PoliticsAndEconomicsController : Controller
    {
        private ApplicationDbContext _context;
        public PoliticsAndEconomicsController()
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

            var viewModel = new PoliticsAndEconomicsFormViewModel
            {
                Countries = countries
            };

            return View("PoliticsAndEconomicsForm", viewModel);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Edit(string countryName)
        {
            var politicsAndEconomics = _context.PoliticsAndEconomics.SingleOrDefault(c => c.CountryName == countryName);

            if (politicsAndEconomics == null)
            {
                return HttpNotFound();
            }

            var viewModel = new PoliticsAndEconomicsFormViewModel
            {
                PoliticsAndEconomics = politicsAndEconomics,
                Countries = _context.Countries.ToList()
            };

            return View("PoliticsAndEconomicsForm", viewModel);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Delete(string countryName)
        {
            PoliticsAndEconomics politicsAndEconomics = _context.PoliticsAndEconomics.Find(countryName);
            if (politicsAndEconomics == null)
            {
                return HttpNotFound();
            }

            return View(politicsAndEconomics);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string countryName)
        {
            PoliticsAndEconomics politicsAndEconomics = _context.PoliticsAndEconomics.Find(countryName);
            _context.PoliticsAndEconomics.Remove(politicsAndEconomics);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [AllowAnonymous]
        public ViewResult Index()
        {
            var politics = _context.PoliticsAndEconomics.ToList();

            return View(politics);
        }

        [AllowAnonymous]
        public ActionResult Details(string CountryName)
        {
            var country = _context.PoliticsAndEconomics.SingleOrDefault(c => c.CountryName == CountryName);

            if (country == null)
                return HttpNotFound();

            return View(country);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Save(PoliticsAndEconomics politicsAndEconomics)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new PoliticsAndEconomicsFormViewModel
                {
                    Countries = _context.Countries.ToList(),
                    PoliticsAndEconomics = politicsAndEconomics
                };

                return View("PoliticsAndEconomicsForm", viewModel);
            }

            if (politicsAndEconomics.Flag == null)
            {
                politicsAndEconomics.Flag = "no";
            }

            if (_context.PoliticsAndEconomics.Find(politicsAndEconomics.CountryName) == null)
            {
                _context.PoliticsAndEconomics.Add(politicsAndEconomics);
            }
            else
            {
                var politicsAndEconomicsInDb = _context.PoliticsAndEconomics.Single(c => c.CountryName == politicsAndEconomics.CountryName);
                politicsAndEconomicsInDb.CountryName = politicsAndEconomics.CountryName;
                politicsAndEconomicsInDb.Flag = politicsAndEconomics.Flag;
                politicsAndEconomicsInDb.RuleOfLawIndex = politicsAndEconomics.RuleOfLawIndex;
                politicsAndEconomicsInDb.PoliticalStabilityIndex = politicsAndEconomics.PoliticalStabilityIndex;
                politicsAndEconomicsInDb.CorruptionIndex = politicsAndEconomics.CorruptionIndex;
                politicsAndEconomicsInDb.StateFragilityIndex = politicsAndEconomics.StateFragilityIndex;
                politicsAndEconomicsInDb.EconomicGrowth = politicsAndEconomics.EconomicGrowth;
                politicsAndEconomicsInDb.GdpPerCapita = politicsAndEconomics.GdpPerCapita;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "PoliticsAndEconomics");
        }
    }
}