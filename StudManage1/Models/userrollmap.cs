//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudManage1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class userrollmap
    {
        public int id { get; set; }
        public Nullable<int> rid { get; set; }
        public Nullable<int> signupid { get; set; }
    
        public virtual roll roll { get; set; }
        public virtual signup signup { get; set; }
    }
}
