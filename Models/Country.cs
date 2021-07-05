using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace European_Immigration.Models
{
    public class Country
    {
        [Key]
        [Required]
        [Display(Name = "Country Name")]
        public string CountryName { get; set; }
        public string Flag { get; set; }
        public string Capital { get; set; }
        public int? Population { get; set; }
        public virtual GeneralData GeneralData { get; set; }
        public virtual HealthcareAndScience HealthcareAndScience { get; set; }
        public virtual PoliticsAndEconomics PoliticsAndEconomics { get; set; }
        public virtual QualityOfLife QualityOfLife { get; set; }
        public virtual Taxes Taxes { get; set; }
    }
}