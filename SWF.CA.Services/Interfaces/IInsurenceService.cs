using System;
using System.Collections.Generic;
using System.Text;
using SWF.CA.Data.Models;

namespace SWF.CA.Services.Interfaces
{
    public interface IInsurenceService
    {
        InsuranceOption GetInsuranceOptionForSquareMeter(double squareMeter);
    }
}
