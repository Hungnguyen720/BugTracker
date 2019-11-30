using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    class ProjectSettings
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public int IsActive { get; set; }
        public decimal Version { get; set; }
        public string GitRepo { get; set; }
        public int isArchived { get; set; }
    }
}
