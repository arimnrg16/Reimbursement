using Data.Entities;
using System;
using System.Collections.Generic;

namespace Reimburses.Data.Entities
{
    public class RequestBusinesstrip : Entity
    {
        public DateTimeOffset DateBusinessTrip { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public decimal TotalCostNominal { get; set; }
        public decimal TotalCostReimburse { get; set; }
        public int ProofAttachment { get; set; }
    }
}
