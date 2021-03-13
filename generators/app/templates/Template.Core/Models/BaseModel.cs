using System;

namespace Template.Core.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int CreatorUserId { get; set; }

    }
}
