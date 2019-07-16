using System.Collections.Generic;
using Timesheets.Data.Entities;

namespace Timesheets.ViewModels.TimesheetTask
{
    class TimesheetTaskIndexViewModel
    {
        public TimesheetTaskIndexViewModel(IEnumerable<Data.Entities.TimesheetTask> data)
        {
            TimesheetTasks = data ?? new List<Data.Entities.TimesheetTask>();
        }

        public IEnumerable<Data.Entities.TimesheetTask> TimesheetTasks { get; }
    }
}
