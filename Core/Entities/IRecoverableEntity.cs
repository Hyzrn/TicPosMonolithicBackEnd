using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public interface IRecoverableEntity
    {
        public bool IsDeleted { get; set; }
    }
}
