using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SWF.CA.Data.Models;

namespace SWF.CA.Web.Models
{
    public class InsuranceCalculationModel
    {
        [Required(ErrorMessage = "Size is required")]
        [DisplayName("Size of Flat in Square Meter")]
        public double SquareMeter { get; set; }

        public InsuranceOption InuranceOption { get; set; }
    }
}
