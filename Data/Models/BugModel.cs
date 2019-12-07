using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class Bugs
    {
        public int Id { get; set; }
        public int ProjectID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AssignedTo { get; set; }
        public string Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DueDate { get; set; }
        public string Severity { get; set; }
        public string Flag { get; set; }
        public string Comment { get; set; }
        public string Reporter { get; set; }
    }
}
