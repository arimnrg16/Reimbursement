using System;
using Timesheets.Data.Abstractions;
using ExtCore.Data.Abstractions;

namespace Timesheets.ViewModels.TimesheetTask
{
    class TimesheetTaskModelFactory
    {
        public TimesheetTaskModelFactory()
        {
        }

        internal TimesheetTaskIndexViewModel LoadAll(IStorage storage, int page, int size)
        {
            var timesheetTaskRepo = storage.GetRepository<ITimesheetTaskRepository>();

            return new TimesheetTaskIndexViewModel(timesheetTaskRepo.All(page, size));
        }
    }
}
