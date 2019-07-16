using Data.Entities;
using System;
using System.Collections.Generic;

namespace Reimburses.Data.Entities
{
    public class RequestMedical : Entity
    {
        public DateTimeOffset DateRequestMedical { get; set; }
        public string MedicationType { get; set; }
        public int TotalCostNominal { get; set; }
        public int TotalCostReimburse { get; set; }
        public int ProofAttach { get; set; }
    }
}
