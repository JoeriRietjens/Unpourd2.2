using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Post
    {
        public int Id { get; }

        public Product Product { get; }
        public User User { get; }

        public Rating rating { get; private set; }

        public Comment comment { get; private set; }

        private readonly List<Comment> _comments = new List<Comment>();
        private readonly List<Like> _likes = new List<Like>();

        public Post(int id, Product product, User user)
        {
            Id = id;
            Product = product;
            User = user;
        }

        public void AddRating(int score, string comment)
        {
             rating = new Rating(score, comment);
        }

        public void AddComment(User user,string commentary)
        {
             comment = new Comment(user, commentary);
            _comments.Add(comment);
        }

        public IEnumerable<Comment> GetComments()
        {
            return _comments;
        }

        public void AddLike(User user)
        {
            Like like = new Like(user);
            _likes.Add(like);
        }
        public IEnumerable<Like> GetLikes()
        {
            return _likes;
        }
    }
}
