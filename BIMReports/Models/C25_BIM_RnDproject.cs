//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BIMReports.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class C25_BIM_RnDproject
    {
        public int ID { get; set; }
        public int MemberID { get; set; }
        public string MainMember { get; set; }
        public string RnD_Code { get; set; }
        public string Relate_member { get; set; }
        public string RnD_Year { get; set; }
        public string RnD_subject { get; set; }
        public string Subject_description { get; set; }
        public string Subject_Target { get; set; }
        public string Subject_group { get; set; }
        public Nullable<System.DateTime> Schedule_Start_date { get; set; }
        public Nullable<System.DateTime> Schedule_Deadline_date { get; set; }
        public Nullable<System.DateTime> Actual_Deadline { get; set; }
        public Nullable<double> Current_percent_process { get; set; }
        public string Status { get; set; }
        public string Link { get; set; }
        public string Report { get; set; }
        public string Note { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    
        public virtual C02_BIMstaff C02_BIMstaff { get; set; }
    }
}
