using European_Immigration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace European_Immigration.ViewModels
{
    public class QualityOfLivesFormViewModel
    {
        public IEnumerable<Country> Countries { get; set; }
        public QualityOfLife QualityOfLife { get; set; }
    }
}