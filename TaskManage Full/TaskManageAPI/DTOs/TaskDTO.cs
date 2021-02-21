using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManageAPI.DTOs
{
    public class TaskDTO
    {
        public int IdTask { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public int IdProject { get; set; }
        public int IdTaskType { get; set; }
        public int IdAssignedTo { get; set; }
        public int IdCreator { get; set; }
        public string ProjectName { get; set; }
        public string LastNameOfTaskCreator { get; set; }
        public string LastNameOfTaskAssignee { get; set; }
        public string TaskType { get; set; }
    }
}
