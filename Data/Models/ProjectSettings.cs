using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    class ProjectSettings
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string ProjectTitle { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateEnd { get; set; }
        public  string ProjectOverview { get; set; }
    }
}
