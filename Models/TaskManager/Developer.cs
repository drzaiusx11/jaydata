//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JayData.Models.TaskManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class Developer
    {
        public Developer()
        {
            this.Tasks = new HashSet<Task>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
