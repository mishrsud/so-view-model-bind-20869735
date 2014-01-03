using TwoWayBindings.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TwoWayBindings.ViewModels
{
    [ModelBinder(typeof(AliasModelBinder))]
    public class FilterViewModel
    {
        [BindAlias("fp")]
        [Required(ErrorMessage = "Invalid input", AllowEmptyStrings = false)]
        [MaxLength(20, ErrorMessage = "Too many characters")]
        [DisplayName("Filter Parameter")]
        public string FilterParameter { get; set; }
    }
}