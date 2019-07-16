using System;
using Reimburses.Data.Entities;

namespace Reimburses.ViewModels.QuickLeave
{
    public class QuickLeaveUpdateViewModel
    {
        public QuickLeaveUpdateViewModel() { }

        private readonly Data.Entities.QuickLeave _entity;

      
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public DateTime TotalOvertime { get; set; }
        public string Purpose { get; set; }
        public string Department { get; set; }
        public string ProjectName { get; set; }
        public string RequestTo { get; set; }

        internal Data.Entities.QuickLeave ToEntity(Data.Entities.QuickLeave entity, string username)
        {
            entity.Date = this.Date;
            entity.StartTime = this.StartTime;
            entity.FinishTime = this.FinishTime;
            entity.TotalOvertime = this.TotalOvertime;
            entity.Purpose = this.Purpose;
            entity.Department = this.Department;
            entity.ProjectName = this.ProjectName;
            entity.RequestTo = this.RequestTo;
            entity.Modified = DateTime.Now;
            entity.ModifiedBy = username;

            return entity;
        }
    }
}
