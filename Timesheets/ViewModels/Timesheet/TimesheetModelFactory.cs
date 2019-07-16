using System;
using Timesheets.Data.Abstractions;
using ExtCore.Data.Abstractions;

namespace Timesheets.ViewModels.Timesheet
{
    internal class TimesheetModelFactory
    {
        public TimesheetModelFactory()
        {
        }

        internal TimesheetIndexViewModel LoadAll(IStorage storage, int page, int size)
        {
            var timesheetRepo = storage.GetRepository<ITimesheetRepository>();

            return new TimesheetIndexViewModel(timesheetRepo.All(page, size));
        }
    }
}

