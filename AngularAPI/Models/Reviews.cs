using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularAPI.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int Stars { get; set; }
        public string Author { get; set; }
        public string Body { get; set; }
        public int ProductId { get; set; }
    }
}