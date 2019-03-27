using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SWF.CA.Services.Interfaces;
using SWF.CA.Web.Models;

namespace SWF.CA.Web.Controllers
{
    public class InsuranceCalculationController : Controller
    {
        private readonly IInsurenceService _insurenceService;

        public InsuranceCalculationController(IInsurenceService insurenceService)
        {
            _insurenceService = insurenceService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(InsuranceCalculationModel model)
        {
            model.InuranceOption = _insurenceService.GetInsuranceOptionForSquareMeter(model.SquareMeter);
            return View("Index",model);
        }
    }
}
