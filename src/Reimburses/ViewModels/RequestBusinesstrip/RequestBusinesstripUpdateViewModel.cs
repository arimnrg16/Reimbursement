using System;
using Reimburses.Data.Entities;

namespace Reimburses.ViewModels.RequestBusinesstrip
{
    public class RequestBusinesstripUpdateViewModel
    {
        public RequestBusinesstripUpdateViewModel() { }

        private readonly Data.Entities.RequestBusinesstrip _entity;

        public DateTimeOffset DateBusinessTrip { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int TotalCostNominal { get; set; }
        public int TotalCostReimburse { get; set; }
        public int ProofAttachment { get; set; }

        internal Data.Entities.RequestBusinesstrip ToEntity(Data.Entities.RequestBusinesstrip entity, string username)
        {
            entity.DateBusinessTrip = this.DateBusinessTrip;
            entity.From = this.From;
            entity.To = this.To;
            entity.TotalCostNominal = this.TotalCostNominal;
            entity.TotalCostReimburse = this.TotalCostReimburse;
            entity.ProofAttachment = this.ProofAttachment;
           
            entity.Modified = DateTime.Now;
            entity.ModifiedBy = username;

            return entity;
        }
    }
}
