using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class AddPostDto
    {
        public int UserId { get; set; }
        public int ActivityId { get; set; }
        public string Code { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; } = 1;
        public string Description { get; set; }
        public string Title { get; set; }
    }
}
