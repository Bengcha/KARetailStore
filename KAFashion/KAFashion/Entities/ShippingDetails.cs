using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KAFashion.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Please enter a First Name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter a Last Name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter a street")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Please enter a city name")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter a state name")]
        public string State { get; set; }
        [Required(ErrorMessage = "Please enter a zipcode")]
        public string Zip { get; set; }
        [Display(Name = "Phone Number: optional")]
        public string PhoneNumber { get; set; }
        public bool GiftWrap { get; set; }
    }
}