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
    
    public partial class CandidatePostResume
    {
        public int CandidatePostResumeId { get; set; }
        public Nullable<int> CPR_CandidateId { get; set; }
        public Nullable<int> CPR_RecruitJobId { get; set; }
        public Nullable<System.DateTime> CPRPostDate { get; set; }
        public Nullable<bool> CPRStatus { get; set; }
        public string CddPhone { get; set; }
        public string CddPathFileCV { get; set; }
    
        public virtual Candidate Candidate { get; set; }
        public virtual RecruitJob RecruitJob { get; set; }
    }
}
