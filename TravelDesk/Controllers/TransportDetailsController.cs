using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelDesk.Context;
using TravelDeskNst.Models;

namespace TravelDesk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransportDetailsController : ControllerBase
    {
        private readonly TravelDeskDbContext _context;

        public TransportDetailsController(TravelDeskDbContext context)
        {
            _context = context;
        }

        // GET: api/TransportDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransportDetail>>> GetTransportDetails()
        {
          if (_context.TransportDetails == null)
          {
              return NotFound();
          }
            return await _context.TransportDetails.ToListAsync();
        }

        // GET: api/TransportDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TransportDetail>> GetTransportDetail(int id)
        {
          if (_context.TransportDetails == null)
          {
              return NotFound();
          }
            var transportDetail = await _context.TransportDetails.FindAsync(id);

            if (transportDetail == null)
            {
                return NotFound();
            }

            return transportDetail;
        }

        // PUT: api/TransportDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransportDetail(int id, TransportDetail transportDetail)
        {
            if (id != transportDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(transportDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransportDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TransportDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TransportDetail>> PostTransportDetail(TransportDetail transportDetail)
        {
          if (_context.TransportDetails == null)
          {
              return Problem("Entity set 'TravelDeskDbContext.TransportDetails'  is null.");
          }
            _context.TransportDetails.Add(transportDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTransportDetail", new { id = transportDetail.Id }, transportDetail);
        }

        // DELETE: api/TransportDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTransportDetail(int id)
        {
            if (_context.TransportDetails == null)
            {
                return NotFound();
            }
            var transportDetail = await _context.TransportDetails.FindAsync(id);
            if (transportDetail == null)
            {
                return NotFound();
            }

            _context.TransportDetails.Remove(transportDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TransportDetailExists(int id)
        {
            return (_context.TransportDetails?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
