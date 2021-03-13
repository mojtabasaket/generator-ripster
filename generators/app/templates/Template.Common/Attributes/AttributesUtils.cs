﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Template.Common.Attributes
{
    static class AttributesUtils
    {



        public static T getAttribute<T>(object type)
        {
           return type.GetType().GetCustomAttributes(typeof(T), false).Select(attr => (T)attr).FirstOrDefault();
        }


        public static bool checkHasAttribute<T>(object type)
        {
           return  type.GetType().GetCustomAttributes(typeof(T),false).Length>0;
        }
    }
}
