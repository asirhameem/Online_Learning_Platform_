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
    
    public partial class Video
    {
        public int V_Id { get; set; }
        public int Course_Id { get; set; }
        public string Video_Name { get; set; }
        public string Video_Description { get; set; }
        public string Video_Path { get; set; }
    
        public virtual Cours Cours { get; set; }
    }
}
