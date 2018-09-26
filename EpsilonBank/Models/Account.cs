using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EpsilonBank.Models
{
    public class Account
    {

        [Key]
        [Display(Name = "Account Number")]   //pk
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long AccNo
        { get; set; }

        [Display(Name = "Customer ID")]
        public Detail CustID           //fk
        { get; set; }


        //[Display(Name = "Account ID")]

        //public long AccountID  //pk

        //{ get; set; }


        [Display(Name = "Available Balance")]
        public float Balance

        { get; set; }


        [Display(Name = "Account status")]
        public Status Status
        { get; set; }

        //public virtual ICollection<UserDetails> user { get; set; }
        public virtual ICollection<Transaction> transaction { get; set; }



    }

    public enum Status
    {
        ACTIVE,
        INACTIVE
    }
}