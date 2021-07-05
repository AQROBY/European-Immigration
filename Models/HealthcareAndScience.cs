using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace European_Immigration.Models
{
    public class HealthcareAndScience
    {
        [Key]
        [ForeignKey("Country")]
        [Required]
        [Display(Name = "Country Name")]
        public string CountryName { get; set; }
        public string Flag { get; set; }
        [Display(Name = "Healthcare Index")]
        public decimal? HealthcareIndex { get; set; }
        [Display(Name = "Life Expectancy")]
        public decimal? LifeExpectancy { get; set; }
        [Display(Name = "Scientific Documents H Index")]
        public int? ScientificDocumentsHIndex { get; set; }
        [Display(Name = "Human Development Index")]
        public decimal? HumanDevelopmentIndex { get; set; }
        public virtual Country Country { get; set; }

    }
}