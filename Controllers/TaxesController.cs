using European_Immigration.Models;
using European_Immigration.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace European_Immigration.Controllers
{
    public class TaxesController : Controller
    {
        private ApplicationDbContext _context;
        public TaxesController()
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

            var viewModel = new TaxesFormViewModel
            {
                Countries = countries
            };

            return View("TaxesForm", viewModel);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Edit(string countryName)
        {
            var taxes = _context.Taxes.SingleOrDefault(c => c.CountryName == countryName);

            if (taxes == null)
            {
                return HttpNotFound();
            }

            var viewModel = new TaxesFormViewModel
            {
                Taxes = taxes,
                Countries = _context.Countries.ToList()
            };

            return View("TaxesForm", viewModel);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Delete(string countryName)
        {
            Taxes taxes = _context.Taxes.Find(countryName);
            if (taxes == null)
            {
                return HttpNotFound();
            }

            return View(taxes);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string countryName)
        {
            Taxes taxes = _context.Taxes.Find(countryName);
            _context.Taxes.Remove(taxes);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [AllowAnonymous]
        public ViewResult Index()
        {
            var taxes = _context.Taxes.ToList();

            return View(taxes);
        }

        [AllowAnonymous]
        public ActionResult Details(string CountryName)
        {
            var country = _context.Taxes.SingleOrDefault(c => c.CountryName == CountryName);

            if (country == null)
                return HttpNotFound();

            return View(country);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Save(Taxes taxes)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new TaxesFormViewModel
                {
                    Countries = _context.Countries.ToList(),
                    Taxes = taxes
                };

                return View("TaxesForm", viewModel);
            }

            if (taxes.Flag == null)
            {
                taxes.Flag = "no";
            }

            if (_context.Taxes.Find(taxes.CountryName) == null)
            {
                _context.Taxes.Add(taxes);
            }
            else
            {
                var taxesInDb = _context.Taxes.Single(c => c.CountryName == taxes.CountryName);
                taxesInDb.CountryName = taxes.CountryName;
                taxesInDb.Flag = taxes.Flag;
                taxesInDb.CorporateTax = taxes.CorporateTax;
                taxesInDb.IncomeTax = taxes.IncomeTax;
                taxesInDb.Vat = taxes.Vat;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Taxes");
        }
    }
}