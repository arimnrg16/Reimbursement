using System;
using System.Collections.Generic;
using System.Text;

namespace Reimburses.ViewModels.QuickLeave
{
    public class QuickLeaveDto
    {
        public QuickLeaveDto()
        {            
        }
        public QuickLeaveDto(Data.Entities.QuickLeave quickLeave)
        {
            DateRequest = quickLeave.date;
            StartTime = quickLeave.startTime;
            FinishTime = quickLeave.finishTime;
            TotalOvertime = quickLeave.totalOvertime;
            Purpose = quickLeave.purpose;
            ProjectName = quickLeave.projectName;
            RequestTo = quickLeave.requestTo;         
    }

        public DateTimeOffset DateRequest { get; }
        public DateTime StartTime { get; }
        public DateTime FinishTime { get; }
        public int TotalOvertime { get; }
        public string Purpose { get; }
        public string ProjectName { get; }
        public string RequestTo { get; }
        public DepartmentDto Department { get; set; }
        public GroupDto Group { get; set; }
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
}
