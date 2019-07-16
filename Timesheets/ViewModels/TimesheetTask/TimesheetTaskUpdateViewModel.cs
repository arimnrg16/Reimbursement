using System;
using Timesheets.Data.Entities;

namespace Timesheets.ViewModels.TimesheetTask
{
    public class TimesheetTaskUpdateViewModel
    {
        public TimesheetTaskUpdateViewModel() { }

        private readonly Data.Entities.TimesheetTask _entity;

        public string ProjectName { get; set; }

        internal Data.Entities.TimesheetTask ToEntity(Data.Entities.TimesheetTask entity, string username)
        {
            entity.ProjectName = this.ProjectName;
            entity.Modified = DateTime.Now;
            entity.ModifiedBy = username;

            return entity;
        }
    }
}
