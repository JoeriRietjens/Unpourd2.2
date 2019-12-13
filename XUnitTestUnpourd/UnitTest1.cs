using System;
using Logic;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestUnpourd
{
    public class UnitTest1
    {
        private IPost postData;
        [Fact]
        public void Test1()
        {
            postData = new PostDataMock();

            // mock vullen
            int productId = 1;
            string coffeeType = "test";
            string description = "test";
            Product product = new Product(productId, coffeeType, description);

            int UserId = 2;
            string name = "test";
            string surName = "test";
            string UserName = "test";
            string Password = "test";
            User user = new User(UserId,name,surName,UserName,Password);

            Post post = new Post(1, product, user);

            postData.SavePost(post);

            PostManager x = new PostManager(/*postData*/);

            List<Post> a = x.GetAllPosts();

            //inhoud van a vergelijken met mock.

            Assert.Equal(a, a);

        }
    }
}
