//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessLogic.Models
{
    using System;
    using System.Collections.Generic;
    
    public abstract partial class BaseUser
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Disabled { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
