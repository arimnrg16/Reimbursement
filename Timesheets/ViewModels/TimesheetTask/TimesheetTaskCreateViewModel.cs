using System;
using System.ComponentModel.DataAnnotations;
using Timesheets.Data.Entities;

namespace Timesheets.ViewModels.TimesheetTask
{
    public class TimesheetTaskCreateViewModel
    {
        [Display(Name = "Project Name")]
        [Required()]
        public string ProjectName { get; set; }

        [Display(Name = "Task Name")]
        [Required()]
        public string TaskName { get; set; }

        internal Data.Entities.TimesheetTask ToEntity()
        {
            return new Data.Entities.TimesheetTask
            {
                ProjectName = this.ProjectName,
                TaskName = this.TaskName
            };
        }
    }
}
