using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace European_Immigration.Models
{
    public class Taxes
    {
        [Key]
        [ForeignKey("Country")]
        [Required]
        public string CountryName { get; set; }
        public string Flag { get; set; }
        [Display(Name = "Corporate Tax")]
        public string CorporateTax { get; set; }
        [Display(Name = "Income Tax")]
        public string IncomeTax { get; set; }
        public string Vat { get; set; }
        public virtual Country Country { get; set; }

    }
}