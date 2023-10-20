using System;
using System.Collections.Generic;

namespace qlks
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();

            while (true)
            {
                Console.WriteLine("======= Menu =======");

                Console.WriteLine("0. Add Single Room");
                Console.WriteLine("1. Add Double Room");
                Console.WriteLine("2. Display Room List");
                Console.WriteLine("3. Add User");
                Console.WriteLine("4. Display User List");
                Console.WriteLine("5. Check In");
                Console.WriteLine("6. Check Out");
                Console.WriteLine("7. Exit");
                Console.WriteLine("====================");

                Console.Write("Select an option: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.Write("Enter Single Room number: ");
                        int singleRoomNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Single Room price: ");
                        double singleRoomPrice = Convert.ToDouble(Console.ReadLine());
                        hotel.AddRoom(new SingleRoom(singleRoomNumber, singleRoomPrice));
                        break;
                    case 1:
                        Console.Write("Enter Double Room number: ");
                        int doubleRoomNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Double Room price: ");
                        double doubleRoomPrice = Convert.ToDouble(Console.ReadLine());
                        hotel.AddRoom(new DoubleRoom(doubleRoomNumber, doubleRoomPrice));
                        break;

                    case 2:
                        hotel.DisplayRoomList();
                        break;

                    case 3:
                        Console.Write("Enter Username: ");
                        string username = Console.ReadLine();
                        Console.Write("Enter Full Name: ");
                        string fullName = Console.ReadLine();
                        Console.Write("Enter Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        hotel.AddUser(new User(username, fullName, age));
                        break;

                    case 4:
                        hotel.DisplayUserList();
                        break;

                    case 5:
                        Console.Write("Enter the room number to check in: ");
                        int roomNumberToCheckIn = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the username: ");
                        string checkInUsername = Console.ReadLine();
                        hotel.CheckIn(roomNumberToCheckIn, checkInUsername);
                        break;

                    case 6:
                        Console.Write("Enter the room number to check out: ");
                        int roomNumberToCheckOut = Convert.ToInt32(Console.ReadLine());
                        hotel.CheckOut(roomNumberToCheckOut);
                        break;

                    case 7:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select again.");
                        break;
                }
            }
        }
    }
}