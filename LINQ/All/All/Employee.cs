//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace All
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public Nullable<int> Age { get; set; }
        public string EmpName { get; set; }
        public int CompID { get; set; }
        public int EmpID { get; set; }
    
        public virtual Computer Computer { get; set; }
    }
}
