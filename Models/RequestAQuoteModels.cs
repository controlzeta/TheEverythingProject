﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TheEverythingProject.Models
{
    public class RequestAQuoteModels
    {
        [Required]
        [DisplayName("Tipo de Proyecto")]
        public string ProjectType { get; set; }
        [Required]
        [DataType(DataType.PostalCode)]
        [RegularExpression(@"^\d{5}$|^\d{5}-\d{4}$", ErrorMessage = "The postal code should be in the format 00000 or 00000-0000")]
        [DisplayName("Postal Code")]
        public string ZipCode { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [DisplayName("Contact Name")]
        public string ContactName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber, ErrorMessage = "Please provide the phone number area code first in the format (000) 000-0000")]
        [DisplayName("Daytime Phone Number")]
        public string DayTimePhone { get; set; }
        [Required]
        [DisplayName("Project Description")]
        [StringLength(5000, MinimumLength = 10)]
        [DataType(DataType.MultilineText)]
        public string ProjectDescription { get; set; }
    
    }
}