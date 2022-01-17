using AdminNamespace;
using PostNamespace;
using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Start()
        {
            string id;
            string content;
            string name;
            string username;

            Post[] posts = new Post[4]
            {
                new Post("1", " Google: Share interesting customer stories", "Google Maps is one of those things that doesn’t need much explaining. Most people know what it does, it helps you get from A to B. It can even find you a faster route when there’s loads of traffic up ahead. But a few days back, Google shared an interesting customer story on Twitter. Apparently, marine biologist Johnny Gaskell and a team of researchers, use Google Maps to explore ocean life. You know, way down there. ", 50, 100),
                new Post("2", " Social Media Examiner", " Social Media Examiner is a media company that’s based in the United States. It publishes online magazines, blogs and podcasts about how business people can use social networks. They share interesting news on their Twitter account on a regular basis and have more than 500,000 followers there. The reason that they have so much content to share is that there’s a large community of experts that creates content for Social Media Examiner. ", 70, 90),
                new Post("3","LEGO: Involve your fans and let them get creative", "LEGO has lots of fans around the globe. And a product that people can easily get creative with. For Pride Month they asked people to create something that reflects pride. From all of the pictures they received, they chose a few highlights to share with everyone on Facebook. Which got them quite some likes and positive feedback in the comments.", 200, 300),
                new Post("4","IKEA: Share your values and ambitions", " IKEA is a Scandanavian furniture chain with stores around the world. They are, in their own words, taking ambitious steps towards a more sustainable future. One of their LinkedIn posts that performed well was about their goal to serve a 50% plant-based menu by 2025. Which is interesting, as it has little to do with their main product (furniture and home accessories). But it makes sense when you think about it. You can find a restaurant in almost every IKEA store and they also sell food products that people can take home. ", 250, 270)
            };

            Notification[] notifications = new Notification[] { };
            Admin admin = new Admin("123", "zohravali", "valiyevazohra@gmail.com", "12345", posts, notifications);
            //for (int i = 0; i < posts.Length; i++)
            //{
            //    admin.AddPost(posts[i]);
            //}


            while (true)
            {
                Console.WriteLine("[1] Admin\n[2] User");
                string n = Console.ReadLine();
                if (n == "1")
                {
                    Console.WriteLine("Enter username or email");
                    n = Console.ReadLine();
                    Console.WriteLine("Enter password");
                    n = Console.ReadLine();
                    Console.WriteLine("\n");
                    if (admin.newNotif == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have new notifications\n");
                    }
                    Console.ResetColor();
                    Console.WriteLine("[1] Add Post\n[2] Show Posts\n[3] Show Notifications");
                    n = Console.ReadLine();
                    if (n == "1")
                    {
                        Console.WriteLine("Enter id: ");
                        id = Console.ReadLine();
                        Console.WriteLine("Enter content: ");
                        content = Console.ReadLine();
                        Console.WriteLine("Enter name: ");
                        name = Console.ReadLine();

                        Post post = new Post(id, name, content, 0, 0);
                        admin.AddPost(post);
                    }

                    else if (n == "2") admin.ShowPosts();
                    else if (n == "3") admin.ShowNotif();
                }

                else if (n == "2")
                {
                    Console.WriteLine("Enter username or email");
                    username = Console.ReadLine();
                    Console.WriteLine("Enter password");
                    n = Console.ReadLine();

                    while (true)
                    {
                        for (int i = 0; i < posts.Length; i++)
                        {
                            Console.WriteLine($"Id: {posts[i].Id}\nName: {posts[i].Name}\n\n");
                        }

                        Console.WriteLine("[1] View\n[2] Like");
                        n = Console.ReadLine();
                        if (n == "1")
                        {
                            Console.WriteLine("Enter post id: ");
                            id = Console.ReadLine();
                            for (int i = 0; i < posts.Length; i++)
                            {
                                if (posts[i].Id == id)
                                {
                                    Console.WriteLine($"Id: {posts[i].Id}\nName: {posts[i].Name}\nContent: {posts[i].Content}\nCreationDateTime: {posts[i].CreationDateTime}\nLikeCount: {posts[i].LikeCount}\nViewCount: {posts[i].ViewCount}");
                                    posts[i].AddView();
                                    Notification notification = new Notification("1", "Your post is viewed", username);
                                    admin.AddNotification(notification);
                                    Console.WriteLine("Like? yes[1]/no[2]");
                                    n = Console.ReadLine();
                                    if (n == "1")
                                    {
                                        posts[i].AddLike();
                                        Notification notification1 = new Notification("1", "Your post is liked", username);
                                        admin.AddNotification(notification1);
                                        break;
                                    }
                                    else if (n == "2") break;
                                }
                            }
                        }

                        else if (n == "2")
                        {
                            Console.WriteLine("Enter post id: ");
                            id = Console.ReadLine();
                            for (int i = 0; i < posts.Length; i++)
                            {
                                if (posts[i].Id == id)
                                {
                                    posts[i].AddLike();
                                    Notification notification1 = new Notification("1", "Your post is viewed", username);
                                    admin.AddNotification(notification1);
                                }
                                break;
                            }
                        }
                        Console.WriteLine("Exit? yes[1]/no[2]");
                        n = Console.ReadLine();
                        if (n == "1") break;
                        else if (n == "2") continue;
                    }
                }

            }
        }
        static void Main(string[] args)
        {
            Start();
        }

    }
}

