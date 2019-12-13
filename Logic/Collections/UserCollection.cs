using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    class UserCollection
    {  
        private readonly List<User> _userList = new List<User>();
        public void Add(User user)
        {
            _userList.Add(user);
        }

        public void Remove(User user)
        {
            _userList.Remove(user);
        }

        public List<User> GetAll()
        {
            return _userList;
        }
    }
}
