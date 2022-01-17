using System;
using System.Collections.Generic;
using System.Text;

namespace PostNamespace
{
    class Post
    {
        public string Id { get; set; }

        public string Name { get; set; }
        public string Content { get; set; }

        public DateTime CreationDateTime { get; set; }

        public int LikeCount { get; set; }

        public int ViewCount { get; set; }

        public Post(string id, string name, string content, int likeCount, int viewCount)
        {
            Id = id;
            Content = content;
            Name = name;
            CreationDateTime = DateTime.Now;
            LikeCount = likeCount;
            ViewCount = viewCount;
        }

        public void AddLike()
        {
            LikeCount++;
        }

        public void AddView()
        {
            ViewCount++;
        }
    }

    class Notification
    {
        public string Id { get; set; }

        public string Text { get; set; }

        public DateTime DateTime { get; set; }

        public string FromUser { get; set; }


        public Notification(string id, string text, string fromUser)
        {
            Id = id;
            Text = text;
            DateTime = DateTime.Now;
            FromUser = fromUser;
        }
    }
}
