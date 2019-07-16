using System;
using System.ComponentModel.DataAnnotations;
using Reimburses.Data.Entities;

namespace Reimburses.ViewModels.RequestOvertime
{
    public class RequestOvertimeCreateViewModel
    {

        public string IdRibursement { get; set; }
        [Display(Name = "Type Reimbursement")]
        [Required()]
        public string TypeReimbursement { get; set; }
        public DateTimeOffset DateOvertime { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset FinishTime { get; set; }
        public DateTimeOffset TotalOvertime { get; set; }
        public string DepartementOrGroup { get; set; }
        public string ProjectName { get; set; }
        public string RequestTo { get; set; }
        public int TransportReimbursement { get; set; }
        public int MealReimbursement { get; set; }
        public int ProofAttcahment { get; set; }

       

        internal Data.Entities.RequestOvertime ToEntity()
        {
            return new Data.Entities.RequestOvertime
            {
                TypeReimbursement = this.TypeReimbursement,
                DateOvertime = this.DateOvertime,
                StartTime = this.StartTime,
                FinishTime = this.FinishTime,
                TotalOvertime = this.TotalOvertime,
                DepartementOrGroup = this.DepartementOrGroup,
                ProjectName = this.ProjectName,
                RequestTo = this.RequestTo,
                TransportReimbursement = this.TransportReimbursement,
                MealReimbursement = this.MealReimbursement,
                ProofAttcahment = this.ProofAttcahment
            };
        }
    }
}
