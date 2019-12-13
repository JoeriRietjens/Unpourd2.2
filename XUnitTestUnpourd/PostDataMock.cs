using System;
using System.Collections.Generic;
using System.Text;
using Logic;

namespace XUnitTestUnpourd
{
    class PostDataMock : IPost
    {
        private List<Post> MockPosts = new List<Post>();
        public bool DeletePost(Post deletePost)
        {
            
            if (MockPosts.Contains(deletePost))
            {
                MockPosts.Remove(deletePost);
                return true;
            }
            return false;
        }

        public List<Post> GetAllPost()
        {
            return MockPosts;
        }

        public bool SavePost(Post newPost)
        {
            MockPosts.Add(newPost);
            return true;
        }
    }
}
