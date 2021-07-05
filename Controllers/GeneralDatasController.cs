using European_Immigration.Models;
using European_Immigration.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace European_Immigration.Controllers
{
    public class GeneralDatasController : Controller
    {
        private ApplicationDbContext _context;
        public GeneralDatasController()
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

            var viewModel = new GeneralDataFormViewModel
            {
                Countries = countries
        };

            return View("GeneralDatasForm", viewModel);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Edit(string countryName)
        {
            var generalData = _context.GeneralDatas.SingleOrDefault(c => c.CountryName == countryName);

            if (generalData == null)
            {
                return HttpNotFound();
            }

            var viewModel = new GeneralDataFormViewModel
            {
                GeneralData = generalData,
                Countries = _context.Countries.ToList()
            };

            return View("GeneralDatasForm", viewModel);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Delete(string countryName)
        {
            GeneralData generalData = _context.GeneralDatas.Find(countryName);
            if (generalData == null)
            {
                return HttpNotFound();
            }

            return View(generalData);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string countryName)
        {
            GeneralData generalData = _context.GeneralDatas.Find(countryName);
            _context.GeneralDatas.Remove(generalData);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: GeneralDatas
        [AllowAnonymous]
        public ViewResult Index()
        {
            var generalData = _context.GeneralDatas.ToList();

            return View(generalData);
        }

        [AllowAnonymous]
        public ActionResult Details(string countryName)
        {
            var country = _context.GeneralDatas.SingleOrDefault(c => c.CountryName == countryName);

            if (country == null)
                return HttpNotFound();

            return View(country);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Save(GeneralData generalData)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new GeneralDataFormViewModel
                {
                    Countries = _context.Countries.ToList(),
                    GeneralData = generalData
                };

                return View("GeneralDatasForm", viewModel);
            }

            if (generalData.Flag == null)
            {
                generalData.Flag = "no";
            }

            if (_context.GeneralDatas.Find(generalData.CountryName) == null)
            {
                _context.GeneralDatas.Add(generalData);
            }
            else
            {
                var generalDataInDb = _context.GeneralDatas.Single(c => c.CountryName == generalData.CountryName);
                generalDataInDb.CountryName = generalData.CountryName;
                generalDataInDb.Flag = generalData.Flag;
                generalDataInDb.CostOfLiving = generalData.CostOfLiving;
                generalDataInDb.RentIndex = generalData.RentIndex;
                generalDataInDb.CostOfLivingPlusRentIndex = generalData.CostOfLivingPlusRentIndex;
                generalDataInDb.GroceriesIndex = generalData.GroceriesIndex;
                generalDataInDb.TaxRateIncome = generalData.TaxRateIncome;
                generalDataInDb.LocalPurchasingPowerIndex = generalData.LocalPurchasingPowerIndex;
                generalDataInDb.SafetyIndex = generalData.SafetyIndex;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "GeneralDatas");
        }
    }
}