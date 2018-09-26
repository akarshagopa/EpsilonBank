using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EpsilonBank.Models
{
    public class Detail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Customer ID")]
        public long CustID  //pk
        { get; set; }

        [Display(Name = "Name")]
        [Required]
        public string Name
        { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email
        { get; set; }

        [Display(Name = "Phone Number")]
        public string PhNo
        { get; set; }

        //[Display(Name = "Age")]
        //public byte Age
        //{ get; set; }

        [Display(Name = "Gender")]
        public string Gender
        { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DOB
        { get; set; }

        [Display(Name = "Address")]
        public string Address
        { get; set; }

        [Display(Name = "User Type")]
        public UserType UserType      //enum
        { get; set; }

        

        //public virtual ICollection<Login> login { get; set; }

    }
    public enum UserType
    {
        ADMIN,
        CUSTOMER
       }

    
}