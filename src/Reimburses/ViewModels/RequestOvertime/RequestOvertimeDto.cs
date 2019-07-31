using Reimburses.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reimburses.ViewModels.RequestOvertime
{
    public class RequestOvertimeDto
    {
        public RequestOvertimeDto()
        {

        }
        public RequestOvertimeDto(Data.Entities.RequestOvertime requestOvertime)
        {
            OvertimeType = requestOvertime.overtimeType;
            DateOvertime = requestOvertime.dateOvertime;
            StartTime = requestOvertime.startTime;
            FinishTime = requestOvertime.finishTime;
            TotalOvertime = requestOvertime.totalOvertime;
            DepartmentId = requestOvertime.departmentId;
            GroupId = requestOvertime.groupId;
            ProjectName = requestOvertime.projectName;
            RequestTo = requestOvertime.requestTo;
            TransportReimbursement = requestOvertime.transportReimbursement;
            MealReimbursement = requestOvertime.mealReimbursement;            
        }

        public OvertimeType OvertimeType { get; }
        public DateTimeOffset DateOvertime { get; }
        public DateTime StartTime { get; }
        public DateTime FinishTime { get; }
        public int TotalOvertime { get; }
        public int DepartmentId { get; }
        public int GroupId { get; }
        public string ProjectName { get; }
        public string RequestTo { get; }
        public int TransportReimbursement { get; }
        public int MealReimbursement { get; }
        public GroupDto Group { get; set; }
        public DepartmentDto Department { get; set; }
    }

    public class GroupDto
    {
        public GroupDto()
        {
        }

        public GroupDto(Data.Entities.Group group)
        {
            groupName = group.groupName;
        }

        public string groupName { get; }
    }
    public class DepartmentDto
    {
        public DepartmentDto()
        {
        }

        public DepartmentDto(Data.Entities.Department department)
        {
            departmentName = department.departmentName;
        }
        public string departmentName { get; }
    }

}
