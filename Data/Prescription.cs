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
    
    public partial class Prescription
    {
        public int id { get; set; }
        public int doc_id { get; set; }
        public int patient_id { get; set; }
        public System.DateTime date_time { get; set; }
        public byte[] data { get; set; }
        public string datatype { get; set; }
        public string dataname { get; set; }
    
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
