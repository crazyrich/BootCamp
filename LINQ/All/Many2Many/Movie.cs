//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Many2Many
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movie
    {
        public Movie()
        {
            this.Actors = new HashSet<Actor>();
        }
    
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public string MovieDirector { get; set; }
    
        public virtual ICollection<Actor> Actors { get; set; }
    }
}
