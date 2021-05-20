using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public  int Id { get; set; }
        
        [Required(ErrorMessage = "Please enter customer's name.")] // overide content of the error message
        [StringLength(225)]
        public string  Name { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
        
        
        public bool IsSubscribedToNewsletter { get; set; }
       
        public MembershipType MembershipType { get; set; } 
        //navigation property - from customer to membership type
    
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; } // foreign key
        // The Error message on Customerform Page: 
        // byte is nullable data type
        // The string added of the top of membership type list "Select Memberhship Type" is signed with no value as an empty string which cannot be translated into a byte

    }
}