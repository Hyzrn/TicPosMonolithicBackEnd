using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class UpdatePostDto
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public string Code { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
    }
}
