using Data.Entities;
using System;
using System.Collections.Generic;

namespace Timesheets.Data.Entities
{
    public class Timesheet : Entity
    {
        public DateTimeOffset TimesheetDate { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }
        public int TotalHour { get; set; }
        public string TimesheetStatus { get; set; }
        public ICollection<TimesheetTask> TimesheetTasks { get; set; }
    }
}
