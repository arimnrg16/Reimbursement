using System;
using System.ComponentModel.DataAnnotations;
using Timesheets.Data.Entities;

namespace Timesheets.ViewModels.Timesheet
{
    public class TimesheetCreateViewModel
    {
        [Display(Name = "Timesheet Status")]
        [Required()]
        public string TimesheetStatus { get; set; }

        internal Data.Entities.Timesheet ToEntity()
        {
            return new Data.Entities.Timesheet
            {
                TimesheetStatus = this.TimesheetStatus
            };
        }
    }
}
