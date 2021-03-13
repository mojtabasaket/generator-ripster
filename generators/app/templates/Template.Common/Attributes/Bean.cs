using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Common.Attributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
  public  class BeanAttribute : Attribute
    {
        public BeanAttribute()
        {

        }
    }
}
