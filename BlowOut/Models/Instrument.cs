using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    [Table("Instrument")]
    public class Instrument
    {
        [Key]
        [Required]
        [Display(Name = "Instrument ID")]
        public int InstrumentID { get; set; }

        [Required]
        [Display(Name = "Instrument Description")]
        public string InstrumentDesc { get; set; }

        [Required]
        [Display(Name = "Type")]
        public string Type { get; set; }

        [Required]
        [Display(Name = "Instruct Price")]
        public decimal InstrumentPrice { get; set; }

        [Display(Name = "Client ID")]
        public int? ClientID { get; set; }
    }
}