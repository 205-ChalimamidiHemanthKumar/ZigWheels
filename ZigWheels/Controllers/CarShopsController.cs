using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZigWheels.Data;
using ZigWheels.Models;

namespace ZigWheels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarShopsController : ControllerBase
    {
        private readonly ZigWheelsContext _context;

        public CarShopsController(ZigWheelsContext context)
        {
            _context = context;
        }

        // GET: api/CarShops
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarShop>>> GetCarShop()
        {
            return await _context.CarShop.ToListAsync();
        }

        // GET: api/CarShops/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarShop>> GetCarShop(int id)
        {
            var carShop = await _context.CarShop.FindAsync(id);

            if (carShop == null)
            {
                return NotFound();
            }

            return carShop;
        }

        // PUT: api/CarShops/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarShop(int id, CarShop carShop)
        {
            if (id != carShop.CarShopId)
            {
                return BadRequest();
            }

            _context.Entry(carShop).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarShopExists(id))
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

        // POST: api/CarShops
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CarShop>> PostCarShop(CarShop carShop)
        {
            _context.CarShop.Add(carShop);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarShop", new { id = carShop.CarShopId }, carShop);
        }

        // DELETE: api/CarShops/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarShop(int id)
        {
            var carShop = await _context.CarShop.FindAsync(id);
            if (carShop == null)
            {
                return NotFound();
            }

            _context.CarShop.Remove(carShop);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarShopExists(int id)
        {
            return _context.CarShop.Any(e => e.CarShopId == id);
        }
    }
}
