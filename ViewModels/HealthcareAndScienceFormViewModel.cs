using European_Immigration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace European_Immigration.ViewModels
{
    public class HealthcareAndScienceFormViewModel
    {
        public IEnumerable<Country> Countries { get; set; }
        public HealthcareAndScience HealthcareAndScience { get; set; }
    }
}