﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class ProjectSettingsModel
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Owner { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public  string ProjectOverview { get; set; }
    }
}
