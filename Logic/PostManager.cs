using System;
using System.Collections.Generic;
using System.Text;


namespace Logic
{
    public class PostManager
    {
        IPost post;

        public PostManager(IPost post)
        {
            this.post = post;
        }
        
        public List<Post> GetAllPosts()
        {
            return post.GetAllPost();
        }

    }
}
 