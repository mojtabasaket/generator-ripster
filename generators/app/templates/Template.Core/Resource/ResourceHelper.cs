using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Core.Resource
{
 
    public static class ResourceHelper
    {

        public static string CurrentCulture { get; set; }
        public static IStringLocalizer<Template.Core.Resources.Resource> _localizer { get; set; }


        public static string getWithCulture(string Key)
        {
            return _localizer.WithCulture(new System.Globalization.CultureInfo(CurrentCulture))[Key];
        }
    }
}
