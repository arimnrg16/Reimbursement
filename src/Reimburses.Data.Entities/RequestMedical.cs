﻿using Data.Entities;
using System;
using System.Collections.Generic;

namespace Reimburses.Data.Entities
{
    public class RequestMedical : Entity
    {
        public DateTimeOffset dateRequestMedical { get; set; }
        public string medicationType { get; set; }
        public int totalCostNominal { get; set; }
        public int totalCostReimburse { get; set; }
        public string ImageUrl { get; set; }
        public int EmployeeId { get; set; }
        
        //public IFormFile Image { get; set; }


        //total reimburse
        public void GetTotalReimburseTaken()
        {
            totalCostReimburse = 8%100 * totalCostNominal;
        }

        //approval
        public virtual ICollection<RequestMedicalApprovalHistory> ApprovalHistory { get; set; }
        public bool HumanResourceDeptApproved(int hrStaffEmployeeId, string currentUsername)
        {
            this.ApprovalHistory.Add(new RequestMedicalApprovalHistory
            {
                ApprovalDate = DateTime.Now,
                ApprovalStatusRequestMedical = ApprovalStatusRequestMedical.ApprovedByHR,
                RequestMedical = this,
                EmployeeId = hrStaffEmployeeId,
                Created = DateTime.Now,
                CreatedBy = currentUsername
            });
            return true;
        }
        public bool HumanResourceDeptRejected(int hrStaffEmployeeId, string currentUsername)
        {
            this.ApprovalHistory.Add(new RequestMedicalApprovalHistory
            {
                ApprovalDate = DateTime.Now,
                ApprovalStatusRequestMedical = ApprovalStatusRequestMedical.RejectedbyHR,
                RequestMedical = this,
                EmployeeId = hrStaffEmployeeId,
                Created = DateTime.Now,
                CreatedBy = currentUsername
            });
            return true;
        }

        public bool ScrumMasterApproved(int scrumMasterEmployeeId, string currentUsername)
        {
            this.ApprovalHistory.Add(new RequestMedicalApprovalHistory
            {
                ApprovalDate = DateTime.Now,
                ApprovalStatusRequestMedical = ApprovalStatusRequestMedical.ApprovedBySM,
                RequestMedical = this,
                EmployeeId = scrumMasterEmployeeId,
                Created = DateTime.Now,
                CreatedBy = currentUsername
            });
            return true;
        }

        public bool ScrumMasterRejected(int scrumMasterEmployeeId, string currentUsername)
        {
            this.ApprovalHistory.Add(new RequestMedicalApprovalHistory
            {
                ApprovalDate = DateTime.Now,
                ApprovalStatusRequestMedical = ApprovalStatusRequestMedical.RejectedBySM,
                RequestMedical = this,
                EmployeeId = scrumMasterEmployeeId,
                Created = DateTime.Now,
                CreatedBy = currentUsername
            });
            return true;
        }
    }
    public enum ApprovalStatusRequestMedical
    {
        Draft = 10,

        ApprovedBySM = 20,
        ApprovedByHR,

        RejectedBySM = 30,
        RejectedbyHR
    }


}