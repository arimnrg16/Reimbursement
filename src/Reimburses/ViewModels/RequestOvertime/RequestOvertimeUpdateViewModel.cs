using System;
using Reimburses.Data.Entities;

namespace Reimburses.ViewModels.RequestOvertime
{
    public class RequestOvertimeUpdateViewModel
    {
        public RequestOvertimeUpdateViewModel() { }

        private readonly Data.Entities.RequestOvertime _entity;

        public string TypeReimbursement { get; set; }
        public DateTimeOffset DateOvertime { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset FinishTime { get; set; }
        public DateTimeOffset TotalOvertime { get; set; }
        public string DepartementOrGroup { get; set; }
        public string ProjectName { get; set; }
        public string RequestTo { get; set; }
        public int TransportReimbursement { get; set; }
        public int   MealReimbursement { get; set; }
        public int ProofAttcahment { get; set; }

        internal Data.Entities.RequestOvertime ToEntity(Data.Entities.RequestOvertime entity, string username)
        {
        
            entity.TypeReimbursement = this.TypeReimbursement;
            entity.StartTime = this.StartTime;
            entity.FinishTime = this.FinishTime;
            entity.TotalOvertime = this.TotalOvertime;
            entity.DepartementOrGroup = this.DepartementOrGroup;
            entity.ProjectName = this.ProjectName;
            entity.RequestTo = this.RequestTo;
            entity.TransportReimbursement = this.TransportReimbursement;
            entity.MealReimbursement = this.MealReimbursement;
            entity.ProofAttcahment = this.ProofAttcahment;

            entity.Modified = DateTime.Now;
            entity.ModifiedBy = username;

            return entity;
        }
    }
}
