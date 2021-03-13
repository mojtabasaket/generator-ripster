using Template.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Common.Attributes
{
    [AttributeUsage(AttributeTargets.Class , AllowMultiple = false)]
   public class ScopeAttribute : Attribute
    {
        private ServiceLifetime _serviceLifetime;

        public ScopeAttribute(ServiceLifetime serviceLifetime)
        {
            _serviceLifetime = serviceLifetime;
        }


        public ServiceLifetime getServiceLifetime()
        {
            return _serviceLifetime;
        }
    }
}
