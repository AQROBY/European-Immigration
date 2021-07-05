using European_Immigration.Models;
using European_Immigration.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace European_Immigration.Controllers
{
    public class QualityOfLivesController : Controller
    {
        private ApplicationDbContext _context;
        public QualityOfLivesController()
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

            var viewModel = new QualityOfLivesFormViewModel
            {
                Countries = countries
            };

            return View("QualityOfLivesForm", viewModel);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Edit(string countryName)
        {
            var qualityOfLives = _context.QualityOfLife.SingleOrDefault(c => c.CountryName == countryName);

            if (qualityOfLives == null)
            {
                return HttpNotFound();
            }

            var viewModel = new QualityOfLivesFormViewModel
            {
                QualityOfLife = qualityOfLives,
                Countries = _context.Countries.ToList()
            };

            return View("QualityOfLivesForm", viewModel);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Delete(string countryName)
        {
            QualityOfLife qualityOfLife = _context.QualityOfLife.Find(countryName);
            if (qualityOfLife == null)
            {
                return HttpNotFound();
            }

            return View(qualityOfLife);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string countryName)
        {
            QualityOfLife qualityOfLife = _context.QualityOfLife.Find(countryName);
            _context.QualityOfLife.Remove(qualityOfLife);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [AllowAnonymous]
        public ViewResult Index()
        {
            var quality = _context.QualityOfLife.ToList();

            return View(quality);
        }

        [AllowAnonymous]
        public ActionResult Details(string CountryName)
        {
            var country = _context.QualityOfLife.SingleOrDefault(c => c.CountryName == CountryName);

            if (country == null)
                return HttpNotFound();

            return View(country);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Save(QualityOfLife qualityOfLife)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new QualityOfLivesFormViewModel
                {
                    Countries = _context.Countries.ToList(),
                    QualityOfLife = qualityOfLife
                };

                return View("QualityOfLivesForm", viewModel);
            }

            if (qualityOfLife.Flag == null)
            {
                qualityOfLife.Flag = "no";
            }

            if (_context.QualityOfLife.Find(qualityOfLife.CountryName) == null)
            {
                _context.QualityOfLife.Add(qualityOfLife);
            }
            else
            {
                var qualityOfLifeInDb = _context.QualityOfLife.Single(c => c.CountryName == qualityOfLife.CountryName);
                qualityOfLifeInDb.CountryName = qualityOfLife.CountryName;
                qualityOfLifeInDb.Flag = qualityOfLife.Flag;
                qualityOfLifeInDb.QualityOfLifeIndex = qualityOfLife.QualityOfLifeIndex;
                qualityOfLifeInDb.PurchasingPowerIndex = qualityOfLife.PurchasingPowerIndex;
                qualityOfLifeInDb.safetyIndex = qualityOfLife.safetyIndex;
                qualityOfLifeInDb.healthcareIndex = qualityOfLife.healthcareIndex;
                qualityOfLifeInDb.costOfLivingIndex = qualityOfLife.costOfLivingIndex;
                qualityOfLifeInDb.propertyPriceToIncomeRatio = qualityOfLife.propertyPriceToIncomeRatio;
                qualityOfLifeInDb.trafficCommuteTimeIndex = qualityOfLife.trafficCommuteTimeIndex;
                qualityOfLifeInDb.pollutionIndex = qualityOfLife.pollutionIndex;
                qualityOfLifeInDb.climateIndex = qualityOfLife.climateIndex;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "QualityOfLives");
        }
    }
}