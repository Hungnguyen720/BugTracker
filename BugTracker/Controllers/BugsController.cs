using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data.DataContext;
using Data.Models;
using Microsoft.AspNetCore.Authorization;

namespace BugTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BugsController : ControllerBase
    {
        private readonly BugContext _context;

        public BugsController(BugContext context)
        {
            _context = context;
        }

        // GET: api/Bugs
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Bugs>>> GetBug()
        {
            return await _context.Project_Bugs.ToListAsync();
        }

        // GET: api/Bugs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bugs>> GetBug(int id)
        {
            var bug = await _context.Project_Bugs.FindAsync(id);

            if (bug == null)
            {
                return NotFound();
            }

            return bug;
        }

        // PUT: api/Bugs/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBug(int id, Bugs bug)
        {

            if (id != bug.Id)
            {
                return BadRequest();
            }

            _context.Entry(bug).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BugExists(id))
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

        // POST: api/Bugs
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Bugs>> PostBug(Bugs bug)
        {
            int maxId = _context.Project_Bugs.Max(b => b.Id);

            bug.Id = maxId + 1;

            _context.Project_Bugs.Add(bug);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBug", new { id = bug.Id }, bug);
        }

        // DELETE: api/Bugs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Bugs>> DeleteBug(int id)
        {
            var bug = await _context.Project_Bugs.FindAsync(id);
            if (bug == null)
            {
                return NotFound();
            }

            _context.Project_Bugs.Remove(bug);
            await _context.SaveChangesAsync();

            return bug;
        }

        private bool BugExists(int id)
        {
            return _context.Project_Bugs.Any(e => e.Id == id);
        }
    }
}
