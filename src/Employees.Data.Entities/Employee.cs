using Data.Entities;
using System;
using System.ComponentModel;

namespace Employees.Data.Entities
{
    public class Employee : Entity, ISoftDelete
    {
        public string FirstName { get; set; }

        public int? DocumentID { get; set; }
        public string FileName { get; set; }
        public byte[] Data { get; set; }
        public string ContentType { get; set; }
        public int? ContentLength { get; set; }

        public Employee()
        {
            DocumentID = 0;
            FileName = "New File";
            Data = new byte[] { };
            ContentType = "";
            ContentLength = 0;
        }



        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        public DateTimeOffset? Deleted { get; set; }

        public string DeleteBy { get; set; }
    }
}
