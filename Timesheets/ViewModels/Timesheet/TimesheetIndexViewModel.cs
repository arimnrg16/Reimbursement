using System.Collections.Generic;
using Timesheets.Data.Entities;

namespace Timesheets.ViewModels.Timesheet
{
    public class TimesheetIndexViewModel
    {
        public TimesheetIndexViewModel(IEnumerable<Data.Entities.Timesheet> data)
        {
            Timesheets = data ?? new List<Data.Entities.Timesheet>();
        }

        public IEnumerable<Data.Entities.Timesheet> Timesheets { get; }
    }
}