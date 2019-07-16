using Data.Entities;
using System;
using System.Collections.Generic;

namespace Timesheets.Data.Entities
{
    public class TimesheetTask : Entity
    {
        public string ProjectName { get; set; }
        public string TaskName { get; set; }
        public int OnSprint { get; set; }    
        public string TaskStatus { get; set; }
        public int TimesheetId { get; set; }
        public virtual Timesheet Timesheet { get; set; }
    }
}
