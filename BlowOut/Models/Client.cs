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

        [Required(ErrorMessage = "Please enter first name.")]
        [Display(Name = "First Name")]
        public string Client_FirstName { get; set; }


        [Required(ErrorMessage = "Please enter last name.")]
        [Display(Name = "Last Name")]
        public string Client_LastName { get; set; }

        [Required(ErrorMessage = "Please enter address.")]
        [Display(Name = "Street Address")]
        public string Client_StreetAddress { get; set; }

        [Required(ErrorMessage = "Please enter city.")]
        [Display(Name = "City")]
        public string Client_City { get; set; }

        [Required(ErrorMessage = "Please enter state.")]
        [Display(Name = "State")]
        public string Client_State { get; set; }

        [Required(ErrorMessage = "Please enter zipcode.")]
        [Display(Name = "Zip Code")]
        public string Client_Zipcode { get; set; }

        [Required(ErrorMessage = "Please enter email.")]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Client_Email { get; set; }

        [Required(ErrorMessage = "Please enter phone number.")]
        [Display(Name = "Phone Number")]
        [Phone]
        [RegularExpression(@"^\D?(\d{3})\D?\D?(\d{3})\D?(\d{4})$", ErrorMessage = "Must be a 9-digit number.")]
        public string Client_Phone { get; set; }
    }
}