﻿// <auto-generated />
using System;
using ExtCore.Data.EntityFramework.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Backend.WebApp.Migrations
{
    [DbContext(typeof(StorageContext))]
    partial class StorageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Employees.Data.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("DeleteBy");

                    b.Property<DateTimeOffset?>("Deleted");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTimeOffset?>("Modified");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Reimburses.Data.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("DeleteBy");

                    b.Property<DateTimeOffset?>("Deleted");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTimeOffset?>("Modified");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<string>("departmentName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Reimburses.Data.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("DeleteBy");

                    b.Property<DateTimeOffset?>("Deleted");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTimeOffset?>("Modified");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<string>("groupName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Reimburses.Data.Entities.QuickLeave", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("EmployeId");

                    b.Property<DateTimeOffset?>("Modified");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<DateTimeOffset>("date");

                    b.Property<int>("departmentId")
                        .HasMaxLength(64);

                    b.Property<DateTime>("finishTime");

                    b.Property<int>("groupId");

                    b.Property<string>("note")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("projectName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("purpose")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("requestTo")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<DateTime>("startTime");

                    b.Property<int>("totalOvertime");

                    b.HasKey("Id");

                    b.HasIndex("departmentId");

                    b.HasIndex("groupId");

                    b.ToTable("QuickLeaves");
                });

            modelBuilder.Entity("Reimburses.Data.Entities.QuickLeaveApprovalHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("ApprovalDate");

                    b.Property<int>("ApprovalStatusQuickLeave");

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("EmployeeId");

                    b.Property<DateTimeOffset?>("Modified");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<int?>("QuickLeaveId");

                    b.HasKey("Id");

                    b.HasIndex("QuickLeaveId");

                    b.ToTable("QuickLeaveApprovalHistory");
                });

            modelBuilder.Entity("Reimburses.Data.Entities.RequestBusinesstrip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("EmployeeId");

                    b.Property<string>("ImageUrl");

                    b.Property<DateTimeOffset?>("Modified");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<DateTimeOffset>("dateBusinessTrip");

                    b.Property<string>("from")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("to")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("totalCostNominal");

                    b.Property<int>("totalCostReimburse");

                    b.HasKey("Id");

                    b.ToTable("RequestBusinesstrips");
                });

            modelBuilder.Entity("Reimburses.Data.Entities.RequestBusinesstripApprovalHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("ApprovalDate");

                    b.Property<int>("ApprovalStatusRequestBusinesstrip");

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("EmployeeId");

                    b.Property<DateTimeOffset?>("Modified");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<int?>("RequestBusinesstripId");

                    b.HasKey("Id");

                    b.HasIndex("RequestBusinesstripId");

                    b.ToTable("RequestBusinesstripApprovalHistory");
                });

            modelBuilder.Entity("Reimburses.Data.Entities.RequestMedical", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("EmployeeId");

                    b.Property<string>("ImageUrl");

                    b.Property<DateTimeOffset?>("Modified");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<DateTimeOffset>("dateRequestMedical");

                    b.Property<string>("medicationType")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("totalCostNominal");

                    b.Property<int>("totalCostReimburse");

                    b.HasKey("Id");

                    b.ToTable("RequestMedicals");
                });

            modelBuilder.Entity("Reimburses.Data.Entities.RequestMedicalApprovalHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("ApprovalDate");

                    b.Property<int>("ApprovalStatusRequestMedical");

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("EmployeeId");

                    b.Property<DateTimeOffset?>("Modified");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<int?>("RequestMedicalId");

                    b.HasKey("Id");

                    b.HasIndex("RequestMedicalId");

                    b.ToTable("RequestMedicalApprovalHistory");
                });

            modelBuilder.Entity("Reimburses.Data.Entities.RequestOvertime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("EmployeeId");

                    b.Property<string>("ImageUrl");

                    b.Property<DateTimeOffset?>("Modified");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<DateTimeOffset>("dateOvertime");

                    b.Property<int>("departmentId");

                    b.Property<DateTime>("finishTime");

                    b.Property<int>("groupId");

                    b.Property<int>("mealReimbursement");

                    b.Property<int>("overtimeType")
                        .HasMaxLength(64);

                    b.Property<string>("projectName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("requestTo")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<DateTime>("startTime");

                    b.Property<int>("totalOvertime");

                    b.Property<int>("transportReimbursement");

                    b.HasKey("Id");

                    b.HasIndex("departmentId");

                    b.HasIndex("groupId");

                    b.ToTable("RequestOvertimes");
                });

            modelBuilder.Entity("Reimburses.Data.Entities.RequestOvertimeApprovalHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("ApprovalDate");

                    b.Property<int>("ApprovalStatusRequestOvertime");

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("EmployeeId");

                    b.Property<DateTimeOffset?>("Modified");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<int?>("RequestOvertimeId");

                    b.HasKey("Id");

                    b.HasIndex("RequestOvertimeId");

                    b.ToTable("RequestOvertimeApprovalHistory");
                });

            modelBuilder.Entity("Reimburses.Data.Entities.QuickLeave", b =>
                {
                    b.HasOne("Reimburses.Data.Entities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("departmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Reimburses.Data.Entities.Group", "Group")
                        .WithMany()
                        .HasForeignKey("groupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Reimburses.Data.Entities.QuickLeaveApprovalHistory", b =>
                {
                    b.HasOne("Reimburses.Data.Entities.QuickLeave", "QuickLeave")
                        .WithMany("ApprovalHistory")
                        .HasForeignKey("QuickLeaveId");
                });

            modelBuilder.Entity("Reimburses.Data.Entities.RequestBusinesstripApprovalHistory", b =>
                {
                    b.HasOne("Reimburses.Data.Entities.RequestBusinesstrip", "RequestBusinesstrip")
                        .WithMany("ApprovalHistory")
                        .HasForeignKey("RequestBusinesstripId");
                });

            modelBuilder.Entity("Reimburses.Data.Entities.RequestMedicalApprovalHistory", b =>
                {
                    b.HasOne("Reimburses.Data.Entities.RequestMedical", "RequestMedical")
                        .WithMany("ApprovalHistory")
                        .HasForeignKey("RequestMedicalId");
                });

            modelBuilder.Entity("Reimburses.Data.Entities.RequestOvertime", b =>
                {
                    b.HasOne("Reimburses.Data.Entities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("departmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Reimburses.Data.Entities.Group", "Group")
                        .WithMany()
                        .HasForeignKey("groupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Reimburses.Data.Entities.RequestOvertimeApprovalHistory", b =>
                {
                    b.HasOne("Reimburses.Data.Entities.RequestOvertime", "RequestOvertime")
                        .WithMany("ApprovalHistory")
                        .HasForeignKey("RequestOvertimeId");
                });
#pragma warning restore 612, 618
        }
    }
}
