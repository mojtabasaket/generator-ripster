using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Core.Services.DTOs.Clients
{
    public class ErrorClientDTO
    {
        public string type { get; set; }
        public string title { get; set; }
        public string errorcode { get; set; }
        public int status { get; set; }
        public object detail { get; set; }
        public object instance { get; set; }

}
}
