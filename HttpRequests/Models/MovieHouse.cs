using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HttpRequests.Models
{
    public class MovieHouse
    {
        public int MovieHouseId { get; set; }
        

        [Required(ErrorMessage = "Enter name...")]
        [Display(Name = "Movie House Name")]
        public string MovieHouseName { get; set; }

        [Required(ErrorMessage = "Enter telephone number...")]
        [Display(Name = "Telephone number")]
        
        public string MovieHouseTelephone { get; set; }

        [Required(ErrorMessage = "Enter adress...")]
        [Display(Name = "Adress")]
        public string MovieHouseAdress { get; set; }
    }
}