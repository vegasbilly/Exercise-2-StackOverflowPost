using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();

            post["title"] = "MyPost";
            post["description"] = "This is a description of my post";
            Console.WriteLine(post["title"]);
            Console.WriteLine(post["description"]);
            Console.WriteLine("This post was created: " + post.TimeCreated());

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("\n\nTo UpVote this post, press 1.");
                Console.WriteLine("To DownVote this post, press  2.");
                if (Console.ReadLine() == "1")
                {
                    post.UpVote++;
                }
                else if (Console.ReadLine() == "2")
                {
                    post.DownVote++;
                }
                Console.WriteLine("\nThere are currently " + post.UpVote + " UpVotes " + "And " + post.DownVote + " Down Votes");
            }

                

        }
    }
}
