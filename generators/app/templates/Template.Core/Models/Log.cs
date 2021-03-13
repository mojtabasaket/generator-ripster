using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Core.Models
{
    public class Log : BaseModel
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public int TenantID { get; set; }
        public int ApplicationId { get; set; }
        public string Host { get; set; }
        public string QueryString { get; set; }
        public string Path { get; set; }
        public string RequestBody { get; set; }
        public string ResponseBody { get; set; }
        public  int StatusCode { get; set; }
        public string IP { get; set; }
 
    }
}
