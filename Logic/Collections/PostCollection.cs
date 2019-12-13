using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    class PostCollection
    {
        private List<Post> PostList = new List<Post>();
        public void Add(Post post)
        {
            PostList.Add(post);
        }

        public void Remove(Post post)
        {
            PostList.Remove(post);
        }

        public List<Post> GetAll()
        {
            return PostList;
        }
    }
}
