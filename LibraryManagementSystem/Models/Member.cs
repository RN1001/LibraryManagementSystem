using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{

    class Member
    {
        public int MemberID { get; set; }
        public string MemFirstname { get; set; }
        public string MemMiddleName { get; set; }
        public string MemLastname { get; set; }
        public DateTime MemDOB { get; set; }
        public string MemAddress { get; set; }
        public string MemSecondAddress { get; set; }
        public string MemPostCode { get; set; }
        public string MemEmail { get; set; }
        public int MemTelephone { get; set; }
        public int MemMobile { get; set; }

        public int MemberTypeID { get; set; }
        public string MemberTypeName { get; set; }
    }
}
