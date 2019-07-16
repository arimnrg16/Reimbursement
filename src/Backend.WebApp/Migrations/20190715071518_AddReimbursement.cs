using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.WebApp.Migrations
{
    public partial class AddReimbursement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuickLeaves",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    Modified = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 64, nullable: true),
                    Date = table.Column<DateTimeOffset>(maxLength: 20, nullable: false),
                    StartTime = table.Column<DateTimeOffset>(maxLength: 20, nullable: false),
                    FinishTime = table.Column<DateTimeOffset>(maxLength: 25, nullable: false),
                    TotalOvertime = table.Column<DateTimeOffset>(maxLength: 25, nullable: false),
                    Purpose = table.Column<string>(maxLength: 64, nullable: false),
                    Department = table.Column<string>(maxLength: 64, nullable: false),
                    ProjectName = table.Column<string>(maxLength: 64, nullable: false),
                    RequestTo = table.Column<string>(maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuickLeaves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RequestBusinesstrips",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    Modified = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 64, nullable: true),
                    DateBusinessTrip = table.Column<DateTimeOffset>(maxLength: 25, nullable: false),
                    From = table.Column<string>(maxLength: 64, nullable: false),
                    To = table.Column<string>(maxLength: 64, nullable: false),
                    TotalCostNominal = table.Column<decimal>(maxLength: 10, nullable: false),
                    TotalCostReimburse = table.Column<decimal>(maxLength: 10, nullable: false),
                    ProofAttachment = table.Column<int>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestBusinesstrips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RequestMedicals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    Modified = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 64, nullable: true),
                    DateRequestMedical = table.Column<DateTimeOffset>(nullable: false),
                    MedicationType = table.Column<string>(maxLength: 64, nullable: false),
                    TotalCostNominal = table.Column<int>(maxLength: 10, nullable: false),
                    TotalCostReimburse = table.Column<int>(maxLength: 10, nullable: false),
                    ProofAttach = table.Column<int>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestMedicals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RequestOvertimes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    Modified = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 64, nullable: true),
                    TypeReimbursement = table.Column<string>(maxLength: 64, nullable: false),
                    DateOvertime = table.Column<DateTimeOffset>(maxLength: 25, nullable: false),
                    StartTime = table.Column<DateTimeOffset>(maxLength: 25, nullable: false),
                    FinishTime = table.Column<DateTimeOffset>(maxLength: 25, nullable: false),
                    TotalOvertime = table.Column<DateTimeOffset>(maxLength: 25, nullable: false),
                    DepartementOrGroup = table.Column<string>(maxLength: 64, nullable: false),
                    ProjectName = table.Column<string>(maxLength: 64, nullable: false),
                    RequestTo = table.Column<string>(maxLength: 25, nullable: false),
                    TransportReimbursement = table.Column<int>(maxLength: 10, nullable: false),
                    MealReimbursement = table.Column<int>(maxLength: 10, nullable: false),
                    ProofAttcahment = table.Column<int>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestOvertimes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuickLeaves");

            migrationBuilder.DropTable(
                name: "RequestBusinesstrips");

            migrationBuilder.DropTable(
                name: "RequestMedicals");

            migrationBuilder.DropTable(
                name: "RequestOvertimes");
        }
    }
}
