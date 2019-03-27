using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SWF.CA.Data;
using SWF.CA.Data.Models;

namespace SWF.CA.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsuranceOptionsController : ControllerBase
    {
        private readonly CaContext _context;

        public InsuranceOptionsController(CaContext context)
        {
            _context = context;
        }

        // GET: api/InsuranceOptions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InsuranceOption>>> GetInsuranceOptions()
        {
            return await _context.InsuranceOptions.ToListAsync();
        }

        // GET: api/InsuranceOptions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InsuranceOption>> GetInsuranceOption(Guid id)
        {
            var insuranceOption = await _context.InsuranceOptions.FindAsync(id);

            if (insuranceOption == null)
            {
                return NotFound();
            }

            return insuranceOption;
        }

        // PUT: api/InsuranceOptions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInsuranceOption(Guid id, InsuranceOption insuranceOption)
        {
            if (id != insuranceOption.Id)
            {
                return BadRequest();
            }

            _context.Entry(insuranceOption).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InsuranceOptionExists(id))
                {
                    return NotFound();
                }

                throw;
            }

            return NoContent();
        }

        // POST: api/InsuranceOptions
        [HttpPost]
        public async Task<ActionResult<InsuranceOption>> PostInsuranceOption(InsuranceOption insuranceOption)
        {
            _context.InsuranceOptions.Add(insuranceOption);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInsuranceOption", new { id = insuranceOption.Id }, insuranceOption);
        }

        // DELETE: api/InsuranceOptions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InsuranceOption>> DeleteInsuranceOption(Guid id)
        {
            var insuranceOption = await _context.InsuranceOptions.FindAsync(id);
            if (insuranceOption == null)
            {
                return NotFound();
            }

            _context.InsuranceOptions.Remove(insuranceOption);
            await _context.SaveChangesAsync();

            return insuranceOption;
        }

        private bool InsuranceOptionExists(Guid id)
        {
            return _context.InsuranceOptions.Any(e => e.Id == id);
        }
    }
}
