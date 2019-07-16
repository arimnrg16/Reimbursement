using System;
using Timesheets.Data.Entities;

namespace Timesheets.ViewModels.Timesheet
{
    public class TimesheetUpdateViewModel
    {
        public TimesheetUpdateViewModel() { }

        private readonly Data.Entities.Timesheet _entity;

        public string TimesheetStatus { get; set; }

        internal Data.Entities.Timesheet ToEntity(Data.Entities.Timesheet entity, string username)
        {
            entity.TimesheetStatus = this.TimesheetStatus;
            entity.Modified = DateTime.Now;
            entity.ModifiedBy = username;

            return entity;
        }
    }
}
