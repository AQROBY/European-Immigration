using European_Immigration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace European_Immigration.ViewModels
{
    public class TaxesFormViewModel
    {
        public IEnumerable<Country> Countries { get; set; }
        public Taxes Taxes { get; set; }
    }
}