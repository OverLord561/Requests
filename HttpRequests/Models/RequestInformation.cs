using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HttpRequests.Models
{
    public class RequestInformation
    {
        public int RequestInformationId { get; set; }

        [Display(Name = "Type")]
        public string RequestInformationType { get; set; }
        [Display(Name = "Ip")]
        public string RequestInformationIp { get; set; }
        [Display(Name = "Url")]
        public string RequestInformationUrl { get; set; }
    }
}