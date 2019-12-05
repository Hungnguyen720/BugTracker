using Microsoft.EntityFrameworkCore;
using Data.Models;

namespace Data.DataContext
{
    public class ProjectSettingsContext : DbContext
    {
        public ProjectSettingsContext(DbContextOptions<ProjectSettingsContext> options) : base(options)
        {
        }

        public DbSet<ProjectSettingsModel> ProjectSettings { get; set; }
    }
}
