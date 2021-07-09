using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Content
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Comment { get; set; }

        public int Status { get; set; }

        public DateTime CreateOn { get; set; }

        public DateTime ModifyOn { get; set; }
    }
}
