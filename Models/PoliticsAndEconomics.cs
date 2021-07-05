using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace European_Immigration.Models
{
    public class PoliticsAndEconomics
    {
        [Key]
        [ForeignKey("Country")]
        [Required]
        [Display(Name = "Country Name")]
        public string CountryName { get; set; }
        public string Flag { get; set; }
        [Display(Name = "Rule Of Law Index")]
        public decimal? RuleOfLawIndex { get; set; }
        [Display(Name = "Political Stability Index")]
        public decimal? PoliticalStabilityIndex { get; set; }
        [Display(Name = "Corruption Index")]
        public int? CorruptionIndex { get; set; }
        [Display(Name = "State Fragility Index")]
        public decimal? StateFragilityIndex { get; set; }
        [Display(Name = "Economic Growth")]
        public string EconomicGrowth { get; set; }
        [Display(Name = "Gdp Per Capita")]
        public string GdpPerCapita { get; set; }
        public virtual Country Country { get; set; }

    }
}