using PostNamespace;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminNamespace
{

    class Admin
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool newNotif = false;

        private Post[] posts = new Post[] { };
        private Notification[] notifications = new Notification[] { };

        public Post[] Posts
        {
            get { return posts; }
            set { posts = value; }
        }

        public Notification[] Notifications
        {
            get { return notifications; }
            set { notifications = value; }
        }

        public Admin()
        {

        }

        public Admin(string id, string username, string email, string password, Post[] posts, Notification[] notifications)
        {
            Id = id;
            Username = username;
            Email = email;
            Password = password;
            Posts = posts;
            Notifications = notifications;
        }

        public void AddNotification(Notification notification)
        {
            Notification[] temp = new Notification[notifications.Length + 1];
            for (int i = 0; i < notifications.Length; i++)
            {
                temp[i] = notifications[i];
            }
            temp[notifications.Length] = notification;
            Notifications = temp;
            newNotif = true;
        }

        public void AddPost(Post post)
        {
            Post[] temp = new Post[posts.Length + 1];
            for (int i = 0; i < posts.Length; i++)
            {
                temp[i] = posts[i];
            }
            temp[posts.Length] = post;
            Posts = temp;
        }

        public void ShowNotif()
        {
            for (int i = 0; i < notifications.Length; i++)
            {
                Console.WriteLine($"Id: {notifications[i].Id}\nText: {notifications[i].Text}\nDateTime: {notifications[i].DateTime}\nFromUser: {notifications[i].FromUser}");
            }
            newNotif = false;
        }

        public void ShowPosts()
        {
            for (int i = 0; i < Posts.Length; i++)
            {
                Console.WriteLine($"Id: {posts[i].Id}\nName: {posts[i].Name}\nContent: {posts[i].Content}\nCreationDateTime: {posts[i].CreationDateTime}\nLikeCount: {posts[i].LikeCount}\nViewCount: {posts[i].ViewCount}");
            }
        }
    }
}

