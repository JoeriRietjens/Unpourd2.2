using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Comment
    {
        public string Commentary { get; }

        private readonly User user;
        public Comment(User user, string commentary)
        {
            Commentary = commentary;
        }
    }
}
