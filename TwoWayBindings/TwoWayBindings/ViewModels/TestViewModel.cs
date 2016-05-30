using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TwoWayBindings.Helpers;

namespace TwoWayBindings.ViewModels
{
    [System.Web.Mvc.ModelBinder(typeof(AliasModelBinder))]
    public class TestViewModel
    {
        [BindAlias("request_id")]
        public string RequestId { get; set; }

        [BindAlias("something_else")]
        public string SomethingElse { get; set; }
    }
}