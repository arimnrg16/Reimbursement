using Data.Entities;
using System;
using System.Collections.Generic;

namespace Reimburses.Data.Entities
{
    public class QuickLeave : Entity
    {
        public DateTimeOffset Date { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset FinishTime { get; set; }
        public DateTimeOffset TotalOvertime { get; set; }
        public string Purpose { get; set; }
        public string Department { get; set; }
        public string ProjectName { get; set; }
        public string RequestTo { get; set; }

    }
}
