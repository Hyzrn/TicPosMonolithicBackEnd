using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Post:EntityBase, IEntity
    {
        public int UserId { get; set; }
        public int ActivityId { get; set; }
        public string Code { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
    }
}
