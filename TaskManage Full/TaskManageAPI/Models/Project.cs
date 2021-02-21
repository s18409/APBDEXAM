using System;
using System.Collections.Generic;

#nullable disable

namespace TaskManageAPI.Models
{
    public partial class Project
    {
        public Project()
        {
            Tasks = new HashSet<Task>();
        }

        public int IdProject { get; set; }
        public string Name { get; set; }
        public DateTime Deadline { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
