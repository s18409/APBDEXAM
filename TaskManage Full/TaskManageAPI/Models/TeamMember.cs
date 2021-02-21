using System;
using System.Collections.Generic;

#nullable disable

namespace TaskManageAPI.Models
{
    public partial class TeamMember
    {
        public TeamMember()
        {
            TaskIdAssignedToNavigations = new HashSet<Task>();
            TaskIdCreatorNavigations = new HashSet<Task>();
        }

        public int IdTeamMember { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Task> TaskIdAssignedToNavigations { get; set; }
        public virtual ICollection<Task> TaskIdCreatorNavigations { get; set; }
    }
}
