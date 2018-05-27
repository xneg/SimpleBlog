using System;
using System.Collections.Generic;

namespace Models
{
    public class Post
    {
        public string Body { get; set; }

        public IEnumerable<Comment> Comments { get; set; }

        public DateTime CreateDate { get; set; }

        public string Header { get; set; }

        public int PostId { get; set; }

        public IEnumerable<Tag> Tags { get; set; }
    }
}
