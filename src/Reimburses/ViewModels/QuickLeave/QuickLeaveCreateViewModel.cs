using System;
using System.ComponentModel.DataAnnotations;
using Reimburses.Data.Entities;

namespace Reimburses.ViewModels.QuickLeave
{
    public class QuickLeaveCreateViewModel
    {
       
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public DateTime TotalOvertime { get; set; }
        public string Purpose { get; set; }
        public string Department { get; set; }
        public string ProjectName { get; set; }
        public string RequestTo { get; set; }

        internal Data.Entities.QuickLeave ToEntity()
        {
            return new Data.Entities.QuickLeave
            {
                Date = this.Date,
                StartTime = this.StartTime,
                FinishTime = this.FinishTime,
                TotalOvertime = this.TotalOvertime,
                Purpose = this.Purpose,
                Department = this.Department,
                ProjectName = this.ProjectName,
                RequestTo = this.RequestTo
            };
        }
    }
}
