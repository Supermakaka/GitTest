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
    
    public partial class User : BaseUser
    {
        public User()
        {
            this.UserOrders = new HashSet<UserOrder>();
        }
    
        public UserRoles Role { get; set; }
        public int CompanyId { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual ICollection<UserOrder> UserOrders { get; set; }
    }
}