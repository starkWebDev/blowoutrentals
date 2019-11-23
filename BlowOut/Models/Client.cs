using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    [Table("Clients")]
    public class Client
    {
        [Key]
        [Required]
        [Display(Name = "Client ID")]
        public int ClientID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string Client_FirstName { get; set; }


        [Required]
        [Display(Name = "Last Name")]
        public string Client_LastName { get; set; }

        [Required]
        [Display(Name = "Street Address")]
        public string Client_StreetAddress { get; set; }

        [Required]
        [Display(Name = "City")]
        public string Client_City { get; set; }


        [Required]
        [Display(Name = "Zip Code")]
        public string Client_Zipcode { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Client_Email { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string Client_Phone { get; set; }
    }
}