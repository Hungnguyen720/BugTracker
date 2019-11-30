using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    class IssueModel
    {
        public int Id { get; set; }
        public int ProjectID { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime DateCreated { get; set; }
        public string AssignedTo { get; set; }
        public string Category { get; set; }
        public DateTime DueDate { get; set; }
        public string Milestone { get; set; }
        public decimal Version { get; set; }
        public string Comment { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Priority { get; set; }
    }
}
