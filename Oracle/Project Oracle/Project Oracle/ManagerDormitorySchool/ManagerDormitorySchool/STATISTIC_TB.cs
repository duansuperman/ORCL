//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManagerDormitorySchool
{
    using System;
    using System.Collections.Generic;
    
    public partial class STATISTIC_TB
    {
        public decimal STA_ID { get; set; }
        public System.DateTime MONTH { get; set; }
        public string STUDENT { get; set; }
    
        public virtual STUDENT_TB STUDENT_TB { get; set; }
    }
}