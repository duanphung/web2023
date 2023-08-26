using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testapicore6.Data;

namespace testapicore6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        private readonly UserStoreContext _context;

        public TestsController(UserStoreContext context)
        {
            _context = context;
        }

        // GET: api/Tests
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Test>>> Gettests()
        {
          if (_context.tests == null)
          {
              return NotFound();
          }
            return await _context.tests.ToListAsync();
        }

        // GET: api/Tests/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Test>> GetTest(string id)
        {
          if (_context.tests == null)
          {
              return NotFound();
          }
            var test = await _context.tests.FindAsync(id);

            if (test == null)
            {
                return NotFound();
            }

            return test;
        }

        // PUT: api/Tests/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTest(string id, Test test)
        {
            if (id != test.Id)
            {
                return BadRequest();
            }

            _context.Entry(test).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestExists(id))
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

        // POST: api/Tests
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Test>> PostTest(Test test)
        {
          if (_context.tests == null)
          {
              return Problem("Entity set 'UserStoreContext.tests'  is null.");
          }
            _context.tests.Add(test);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TestExists(test.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTest", new { id = test.Id }, test);
        }

        // DELETE: api/Tests/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTest(string id)
        {
            if (_context.tests == null)
            {
                return NotFound();
            }
            var test = await _context.tests.FindAsync(id);
            if (test == null)
            {
                return NotFound();
            }

            _context.tests.Remove(test);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TestExists(string id)
        {
            return (_context.tests?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
