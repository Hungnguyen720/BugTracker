using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    class ProjectMembersModel
    {
        public int Id { get; set; }
        public int ProjectID { get; set; }
        public List<User> ProjectMembers { get; set; } = new List<User>();

    }
}
