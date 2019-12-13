using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TshirtWeb.Api.Modules;
using TshirtWeb.Api.Data;
using System;

namespace TshirtWeb.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TshirtController : ControllerBase
    {
        private readonly Ygen _context;

        public TshirtController(Ygen context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<RedBat>> GetAll() =>
           _context.RedBats.ToList();

        [HttpGet("{id}")]
        public async Task<ActionResult<RedBat>> GetById(long id)
        {
            var ygen = await _context.RedBats.FindAsync(id);

            if (ygen == null)
            {
                return NotFound();
            }

            return ygen;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, RedBat product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<RedBat>> Create(RedBat redBat)
        {
            _context.RedBats.Add(redBat);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = redBat.Id }, redBat);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var redBat = await _context.RedBats.FindAsync(id);

            if (redBat == null)
            {
                return NotFound();
            }

            _context.RedBats.Remove(redBat);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}