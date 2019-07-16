using Timesheets.Data.Entities;
using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Timesheets.Data.EntityFramework.SqlServer
{
    public class EntityRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Timesheet>(etb => {
                etb.ToTable("Timesheets");
                etb.HasKey(e => e.Id);

                etb.Property(p => p.TimesheetStatus).HasMaxLength(25).IsRequired();

                etb.Property(e => e.Id).ValueGeneratedOnAdd();

                etb.HasMany(m => m.TimesheetTasks).WithOne(w => w.Timesheet).HasForeignKey(f => f.TimesheetId);
            });

            modelbuilder.Entity<TimesheetTask>(etb => {
                etb.ToTable("TimesheetTasks");
                etb.HasKey(e => e.Id);

                etb.Property(p => p.ProjectName).HasMaxLength(64).IsRequired();
                etb.Property(p => p.TaskName).HasMaxLength(64).IsRequired();
                etb.Property(p => p.TaskStatus).HasMaxLength(25).IsRequired();

                etb.Property(e => e.Id).ValueGeneratedOnAdd();
            });
        }
    }
}
