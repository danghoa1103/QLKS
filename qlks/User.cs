using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlks
{
    public class User
    {
        public string Username { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public int RoomNumber { get; set; }

        public User(string username, string fullName, int age)
        {
            Username = username;
            FullName = fullName;
            Age = age;
            RoomNumber = 0; // Không thuê phòng ban đầu
        }
    }
}
