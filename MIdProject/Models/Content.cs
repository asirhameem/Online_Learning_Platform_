//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MIdProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Content
    {
        public int Content_Id { get; set; }
        public int Course_Id { get; set; }
        public string File_Name { get; set; }
        public string File_Path { get; set; }
    
        public virtual Cours Cours { get; set; }
    }
}
