using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public interface IPost
    {
        public List<Post> GetAllPost();

        public bool SavePost(Post newPost);

        public bool DeletePost(Post deletePost);

    }
}
