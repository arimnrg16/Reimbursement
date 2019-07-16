using Reimburses.Data.Entities;
using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reimburses.Data.EntityFramework.SqlServer
{
    public class EntityRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<RequestOvertime>(etb => {
                etb.ToTable("RequestOvertimes");
                etb.HasKey(e => e.Id);

                etb.Property(p => p.TypeReimbursement).HasMaxLength(64).IsRequired();
                etb.Property(p => p.DateOvertime).HasMaxLength(25).IsRequired();
                etb.Property(p => p.StartTime).HasMaxLength(25).IsRequired();
                etb.Property(p => p.FinishTime).HasMaxLength(25).IsRequired();
                etb.Property(p => p.TotalOvertime).HasMaxLength(25).IsRequired();
                etb.Property(p => p.DepartementOrGroup).HasMaxLength(64).IsRequired();
                etb.Property(p => p.ProjectName).HasMaxLength(64).IsRequired();
                etb.Property(p => p.RequestTo).HasMaxLength(25).IsRequired();
                etb.Property(p => p.TransportReimbursement).HasMaxLength(10).IsRequired();
                etb.Property(p => p.MealReimbursement).HasMaxLength(10).IsRequired();
                etb.Property(p => p.ProofAttcahment).HasMaxLength(25).IsRequired();
                               
                etb.Property(e => e.Id).ValueGeneratedOnAdd();

               
            });

            modelbuilder.Entity<RequestMedical>(etb => {
                etb.ToTable("RequestMedicals");
                etb.HasKey(e => e.Id);

                //etb.Property(p => p.DateRequestMedical).HasMaxLength(25).IsRequired();
                etb.Property(p => p.MedicationType).HasMaxLength(64).IsRequired();
                etb.Property(p => p.TotalCostNominal).HasMaxLength(10).IsRequired();
                etb.Property(p => p.TotalCostReimburse).HasMaxLength(10).IsRequired();
                etb.Property(p => p.ProofAttach).HasMaxLength(25).IsRequired();

                etb.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelbuilder.Entity<RequestBusinesstrip>(etb => {
                etb.ToTable("RequestBusinesstrips");
                etb.HasKey(e => e.Id);
                etb.Property(p => p.DateBusinessTrip).HasMaxLength(25).IsRequired();
                etb.Property(p => p.From).HasMaxLength(64).IsRequired();
                etb.Property(p => p.To).HasMaxLength(64).IsRequired();
                etb.Property(p => p.TotalCostNominal).HasMaxLength(10).IsRequired();
                etb.Property(p => p.TotalCostReimburse).HasMaxLength(10).IsRequired();
                etb.Property(p => p.ProofAttachment).HasMaxLength(25).IsRequired();

                etb.Property(e => e.Id).ValueGeneratedOnAdd();
            });
            modelbuilder.Entity<QuickLeave>(etb => {
                etb.ToTable("QuickLeaves");
                etb.HasKey(e => e.Id);

                etb.Property(p => p.Date).HasMaxLength(20).IsRequired();
                etb.Property(p => p.StartTime).HasMaxLength(20).IsRequired();
                etb.Property(p => p.FinishTime).HasMaxLength(25).IsRequired();
                etb.Property(p => p.TotalOvertime).HasMaxLength(25).IsRequired();
                etb.Property(p => p.Purpose).HasMaxLength(64).IsRequired();
                etb.Property(p => p.Department).HasMaxLength(64).IsRequired();
                etb.Property(p => p.ProjectName).HasMaxLength(64).IsRequired();
                etb.Property(p => p.RequestTo).HasMaxLength(64).IsRequired();
 

                etb.Property(e => e.Id).ValueGeneratedOnAdd();
            });

        }
    }
}