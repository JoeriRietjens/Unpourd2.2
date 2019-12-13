using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Rating
    {
        public int? Score { get; }
        public string Comment { get; }
       
        public Rating(int score, string comment)
        {
            Score = score;
            Comment = comment;
        }
    }
}
