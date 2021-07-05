using European_Immigration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace European_Immigration.ViewModels
{
    public class GeneralDataFormViewModel
    {
        public IEnumerable<Country> Countries { get; set; }
        public GeneralData GeneralData { get; set; }
    }
}