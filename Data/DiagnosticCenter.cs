//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedAide.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class DiagnosticCenter
    {
        public DiagnosticCenter()
        {
            this.Reports = new HashSet<Report>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string contact { get; set; }
        public string working_hour { get; set; }
    
        public virtual ICollection<Report> Reports { get; set; }
    }
}
