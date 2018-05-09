using System;

namespace Models
{
    public class Post
    {
        public string Body { get; set; }

        public Comment[] Comments { get; set; }

        public DateTime CreateDate { get; set; }

        public string Header { get; set; }

        public int PostId { get; set; }

        public Tag[] Tags { get; set; }
    }
}
