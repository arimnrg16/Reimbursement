using Data.Entities;
using System;
using System.Collections.Generic;

namespace Reimburses.Data.Entities
{
    public class RequestOvertime : Entity
    {
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
    }
}
