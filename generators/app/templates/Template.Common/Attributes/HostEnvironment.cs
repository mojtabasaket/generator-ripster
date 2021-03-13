using Template.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Common.Attributes
{
 
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class HostEnvironmentAttribute : Attribute
    {
 
        private HostEnvironment _environment;

        public HostEnvironmentAttribute(HostEnvironment environment)
        {
            _environment = environment;
        }
        public HostEnvironment getHostEnvironment()
        {
            return _environment;
        }
    }
}
