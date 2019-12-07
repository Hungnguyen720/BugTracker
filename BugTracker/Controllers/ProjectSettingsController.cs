using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data.DataContext;
using Data.Models;

namespace BugTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectSettingsController : ControllerBase
    {
        private readonly ProjectSettingsContext _context;

        public ProjectSettingsController(ProjectSettingsContext context)
        {
            _context = context;
        }

        // GET: api/ProjectSettings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProjectSettingsModel>>> GetProjectSettings()
        {
            return await _context.ProjectSettings.ToListAsync();
        }

        // GET: api/ProjectSettings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProjectSettingsModel>> GetProjectSettings(int id)
        {
            var projectSettings = await _context.ProjectSettings.FindAsync(id);

            if (projectSettings == null)
            {
                return NotFound();
            }

            return projectSettings;
        }

        // PUT: api/ProjectSettings/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProjectSettings(int id, ProjectSettingsModel projectSettings)
        {
            if (id != projectSettings.Id)
            {
                return BadRequest();
            }

            _context.Entry(projectSettings).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectSettingsExists(id))
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

        // POST: api/ProjectSe=ttings
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ProjectSettingsModel>> PostProjectSettings(ProjectSettingsModel projectSettings)
        {
            int maxId = _context.ProjectSettings.Max(p => p.Id);

            projectSettings.Id = maxId + 1;

            projectSettings.ProjectOverview = "test";

            _context.ProjectSettings.Add(projectSettings);

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProjectSettings", new { id = projectSettings.Id }, projectSettings);
        }

        // DELETE: api/ProjectSettings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProjectSettingsModel>> DeleteProjectSettings(int id)
        {
            var projectSettings = await _context.ProjectSettings.FindAsync(id);
            if (projectSettings == null)
            {
                return NotFound();
            }

            _context.ProjectSettings.Remove(projectSettings);
            await _context.SaveChangesAsync();

            return projectSettings;
        }

        private bool ProjectSettingsExists(int id)
        {
            return _context.ProjectSettings.Any(e => e.Id == id);
        }
    }
}
