using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace European_Immigration.Models
{
    public class GeneralData
    {
        [Key]
        [ForeignKey("Country")]
        [Required]
        [Display(Name = "Country Name")]
        public string CountryName { get; set; }
        public string Flag { get; set; }
        [Display(Name = "Cost Of Living")]
        public decimal? CostOfLiving { get; set; }
        [Display(Name = "Rent Index")]
        public decimal? RentIndex { get; set; }
        [Display(Name = "Cost Of Living Plus Rent Index")]
        public decimal? CostOfLivingPlusRentIndex { get; set; }
        [Display(Name = "Groceries Index")]
        public decimal? GroceriesIndex { get; set; }
        [Display(Name = "Tax Rate Income")]
        public string TaxRateIncome { get; set; }
        [Display(Name = "Local Purchasing Power Index")]
        public decimal? LocalPurchasingPowerIndex { get; set; }
        [Display(Name = "Safety Index")]
        public decimal? SafetyIndex { get; set; }
        public virtual Country Country { get; set; }

    }
}