using System;
using System.Collections.Generic;

namespace Exercise_2
{
    public class Post
    {
        
        private readonly Dictionary<string, string> _dictionary;
        private readonly string vote = Console.ReadKey().ToString();

        public int UpVote { get; set; }
        public int DownVote { get; set; }

        public Post()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public DateTime TimeCreated()
        {
            DateTime timeCreated = DateTime.Now;

            return timeCreated;
        }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}