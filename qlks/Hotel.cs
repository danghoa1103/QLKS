using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlks
{
    public class Hotel
    {
        private List<Room> roomList;
        private List<User> userList;

        public Hotel()
        {
            roomList = new List<Room>();
            userList = new List<User>();
        }

        public void AddRoom(Room room)
        {
            roomList.Add(room);
        }

        public void DisplayRoomList()
        {
            Console.WriteLine("List of rooms in the hotel:");
            foreach (var room in roomList)
            {
                room.DisplayInfo();
            }
        }

        public void AddUser(User user)
        {
            userList.Add(user);
        }

        public void DisplayUserList()
        {
            Console.WriteLine("List of users in the hotel:");
            foreach (var user in userList)
            {
                Console.WriteLine($"Username: {user.Username}, Full Name: {user.FullName}, Age: {user.Age}, Room Number: {user.RoomNumber}");
            }
        }

        public void CheckIn(int roomNumber, string username)
        {
            var room = roomList.Find(r => r.RoomNumber == roomNumber && !r.IsOccupied);
            var user = userList.Find(u => u.Username == username);

            if (room != null && user != null)
            {
                room.IsOccupied = true;
                user.RoomNumber = roomNumber;
                Console.WriteLine($"{user.Username} has checked in to Room {roomNumber}.");
            }
            else
            {
                Console.WriteLine("Unable to check in. Please check the room availability and username.");
            }
        }

        public void CheckOut(int roomNumber)
        {
            var room = roomList.Find(r => r.RoomNumber == roomNumber);
            var user = userList.Find(u => u.RoomNumber == roomNumber);

            if (room != null && user != null)
            {
                room.IsOccupied = false;
                user.RoomNumber = 0; // Trả phòng
                Console.WriteLine($"{user.Username} has checked out from Room {roomNumber}.");
            }
            else
            {
                Console.WriteLine("Unable to check out. Please check the room and user information.");
            }
        }
    }

}
