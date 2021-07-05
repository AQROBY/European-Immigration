using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace European_Immigration.Models
{
    public class QualityOfLife
    {
        [Key]
        [ForeignKey("Country")]
        [Required]
        [Display(Name = "Country Name")]
        public string CountryName { get; set; }
        public string Flag { get; set; }
        [Display(Name = "Quality Of Life Index")]
        public decimal? QualityOfLifeIndex { get; set; }
        [Display(Name = "Purchasing Power Index")]
        public decimal? PurchasingPowerIndex { get; set; }
        [Display(Name = "Safety Index")]
        public decimal? safetyIndex { get; set; }
        [Display(Name = "Healthcare Index")]
        public decimal? healthcareIndex { get; set; }
        [Display(Name = "Cost Of Living Index")]
        public decimal? costOfLivingIndex { get; set; }
        [Display(Name = "Property Price To Income Ratio")]
        public decimal? propertyPriceToIncomeRatio { get; set; }
        [Display(Name = "Traffic Commute Time Index")]
        public decimal? trafficCommuteTimeIndex { get; set; }
        [Display(Name = "Pollution Index")]
        public decimal? pollutionIndex { get; set; }
        [Display(Name = "Climate Index")]
        public decimal? climateIndex { get; set; }
        public virtual Country Country { get; set; }

    }
}