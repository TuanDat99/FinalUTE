//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobHunt.Model.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class SaveJob
    {
        public int SaveJobId { get; set; }
        public Nullable<int> SJ_CandidateId { get; set; }
        public Nullable<int> SJ_RecruitJobId { get; set; }
        public Nullable<bool> SJStatus { get; set; }
    
        public virtual Candidate Candidate { get; set; }
        public virtual RecruitJob RecruitJob { get; set; }
    }
}
