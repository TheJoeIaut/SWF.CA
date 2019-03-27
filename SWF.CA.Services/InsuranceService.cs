using System;
using System.Linq;
using SWF.CA.Data;
using SWF.CA.Data.Models;
using SWF.CA.Services.Interfaces;

namespace SWF.CA.Services
{
    public class InsuranceService :  IInsurenceService
    {
        private readonly CaContext _context;

        public InsuranceService(CaContext context)
        {
            _context = context;
        }

        public InsuranceOption GetInsuranceOptionForSquareMeter(double squareMeter)
        {
            return _context.InsuranceOptions.FirstOrDefault(x =>squareMeter <= x.MaxSquareMeter && squareMeter >= x.MinSquareMeter);
        }
    }
    
}
