using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBlog.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public string Title { get; set; }
        // Abstract property is a short description for the blog post
        public string Abstract { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }

        public DateTime? Updated { get; set; }

        //Navigational properties 
        public virtual Blog Blog { get; set; }

    }
}
