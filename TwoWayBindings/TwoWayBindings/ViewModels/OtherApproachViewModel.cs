using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TwoWayBindings.ViewModels
{
    public class OtherApproachViewModel
    {
        public string FilterParameter { get; set; }
    }


    public class OtherApproachViewModelV : OtherApproachViewModel
    {
        [Required(ErrorMessage = "Invalid input", AllowEmptyStrings = false)]
        [MaxLength(20, ErrorMessage = "Too many characters")]
        [DisplayName("Filter Parameter")]
        public string fp
        {
            get { return this.FilterParameter; }
            set { this.FilterParameter = value; }
        }
    }
}