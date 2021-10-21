using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBlog.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }

        //Navigation property to reference this model's children
        public ICollection<BlogPost> BlogPosts = new HashSet<BlogPost>();
    }
}
