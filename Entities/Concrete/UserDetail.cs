using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class UserDetail:EntityBase,IEntity
    {
        public DateTime BirthDate { get; set; }
        public string IdentityNumber { get; set; }
        public string Passport { get; set; }
        public int UserId { get; set; }
    }
}
