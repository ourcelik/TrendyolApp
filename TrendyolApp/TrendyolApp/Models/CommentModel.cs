using System;
using System.Collections.Generic;
using System.Text;

namespace TrendyolApp.Models
{
    public class CommentModel
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public int UserId { get; set; }
    }
}
