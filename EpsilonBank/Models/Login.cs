using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EpsilonBank.Models
{
    public class Login
    {
        [Display(Name = "Customer ID")]
        public Detail CustID     //fk
        { get; set; }

        [Key]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password
        { get; set; }

        [Display(Name = "Last Login")]
        public DateTime LastLogin
        { get; set; }

        //public virtual ICollection<UserDetails> user { get; set; }


    }
}